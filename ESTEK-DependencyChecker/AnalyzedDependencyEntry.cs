using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTEK_DependencyChecker
{
    public class AnalyzedDependencyEntry
    {
        public string fileName { get; set; }
        public string dependency { get; set; }
        public bool found { get; set; }
    }
}
