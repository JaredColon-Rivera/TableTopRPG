using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTopRPG
{
    class CharacterSheetService
    {
        public static string apiSearchPathRaces = "api/races/";
        public static string apiSearchPathTraits = "api/traits/";
        public static string apiSearchPathClasses = "api/classes/";
        public static string apiSearchPathProficiencies = "api/proficiencies/";
        public static string apiSearchPathSkills = "api/skills/";
        public static string apiSearchPathSubclasses = "api/subclasses/";
        public static string statTranslation(string stat)
        {
            string statTranslated = "";
            switch (stat)
            {
                case "CHA":
                    statTranslated = "Charisma";
                    break;
                case "CON":
                    statTranslated = "Constitution";
                    break;
                case "DEX":
                    statTranslated = "Dexterity";
                    break;
                case "INT":
                    statTranslated = "Intelligence";
                    break;
                case "STR":
                    statTranslated = "Strength";
                    break;
                case "WIS":
                    statTranslated = "Wisdom";
                    break;
                default:
                    break;
            }
            return statTranslated;
        }

        public static string searchAPI(string searchCriteria)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.dnd5eapi.co/");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));


            //searchLink = "api/" + searchCriteria + "/" + buttonText.ToLower();

            string searchLink = searchCriteria;


            var response = client.GetAsync(searchLink).Result;
            var data = response.Content.ReadAsStringAsync().Result;



            return data;
        }
    }
}
