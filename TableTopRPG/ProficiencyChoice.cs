using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPG
{
    class ProficiencyChoice
    {
        public class Class
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Reference
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
        
        public string index { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public List<Class> classes { get; set; }
        public List<object> races { get; set; }
        public string url { get; set; }
        public Reference reference { get; set; }
        
    }
}
