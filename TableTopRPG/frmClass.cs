using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using static TableTopRPG.CharacterSheetService;


namespace TableTopRPG
{
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        string confirmedClass = "";
        string searchData = "";
        string startingEquipment = "";
        List<string> profArray = new List<string>();
        List<string> selectedProfChoices = new List<string>();
        List<string> startingEquipmentList = new List<string>();


        private void searchClassAndProficiencies(string searchCriteria)
        {
            
            

            if (searchCriteria.Contains("subclasses"))
            {
                searchData = searchAPI(searchCriteria);

                SubclassChoice apiInfo = JsonSerializer.Deserialize<SubclassChoice>(searchData);

                txtSubClassDesc.Text = apiInfo.desc[0];
            }

            else if (searchCriteria.Contains("classes"))
            {
                searchData = searchAPI(searchCriteria);

                ClassChoice apiInfo = JsonSerializer.Deserialize<ClassChoice>(searchData);

                grpName.Text = apiInfo.name;

                txtHitDice.Text = apiInfo.hit_die.ToString();

                foreach(var prof in apiInfo.proficiencies)
                {
                    lboProficiencies.Items.Add(prof.name);
                    profArray.Add(prof.name);
                }

                txtProfChoices.Text = apiInfo.proficiency_choices[0].desc;

                foreach(var profCh in apiInfo.proficiency_choices[0].from.options)
                {
                    string itemName = profCh.item.name.Remove(0, 7);
                    lboProfChoices.Items.Add(itemName);
                }

                foreach(var equipment in apiInfo.starting_equipment)
                {
                    startingEquipment = equipment.quantity + " " + equipment.equipment.name;
                    lboStarterEquipment.Items.Add(startingEquipment);
                    startingEquipmentList.Add(startingEquipment);
                    Console.WriteLine(startingEquipment);
                }

                foreach(var equipmentChoice in apiInfo.starting_equipment_options)
                {
                    if (equipmentChoice.desc.Contains("(a)"))
                    {
                        lboEquipmentChoices.Items.Add(equipmentChoice.desc);

                    }
                    else
                    {
                        string firstLetter = equipmentChoice.desc.Substring(0, 1).ToUpper();
                        string otherLetters = equipmentChoice.desc.Substring(1).ToLower();
                        string defaultEquipment = firstLetter + otherLetters;
                        lboStarterEquipment.Items.Add(defaultEquipment) ;
                    }
                }

                foreach(var subclassChoice in apiInfo.subclasses)
                {
                    lboSubClassChoice.Items.Add(subclassChoice.name);
                }

                confirmedClass = apiInfo.name;

            }
            if (searchCriteria.Contains("proficiencies"))
            {
                searchData = searchAPI(searchCriteria);

                ProficiencyChoice apiInfo = JsonSerializer.Deserialize<ProficiencyChoice>(searchData);


            }
            if (searchCriteria.Contains("skills"))
            {
                searchData = searchAPI(searchCriteria);

                SkillsChoice apiInfo = JsonSerializer.Deserialize<SkillsChoice>(searchData);

                txtProfChoiceDesc.Text = apiInfo.desc[0];
            }
           
        }

        private void lboProfChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchItem = "";
            string listBoxItem = "";
            string pickedProf = ((ListBox)sender).SelectedItem.ToString();
            Console.WriteLine(pickedProf);
      
            selectedProfChoices.Add(pickedProf);

            bool isValid = true;
            try
            {
                listBoxItem = ((ListBox)sender).SelectedItem.ToString().ToLower();
                
            }
            catch (Exception ex)
            {
             
                MessageBox.Show("Please select your proficiencies", "Entry Error");
                listBoxItem = null;
                isValid = false;
            }

            if (txtProfChoices.Text.Contains("two"))
            {
                if (((ListBox)sender).SelectedItems.Count == 2)
                {
                    lboProfChoices.Enabled = false;
                    btnRepickProf.Enabled = true;
                }
            }
            else if (txtProfChoices.Text.Contains("three"))
            {
                if (((ListBox)sender).SelectedItems.Count == 3)
                {
                    lboProfChoices.Enabled = false;
                    btnRepickProf.Enabled = true;
                }
            }
            else if (txtProfChoices.Text.Contains("four"))
            {
                if (((ListBox)sender).SelectedItems.Count == 4)
                {
                    lboProfChoices.Enabled = false;
                    btnRepickProf.Enabled = true;
                }
            }

