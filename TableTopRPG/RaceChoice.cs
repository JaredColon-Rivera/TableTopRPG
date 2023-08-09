using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPG
{
    class RaceChoice
    {
        public class AbilityBonuses
        {
            public AbilityScore ability_score { get; set; }
            public int bonus { get; set; }
        }

        public class AbilityScore
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class From
        {
            public string option_set_type { get; set; }
            public List<Option> options { get; set; }
        }

        public class Item
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Language
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Option
        {
            public string option_type { get; set; }
            public Item item { get; set; }
        }

        public string index { get; set; }
        public string name { get; set; }
        public int speed { get; set; }
        public List<AbilityBonuses> ability_bonuses { get; set; }
        public string alignment { get; set; }
        public string age { get; set; }
        public string size { get; set; }
        public string size_description { get; set; }
        public List<StartingProficiency> starting_proficiencies { get; set; }
        public StartingProficiencyOptions starting_proficiency_options { get; set; }
        public List<Language> languages { get; set; }
        public string language_desc { get; set; }
        public List<Trait> traits { get; set; }
        public List<Subrace> subraces { get; set; }
        public string url { get; set; }
        

        public class StartingProficiency
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class StartingProficiencyOptions
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From from { get; set; }
        }

        public class Subrace
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Trait
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
