using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEK_DependencyChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (VerifyParameters())
            {
                string[] filesToAnalyze = txtFilesToAnalyze.Text.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string[] dependenciesToCheck = txtDependecyNames.Text.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                if (filesToAnalyze.Count() > 0 && dependenciesToCheck.Count() > 0)
                {
                    //we have something to do
                    //first check if all the files to analyze actually exist
                    List<string> validFiles = new List<string>(filesToAnalyze.Count());
                    List<string> invalidFiles = new List<string>();
                    foreach (var item in filesToAnalyze)
                    {
                        if (File.Exists(item))
                        {
                            validFiles.Add(item);
                        }
                        else
                        {
                            invalidFiles.Add(item);
                        }
                    }
                    if (validFiles.Count() == 0)
                    {
                        MessageBox.Show(Properties.Resources.ERROR_ALL_FILES_DONT_EXIST);
                    }
                    else
                    {
                        if (invalidFiles.Count() > 0)
                        {
                            MessageBox.Show(Properties.Resources.ERROR_FILES_DONT_EXIST+ System.Environment.NewLine + string.Join(System.Environment.NewLine, invalidFiles));
                        }
                        // now we can start the calls to the dependends executable
                        var analyzedOutput = new AnalyzedOutput(DependencyWalkerWrapper.AnalyzeFiles(validFiles, dependenciesToCheck));
                        analyzedOutput.MdiParent = this.MdiParent;
                        analyzedOutput.Show();
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.ERROR_EMPTY_PARAMETERS);
                }
            }
        }

        private bool VerifyParameters()
        {
            if (string.IsNullOrWhiteSpace(txtFilesToAnalyze.Text))
            {
                MessageBox.Show(Properties.Resources.ERROR_EMPTY_PARAMETERS);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDependecyNames.Text))
            {
                MessageBox.Show(Properties.Resources.ERROR_EMPTY_PARAMETERS);
                return false;
            }
            return true;
        }

        private void btnSearchFilesToAnalyze_Click(object sender, EventArgs e)
        {
            ofdFilesToAnalyze.ShowDialog();
        }

        private void ofdFilesToAnalyze_FileOk(object sender, CancelEventArgs e)
        {
            txtFilesToAnalyze.Text += System.Environment.NewLine + string.Join(System.Environment.NewLine, ofdFilesToAnalyze.FileNames);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
