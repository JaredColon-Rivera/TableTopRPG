using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPG
{
    class TraitDescriptions
    {
        public class Race
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

       
        public string index { get; set; }
        public List<Race> races { get; set; }
        public List<object> subraces { get; set; }
        public string name { get; set; }
        public List<string> desc { get; set; }
        public List<object> proficiencies { get; set; }
        public string url { get; set; }
        

    }
}
