using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPG
{
    class SubclassChoice
    {
        public class Class
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        
        public string index { get; set; }
        public Class @class { get; set; }
        public string name { get; set; }
        public string subclass_flavor { get; set; }
        public List<string> desc { get; set; }
        public string subclass_levels { get; set; }
        public string url { get; set; }
        public List<object> spells { get; set; }
        
    }
}