            if(isValid != false)
            {
                if (listBoxItem != null || listBoxItem != "")
                {

                    if (listBoxItem.Contains(" "))
                    {
                        listBoxItem = listBoxItem.Replace(" ", "-");
                    }
                    searchClassAndProficiencies(apiSearchPathSkills + listBoxItem);
                    // Console.WriteLine(((ListBox)sender).SelectedItem.ToString().ToLower());


                }
            }
        }

        private void btnRepickProf_Click(object sender, EventArgs e)
        {
            lboProfChoices.Enabled = true;
            btnRepickProf.Enabled = false;
            selectedProfChoices.Clear();
        }

        private void lboSubClassChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchItem = ((ListBox)sender).SelectedItem.ToString().ToLower();
            if (searchItem.Contains(" "))
            {
                searchItem = searchItem.Replace(" ", "-");
            }
            searchClassAndProficiencies(apiSearchPathSubclasses + searchItem);

        }

        private void clearBoxes()
        {
            // clear descriptions and listboxes
            lboProfChoices.Enabled = true;
            txtProfChoiceDesc.Text = "";
            txtSubClassDesc.Text = "";
            lboSubClassChoice.Items.Clear();
            profArray.Clear();
            lboProfChoices.Items.Clear();
            lboStarterEquipment.Items.Clear();
            lboEquipmentChoices.Items.Clear();
            lboProficiencies.Items.Clear();
            lboEquipmentChoiceOptions.Items.Clear();

        }

        private void btnBarbarian_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnBarbarian.Text.ToLower());
        }
        private void btnBard_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnBard.Text.ToLower());
        }

        private void btnCleric_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnCleric.Text.ToLower());
        }

        private void btnDruid_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnDruid.Text.ToLower());
        }

        private void btnFighter_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnFighter.Text.ToLower());
        }

        private void btnMonk_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnMonk.Text.ToLower());
        }

        private void btnPaladin_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnPaladin.Text.ToLower());
        }

        private void btnRanger_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnRanger.Text.ToLower());
        }

        private void btnRogue_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnRogue.Text.ToLower());
        }

        private void btnSorcerer_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnSorcerer.Text.ToLower());
        }

        private void btnWarlock_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnWarlock.Text.ToLower());
        }

        private void btnWizard_Click(object sender, EventArgs e)
        {
            clearBoxes();
            searchClassAndProficiencies(apiSearchPathClasses + btnWizard.Text.ToLower());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            this.Tag = createClassString();
            this.DialogResult = DialogResult.OK;
        }

        private string createClassString()
        {
            string finalProfArray = "";
            foreach (string trait in profArray)
            {
                finalProfArray += "|" + trait;
            }

            string finalProfChoiceArray = "";
            foreach(string profChoice in selectedProfChoices)
            {
                finalProfChoiceArray += profChoice + "|";
            }

            string finalStartingEquipmentArray = "";
            foreach(string equipment in startingEquipmentList)
            {
                finalStartingEquipmentArray += equipment + "|";
            }

            // add new symbol like ! for languages

            string formattedString = $"ClassChoice|{confirmedClass}|{txtHitDice.Text}{finalProfArray}|{profArray.Count}!" +
                                     $"{finalProfChoiceArray}{selectedProfChoices.Count}!" +
                                     $"{finalStartingEquipmentArray}{startingEquipmentList.Count}";
            Console.Write(formattedString);
            return formattedString;
        }

        private void lboEquipmentChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchItem = ((ListBox)sender).SelectedItem.ToString().ToLower();

            searchItem = searchItem.Trim();

            int indexB = searchItem.IndexOf("(b)");
            int indexC = searchItem.IndexOf("(c)");
           
            searchItem = searchItem.Insert(indexB, "|");
            if (searchItem.Contains("(c)"))
            {
                searchItem = searchItem.Insert(indexC, "|");
            }

            string[] searchItems = searchItem.Split('|');

            // searchItems[0] = searchItems[0].Remove(0, 4);            
          

            // searchItems[1] = searchItems[1].Remove(0, 4);


            if (searchItems.Length > 2)
            {
                searchItems[0] = searchItems[0].Remove(searchItems[0].Length - 2, 1);

                searchItems[1] = searchItems[1].Remove(searchItems[1].Length - 4, 4);

                searchItems[2] = searchItems[2].Trim();
                //searchItems[2] = searchItems[2].Remove(searchItems[2].Length - 4, 1);
                
            }
            else
            {
                searchItems[0] = searchItems[0].Remove(searchItems[0].Length - 4, 3);

            }
            searchItems[0] = searchItems[0].Trim();
            searchItems[1] = searchItems[1].Trim();


            //searchItems[2] = searchItems[2].Remove(0, 6);
            foreach (var item in searchItems)
            {
               
                
                lboEquipmentChoiceOptions.Items.Add(item);

            }

        }

        private void lboEquipmentChoiceOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string equipmentChoice = ((ListBox)sender).SelectedItem.ToString().ToLower();
            int indexA = equipmentChoice.IndexOf("(a)");
            int indexB = equipmentChoice.IndexOf("(b)");
            int indexC = equipmentChoice.IndexOf("(c)");

            if(equipmentChoice.Contains("(a)")) equipmentChoice = equipmentChoice.Remove(indexA, 3);
            else if(equipmentChoice.Contains("(b)")) equipmentChoice = equipmentChoice.Remove(indexB, 3);
            else if(equipmentChoice.Contains("(c)")) equipmentChoice = equipmentChoice.Remove(indexC, 3);

            equipmentChoice = equipmentChoice.Trim();
            startingEquipmentList.Add(equipmentChoice);

            Console.WriteLine(equipmentChoice);
        }
    }
}
