using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace TableTopRPG
{
    public partial class frmCharacterSheet : Form
    {

        Random randomRoll = new Random();

        public frmCharacterSheet()
        {
            InitializeComponent();
        }

        private string raceData;
        private FinalCharacter character;

        private void btnCalculateScores_Click(object sender, EventArgs e)
        {
           
            txtStrength.Text = rollStats();
            txtDexterity.Text = rollStats();
            txtConstitution.Text = rollStats();
            txtIntelligence.Text = rollStats();
            txtWisdom.Text = rollStats();
            txtCharisma.Text = rollStats();

            int strength = Convert.ToInt32(txtStrength.Text);
            int dexterity = Convert.ToInt32(txtDexterity.Text);
            int constitution = Convert.ToInt32(txtConstitution.Text);
            int intelligence = Convert.ToInt32(txtIntelligence.Text);
            int wisdom = Convert.ToInt32(txtWisdom.Text);
            int charisma = Convert.ToInt32(txtCharisma.Text);

            CalculateScores(txtStrengthMod, strength);
            CalculateScores(txtDexterityMod, dexterity);
            CalculateScores(txtConstitutionMod, constitution);
            CalculateScores(txtIntelligenceMod, intelligence);
            CalculateScores(txtWisdomMod, wisdom);
            CalculateScores(txtCharismaMod, charisma);


        }

        private string rollStats()
        {
            int diceValue = randomRoll.Next(1, 7) + randomRoll.Next(1, 7) + randomRoll.Next(1, 7);
            return diceValue.ToString();
        }

        private void CalculateScores(TextBox textBoxMod, int stat)
        {
            if (stat <= 10 || stat == 11)
            {
                textBoxMod.Text = "0";
            }
            else if (stat == 12 || stat == 13)
            {
                textBoxMod.Text = "1";
            }
            else if (stat == 14 || stat == 15)
            {
                textBoxMod.Text = "2";
            }
            else if (stat == 16 || stat == 17)
            {
                textBoxMod.Text = "3";
            }
            else if (stat >= 18)
            {
                textBoxMod.Text = "4";
            }
            else
            {
                textBoxMod.Text = "";
            }
        }

        private void btnCharacterNameConfirm_Click(object sender, EventArgs e)
        {
            ConfirmName(txtCharacterName, btnCharacterNameConfirm);
        }

        private void btnPlayerName_Click(object sender, EventArgs e)
        {
            ConfirmName(txtPlayerName, btnPlayerName);
        }

        private void ConfirmName(TextBox nameTextBox, Button nameButton)
        {
            nameTextBox.ReadOnly = !nameTextBox.ReadOnly;
            if (nameTextBox.ReadOnly == true)
            {
                nameButton.Text = "Edit Name";
            }
            else
            {
                nameButton.Text = "Confirm Name";
            }
        }

        private void btnPickAlignment_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAlignment(), txtAlignment);
        }

        private void btnPickRace_Click(object sender, EventArgs e)
        {
            // lboFeaturesTraits.Items.Clear();
            OpenForm(new frmRace(), txtRace); 
        }

        private void btnPickClass_Click(object sender, EventArgs e)
        {
            // lboFeaturesTraits.Items.Clear();
            OpenForm(new frmClass(), txtClass);
        }

        private void OpenForm(Form openForm, TextBox chosenOption)
        {
            Form form = openForm;
            DialogResult selectedButton = form.ShowDialog();
            if(selectedButton == DialogResult.OK)
            {
                // chosenOption.Text = (string)form.Tag;
               // raceData = (string)form.Tag;

                dataExtraction((string)form.Tag);
                
            }
        }

        private void dataExtraction(string data)
        {
            if (data.Contains("RaceChoice"))
            {
                string[] raceSplit = data.Split('!');
                string[] raceStatsOne = raceSplit[0].Split('|');
                string[] raceStatsTwo = raceSplit[1].Split('|');

                txtRace.Text = raceStatsOne[1];
                txtSpeed.Text = raceStatsOne[2];

                int traitLength = Int32.Parse(raceStatsOne[raceStatsOne.Length - 1]);
                string[] traits = new string[traitLength];
                Array.Copy(raceStatsOne, 3, traits, 0, traitLength);

                foreach (string trait in traits)
                {
                    lboFeaturesTraits.Items.Add(trait);
                }

                racialStatAdditions(txtRace.Text);

                int languageLength = Int32.Parse(raceStatsTwo[raceStatsTwo.Length - 1]);
                string[] languages = new string[languageLength];
                Array.Copy(raceStatsTwo, 0, languages, 0, languageLength);

                foreach (string language in languages)
                {
                    lboOtherProfsLangs.Items.Add(language);
                }

            }
            else if (data.Contains("ClassChoice"))
            {
                string[] classStatSplit = data.Split('!');
                string[] classStatsOne = classStatSplit[0].Split('|');
                string[] classStatsTwo = classStatSplit[1].Split('|');
                string[] classStatsThree = classStatSplit[2].Split('|');
                txtClass.Text = classStatsOne[1];
                txtHitDice.Text = classStatsOne[2];

                int profLength = Int32.Parse(classStatsOne[classStatsOne.Length - 1]);
                string[] profs = new string[profLength];
                Array.Copy(classStatsOne, 3, profs, 0, profLength);

                foreach(string prof in profs)
                {
                    lboFeaturesTraits.Items.Add(prof);
                }

                int profChoices = Int32.Parse(classStatsTwo[classStatsTwo.Length - 1]);
                string[] pickedSkills = new string[profChoices];
                Array.Copy(classStatsTwo, 0, pickedSkills, 0, profChoices);

                foreach(string skill in pickedSkills)
                {
                    string formattedCheckboxName = "cbo" + skill;
                    string formattedCheckboxValue = "txt" + skill;

                    checkSkills(formattedCheckboxName, formattedCheckboxValue);
                }

                int equipmentLength = Int32.Parse(classStatsThree[classStatsThree.Length - 1]);
                string[] startingEquipment = new string[equipmentLength];
                Array.Copy(classStatsThree, 0, startingEquipment, 0, equipmentLength);

                foreach (string equipment in startingEquipment)
                {
                    lboEquipment.Items.Add(equipment);
                }

                txtArmorClass.Text = (10 + Convert.ToInt32(txtDexterityMod.Text)).ToString();

                if (data.Contains("Barbarian"))
                {
                    txtArmorClass.Text = (Convert.ToInt32(txtArmorClass.Text) + Convert.ToInt32(txtConstitutionMod.Text)).ToString();
                }
                else if (data.Contains("Monk"))
                {
                    txtArmorClass.Text = (Convert.ToInt32(txtArmorClass.Text) + Convert.ToInt32(txtWisdomMod.Text)).ToString();
                }

            }

            else if (data.Contains("Alignment"))
            {
                string[] alignmentData = data.Split('|');
                txtAlignment.Text = alignmentData[1];

            }

        }

        private void checkSkills(string checkBoxName, string checkBoxValue)
        {
            CheckBox checkBox = (CheckBox)this.Controls.Find(checkBoxName.ToString(), true)[0];
            TextBox textBox = (TextBox)this.Controls.Find(checkBoxValue.ToString(), true)[0];
            checkBox.Checked = true;
            textBox.Text = "2";
            
        }

        private void btnPickBackground_Click(object sender, EventArgs e)
        {

        }

        private void racialStatAdditions(string raceName)
        {

            int strength = Convert.ToInt32(txtStrength.Text);
            int dexterity = Convert.ToInt32(txtDexterity.Text);
            int constitution = Convert.ToInt32(txtConstitution.Text);
            int intelligence = Convert.ToInt32(txtIntelligence.Text);
            int wisdom = Convert.ToInt32(txtWisdom.Text);
            int charisma = Convert.ToInt32(txtCharisma.Text);

            switch (raceName)
            {
                case "Dragonborn":
                    txtStrength.Text = (strength + 2).ToString();
                    txtCharisma.Text = (charisma + 1).ToString();
                    txtStrSavTh.Text = (2 + Convert.ToInt32(txtProficiencyBonus.Text)).ToString();
                    txtChaSavTh.Text = (1 + Convert.ToInt32(txtProficiencyBonus.Text)).ToString();
                    cboStr.Checked = true;
                    cboCha.Checked = true;
                    break;
                case "Dwarf":
                    txtConstitution.Text = (constitution + 2).ToString();
                    break;
                case "Elf":
                    txtDexterity.Text = (dexterity + 2).ToString();
                    break;
                case "Gnome":
                    txtIntelligence.Text = (intelligence + 2).ToString();
                    break;
                case "Half-Elf":
                    txtCharisma.Text = (charisma + 2).ToString();
                    break;
                case "Half-Orc":
                    txtStrength.Text = (strength + 2).ToString();
                    txtConstitution.Text = (constitution + 2).ToString();
                    break;
                case "Halfling":
                    txtDexterity.Text = (dexterity + 2).ToString();
                    break;
                case "Human":
                    txtStrength.Text = (strength + 1).ToString();
                    txtDexterity.Text = (dexterity + 1).ToString();
                    txtConstitution.Text = (constitution + 1).ToString();
                    txtIntelligence.Text = (intelligence + 1).ToString();
                    txtWisdom.Text = (wisdom + 1).ToString();
                    txtCharisma.Text = (charisma + 1).ToString();
                    break;
                case "Tiefling":
                    txtIntelligence.Text = (intelligence + 1).ToString();
                    txtCharisma.Text = (charisma + 1).ToString();
                    break;
                default:
                    break;
            }

            txtPassiveWisdom.Text = (Convert.ToInt32(txtWisdomMod.Text) + 10).ToString();


        }

        private void ClearBoxes()
        {
            // clear descriptions and listboxes
            lboFeaturesTraits.Items.Clear();
            lboAttacksSpells.Items.Clear();
            lboEquipment.Items.Clear();
            lboOtherProfsLangs.Items.Clear();
            txtCharacterName.Clear();
            txtClass.Clear();
            txtRace.Clear();
            txtBackground.Clear();
            txtPlayerName.Clear();
            txtAlignment.Clear();
            txtStrength.Text = "0";
            txtDexterity.Text = "0";
            txtConstitution.Text = "0";
            txtIntelligence.Text = "0";
            txtWisdom.Text = "0";
            txtCharisma.Text = "0";
            txtStrengthMod.Clear();
            txtDexterityMod.Clear();
            txtConstitutionMod.Clear();
            txtIntelligenceMod.Clear();
            txtWisdomMod.Clear();
            txtCharismaMod.Clear();
            txtStrSavTh.Clear();
            txtDexSavTh.Clear();
            txtConSavTh.Clear();
            txtIntSavTh.Clear();
            txtWisSavTh.Clear();
            txtChaSavTh.Clear();
            cboStr.Checked = false;
            cboDex.Checked = false;
            cboCon.Checked = false;
            cboInt.Checked = false;
            cboWis.Checked = false;
            cboCha.Checked = false;
            txtAcrobatics.Clear();
            txtAnimalHandling.Clear();
            txtArcana.Clear();
            txtAthletics.Clear();
            txtDeception.Clear();
            txtHistory.Clear();
            txtInsight.Clear();
            txtIntimidation.Clear();
            txtInvestigation.Clear();
            txtInvestigation.Clear();
            txtMedicine.Clear();
            txtNature.Clear();
            txtPerception.Clear();
            txtPerformance.Clear();
            txtPersuasion.Clear();
            txtReligion.Clear();
            txtSleightOfHand.Clear();
            txtStealth.Clear();
            txtSurvival.Clear();
            txtInspiration.Text = "0";
            txtArmorClass.Clear();
            txtInitiative.Text = "0";
            txtProficiencyBonus.Text = "2";
            txtSpeed.Clear();
            txtHitDice.Clear();
            txtPassiveWisdom.Clear();
            txtPersonalityTraits.Clear();
            txtIdeals.Clear();
            txtBonds.Clear();
            txtFlaws.Clear();
            txtCharacterBackstory.Clear();
            cboAcrobatics.Checked = false;
            cboAnimalHandling.Checked = false;
            cboArcana.Checked = false;
            cboAthletics.Checked = false;
            cboDeception.Checked = false;
            cboHistory.Checked = false;
            cboInsight.Checked = false;
            cboIntimidation.Checked = false;
            cboInvestigation.Checked = false;
            cboMedicine.Checked = false;
            cboNature.Checked = false;
            cboPerception.Checked = false;
            cboPerformance.Checked = false;
            cboPersuasion.Checked = false;
            cboReligion.Checked = false;
            cboSleightOfHand.Checked = false;
            cboStealth.Checked = false;
            cboSurvival.Checked = false;

        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            character = null;
            ClearBoxes();
        }

        private void btnClearValues_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
    }
}
