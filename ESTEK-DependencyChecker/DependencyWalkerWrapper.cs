using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTEK_DependencyChecker
{
    public class DependencyWalkerWrapper
    {
        public static bool IsFileReady(String sFilename)
        {
            // If the file can be opened for exclusive access it means that the file
            // is no longer locked by another process.
            try
            {
                using (FileStream inputStream = File.Open(sFilename, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    if (inputStream.Length > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Dictionary<string,Dictionary<string,bool>> AnalyzeFiles(IEnumerable<string> files, IEnumerable<string> dependencies)
        {
            Dictionary<string, Dictionary<string, bool>> filesAnalyzed = new Dictionary<string, Dictionary<string, bool>>();
            foreach (var item in files)
            {
                filesAnalyzed[item] = AnalyzeFile(item, dependencies);
            }
            return filesAnalyzed;
        }
        public static Dictionary<string,bool> AnalyzeFile(string fullFilePath, IEnumerable<string> dependencies)
        {
            string fileName = Path.GetFileName(fullFilePath);
            string csvFileName = fileName + ".csv";
            //first we need to write the csv file calling the dependency checker
            ProcessStartInfo startInfo = new ProcessStartInfo(HardCodedStrings.DEPENDENDECY_WALKER_EXE);
            startInfo.Arguments = string.Join(" ",new string[] {
                                                "/c",
                                                "/oc:"+"\""+csvFileName+"\"",
                                                "\""+fullFilePath+"\""
                                                });
            startInfo.UseShellExecute = false;
            
            var process = System.Diagnostics.Process.Start(startInfo);
            process.WaitForExit();
            while (!IsFileReady(csvFileName))
            {
                //wait
                System.Threading.Thread.Sleep(100);
            }
            // read the CSV file
            StreamReader sr = new StreamReader(csvFileName);
            var fileToString = sr.ReadToEnd();
            sr.Close();

            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            var fileLines = fileToString.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in fileLines)
            {
                var splittedLine = item.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (splittedLine.Count()>1)
                {
                    foreach (var dependency in dependencies)
                    {
                        if (splittedLine[1].ToUpperInvariant().CompareTo(dependency.ToUpperInvariant()) == 0
                            || splittedLine[1].ToUpperInvariant().CompareTo("\""+dependency.ToUpperInvariant()+ "\"") == 0)
                        {
                            dic[dependency] = true;
                        }
                    }
                }
            }

            return dic;
        }
    }
}
