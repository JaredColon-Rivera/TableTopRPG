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
using static TableTopRPG.CharacterSheetService;

namespace TableTopRPG
{
    public partial class frmRace : Form
    {
        public frmRace()
        {
            InitializeComponent();
           

        }

        string confirmedRace = "";
        string searchData = "";
        List<string> traitArray = new List<string>();
        List<string> languageArray = new List<string>();
        string finalRaceChoice;

        private void searchRaceAndTraits(string searchCriteria)
        {
            if (searchCriteria.Contains("races"))
            {
                searchData = searchAPI(searchCriteria);

                RaceChoice apiInfo = JsonSerializer.Deserialize<RaceChoice>(searchData);

                grpName.Text = apiInfo.name;

                if(grpName.Text == "Human")
                {
                    txtAbilityBonus.Text = "Your ability scores each increase by +1";
                }
                else
                {
                    string abilityScore = statTranslation(apiInfo.ability_bonuses[0].ability_score.name.ToString());
                    string abilityBonus = apiInfo.ability_bonuses[0].bonus.ToString();
                    txtAbilityBonus.Text = "Your " + abilityScore + " is increased by " + "+" + abilityBonus;
                    if (apiInfo.ability_bonuses.Count > 1)
                    {
                        string secondAbilityScore = statTranslation(apiInfo.ability_bonuses[1].ability_score.name.ToString());
                        string secondAbilityBonus = apiInfo.ability_bonuses[1].bonus.ToString();
                        txtAbilityBonus.Text += ", and your " + secondAbilityScore + " is increased by " + "+" + secondAbilityBonus;
                    }
                }
              

                // clear trait description
                txtTraitDescription.Text = "";

                

                txtAge.Text = apiInfo.age;
                txtAlignment.Text = apiInfo.alignment;
                txtSize.Text = apiInfo.size;
                txtSizeDesc.Text = apiInfo.size_description;
                txtSpeed.Text = apiInfo.speed.ToString();
                lboTraits.Items.Clear();
                foreach (var trait in apiInfo.traits)
                {
                    lboTraits.Items.Add(trait.name);
                    traitArray.Add(trait.name);
                }

                txtLanguages.Text = apiInfo.language_desc;

                foreach(var language in apiInfo.languages)
                {
                    languageArray.Add(language.name);
                }

                if (apiInfo.subraces.Count > 0)
                {
                    txtSubraces.Text = apiInfo.subraces[0].name.ToString();
                }
                else
                {
                    txtSubraces.Text = "None";
                }

                confirmedRace = apiInfo.name;

            }
            if (searchCriteria.Contains("traits"))
            {
                searchData = searchAPI(searchCriteria);
                TraitDescriptions apiInfo = JsonSerializer.Deserialize<TraitDescriptions>(searchData);

                txtTraitDescription.Text = apiInfo.desc[0].ToString();

            }

        }

        private void btnDragonborn_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnDragonborn.Text.ToLower());
        }

        private void btnDwarf_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnDwarf.Text.ToLower());
        }

        private void btnElf_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnElf.Text.ToLower());
        }

        private void btnGnome_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnGnome.Text.ToLower());
        }

        private void btnHalfElf_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnHalfElf.Text.ToLower());
        }

        private void btnHalfOrc_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnHalfOrc.Text.ToLower());
        }

        private void btnHalfling_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnHalfling.Text.ToLower());
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnHuman.Text.ToLower());
        }

        private void btnTiefling_Click(object sender, EventArgs e)
        {
            searchRaceAndTraits(apiSearchPathRaces + btnTiefling.Text.ToLower());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Tag = createRaceString();
            Console.WriteLine(this.Tag);
            this.DialogResult = DialogResult.OK;
        }

        private void lboTraits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchItem = ((ListBox)sender).SelectedItem.ToString().ToLower();
            if(searchItem.Contains(" "))
            {
                searchItem = searchItem.Replace(" ", "-");
            }
            searchRaceAndTraits(apiSearchPathTraits + searchItem);
           
        }

        private string createRaceString()
        {
            string finalTraitArray = "";
            foreach(string trait in traitArray)
            {
                finalTraitArray += "|" + trait;
            }

            string finalLanguageArray = "";
            foreach(string language in languageArray)
            {
                finalLanguageArray += language + "|";
            }

            // add new symbol like ! for languages

            string formattedString = $"RaceChoice|{grpName.Text}|{txtSpeed.Text}{finalTraitArray}|{traitArray.Count}!" +
                                     $"{finalLanguageArray}|{languageArray.Count}";
            return formattedString;
        }
    }
}
