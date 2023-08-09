using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPG
{
    class SkillsChoice
    {
        public class AbilityScore
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

       
        public string index { get; set; }
        public string name { get; set; }
        public List<string> desc { get; set; }
        public AbilityScore ability_score { get; set; }
        public string url { get; set; }
        

    }
}
