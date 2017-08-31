using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEK_DependencyChecker
{
    public partial class AnalyzedOutput : Form
    {
        public AnalyzedOutput(Dictionary<string,Dictionary<string,bool>> analyzedFiles)
        {
            InitializeComponent();
            List<AnalyzedDependencyEntry> list = new List<AnalyzedDependencyEntry>();
            foreach (var file in analyzedFiles)
            {
                foreach (var dependencyItem in file.Value)
                {
                    list.Add(new AnalyzedDependencyEntry() { fileName = file.Key, dependency = dependencyItem.Key, found = dependencyItem.Value });
                }
            }
            dataGridView1.DataSource = list;
        }
    }
}
