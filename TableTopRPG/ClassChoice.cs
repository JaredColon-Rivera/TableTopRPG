using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPG
{
    class ClassChoice
    {
        public string index { get; set; }
        public string name { get; set; }
        public int hit_die { get; set; }
        public List<ProficiencyChoice> proficiency_choices { get; set; }
        public List<Proficiency> proficiencies { get; set; }
        public List<SavingThrow> saving_throws { get; set; }
        public List<StartingEquipment> starting_equipment { get; set; }
        public List<StartingEquipmentOption> starting_equipment_options { get; set; }
        public string class_levels { get; set; }
        public MultiClassing multi_classing { get; set; }
        public List<Subclass> subclasses { get; set; } 
        public string url { get; set; }

        public class AbilityScore
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Choice
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From from { get; set; }
        }

        public class Equipment
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class EquipmentCategory
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class From
        {
            public string option_set_type { get; set; }
            public List<Option> options { get; set; }
            public EquipmentCategory equipment_category { get; set; }
        }

        public class Item
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class MultiClassing
        {
            public List<Prerequisite> prerequisites { get; set; }
            public List<Proficiency> proficiencies { get; set; }
        }

        public class Of
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Option
        {
            public string option_type { get; set; }
            public Item item { get; set; }
            public int count { get; set; }
            public Of of { get; set; }
            public Choice choice { get; set; }
        }

        public class Prerequisite
        {
            public AbilityScore ability_score { get; set; }
            public int minimum_score { get; set; }
        }

        public class Proficiency
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class ProficiencyChoice
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From from { get; set; }
        }

        public class SavingThrow
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class StartingEquipment
        {
            public Equipment equipment { get; set; }
            public int quantity { get; set; }
        }

        public class StartingEquipmentOption
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From from { get; set; }
        }

        public class Subclass
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
    }
}
