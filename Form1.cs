using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace LurpsTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LURPS Character Tool/Data/Core.xml"))
            {
                Core.ProfilesList = ReadXML();
                RefreshAll();
                RefreshProfiles();

                for (int i = 0; i < 8; i++)
                {
                    comboBox_CharacterRace.Items.Add(((Character.CharacterRace)i).ToString());
                }

                List<string> NewRaces = new List<string>();
                bool bIsNewRace = true;

                foreach(Profile profile in Core.ProfilesList)
                {
                    foreach(Character character in profile.CharacterList)
                    {
                        foreach(string item in comboBox_CharacterRace.Items)
                        {
                            if (character.Race == item)
                            {
                                bIsNewRace = false;
                            }
       
                        }
                        if(bIsNewRace == true)
                        {
                            NewRaces.Add(character.Race);
                        }
                        bIsNewRace = true;
                    }
                }
                comboBox_CharacterRace.Items.Add("Custom Race");
                foreach(string race in NewRaces)
                {
                    comboBox_CharacterRace.Items.Add(race);
                }
                

                for (int i = 0; i < 46; i++)
                {
                    comboBox_CharacterUntrainedSkills.Items.Add((Character.CharacterSkill)i);
                }
                for (int i = 0; i < 53; i++)
                {
                    comboBox_UntrainedFeats.Items.Add((Character.CharacterFeat)i);
                }
                for (int i = 0; i < 52; i++)
                {
                    comboBox_UntrainedFlaws.Items.Add((Character.CharacterFlaw)i);
                }

                for (int i = 0; i < 54; i++)
                {
                    comboBox_CharacterItems.Items.Add((Character.CharacterItem)i);
                }

                comboBox_CharacterRace.SelectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Race;
                comboBox_CharacterTrait2.SelectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2;
            }
            else
            {
                Core.ProfilesList = new List<Profile>();
                Profile defaultProfile = new Profile();
                defaultProfile.ProfileName = "default";
                Core.ProfilesList.Add(defaultProfile);
                defaultProfile.CharacterList.Add(new Character());

                foreach (Profile profile in Core.ProfilesList)
                {
                    listBox_Profiles.Items.Add(profile.ProfileName);
                }

                foreach (Character character in Core.ProfilesList[GetProfileIndex()].CharacterList)
                {
                    listBox_Characters.Items.Add(character.Name);
                }

                for (int i = 0; i < 8; i++)
                {
                    comboBox_CharacterRace.Items.Add(((Character.CharacterRace)i).ToString());
                }
                comboBox_CharacterRace.Items.Add("Custom Race");

                for (int i = 0; i < 46; i++)
                {
                    comboBox_CharacterUntrainedSkills.Items.Add((Character.CharacterSkill)i);
                }

                foreach (Skill skill in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList)
                {
                    listBox_CharacterSkills.Items.Add(skill.SkillName + "\t" + skill.SkillLevel);
                    comboBox_CharacterUntrainedSkills.Items.Remove(skill.SkillName);
                }
                for (int i = 0; i < 53; i++)
                {
                    comboBox_UntrainedFeats.Items.Add((Character.CharacterFeat)i);
                }
                for (int i = 0; i < 52; i++)
                {
                    comboBox_UntrainedFlaws.Items.Add((Character.CharacterFlaw)i);
                }

                for (int i = 0; i < 54; i++)
                {
                    comboBox_CharacterItems.Items.Add((Character.CharacterItem)i);
                }

                numericUpDown_Health.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterHealth;
                numericUpDown_Speed.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterSpeed;
                numericUpDown_Mana.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterMana;
                numericUpDown_HealthMax.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterHealthMax;
                numericUpDown_SpeedMax.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterSpeedMax;
                numericUpDown_ManaMax.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterManaMax;

                textBox_CharacterName.Text = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Name;

                RefreshNotesList();
            }
            
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private List<Profile> ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Profile>));
            System.IO.StreamReader file = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LURPS Character Tool/Data/Core.xml");
            List<Profile> ProfilesList = (List<Profile>)reader.Deserialize(file);
            file.Close();
            return ProfilesList;
        }

        private void RefreshProfiles()
        {
            listBox_Profiles.Items.Clear();
            foreach(Profile profile in Core.ProfilesList)
            {
                listBox_Profiles.Items.Add(profile.ProfileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Custom dlg1 = new Form_Custom("What will you call this profile?");
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (dlg1.response != null && dlg1.response != "")
                {
                    listBox_Profiles.Items.Add(dlg1.response);
                    Profile profile = new Profile();
                    profile.ProfileName = dlg1.response;
                    Core.ProfilesList.Add(profile);
                }
                dlg1.Dispose();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
            }
            RefreshCharacterList();
            RefreshAll();
        }   

        private void listBox_Profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCharacterList();
            RefreshAll();
        }

        private void button_NewCharacter_Click(object sender, EventArgs e)
        {
            Character NewCharacter = new Character();
            Core.ProfilesList[GetProfileIndex()].CharacterList.Add(NewCharacter);
            RefreshCharacterList();
            RefreshAll();
        }

        private void listBox_Characters_UpdateCharacterList()
        {
            listBox_Characters.Items.Clear();
            foreach (Character character in Core.ProfilesList[GetProfileIndex()].CharacterList)
            {
                listBox_Characters.Items.Add(character.Name);
            }
        }

        private int GetProfileIndex()
        {
            if(listBox_Profiles.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return listBox_Profiles.SelectedIndex;
            }
        }

        private int GetCharacterIndex()
        {
            if (listBox_Characters.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return listBox_Characters.SelectedIndex;
            }
        }

        private int GetSkillsIndex()
        {
            if (listBox_CharacterSkills.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return listBox_CharacterSkills.SelectedIndex;
            }
        }

        private int GetItemIndex()
                {
                    if(listBox_CharacterItems.SelectedIndex == -1)
                    {
                        return 0;
                    }
                    else
                    {
                        return listBox_CharacterItems.SelectedIndex;
                    }
                }

        private void button_DeleteCharacter_Click(object sender, EventArgs e)
        {
            if(listBox_Characters.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList.RemoveAt(GetCharacterIndex());
            }
            if(Core.ProfilesList[GetProfileIndex()].CharacterList.Count == 0)
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList.Add(new Character());
            }
            listBox_Characters_UpdateCharacterList();
            RefreshAll();
        }

        private void RefreshAll()
        {
            try
            {
                RefreshName();
                RefreshRace();
                RefreshCharacterTraitOptions();
                RefreshUntrainedFeats();
                RefreshUntrainedFlaws();
                RefreshItemsList();
                SortCharacterSkills();
                RefreshFeats();
                RefreshFlaws();
                RefreshStats();
                RefreshBonuses();
                RefreshItems();
                RefreshRacialTrait();
                RefreshNotesList();
                RefreshNotes();
            }
            catch
            {
                return;
            }
        }

        private void RefreshFeats()
        {
            listBox_Feats.Items.Clear();
            foreach (string feat in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FeatsList)
            {
                listBox_Feats.Items.Add(feat);
            }
        }

        private void RefreshFlaws()
        {
            listBox_Flaws.Items.Clear();
            foreach (string flaw in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FlawsList)
            {
                listBox_Flaws.Items.Add(flaw);
            }
        }

        private void RefreshName()
        {
            textBox_CharacterName.Text = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Name;
        }

        private void RefreshRace()
        {
            comboBox_CharacterRace.SelectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Race;
        }

        private void RefreshRacialTrait()
        {
            textBox_CharacterTrait1.Text = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait1;
            comboBox_CharacterTrait2.SelectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2;
        }

        private void RefreshBonuses()
        {
            numericUpDown_Inspiration.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Inspiration;
            numericUpDown_CombatDice.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CombatDice;
            numericUpDown_PerformanceDice.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].PerformanceDice;
            numericUpDown_CharacterPoints.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterPoints;
        }

        private void RefreshStats()
        {
            numericUpDown_Health.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterHealth;
            numericUpDown_Speed.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterSpeed;
            numericUpDown_Mana.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterMana;
            numericUpDown_HealthMax.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterHealthMax;
            numericUpDown_SpeedMax.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterSpeedMax;
            numericUpDown_ManaMax.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterManaMax;
        }

        private void RefreshItems()
        {
            listBox_CharacterItems.Items.Clear();
            foreach(Item item in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList)
            {
                listBox_CharacterItems.Items.Add(item.ItemName + "\t" + item.ItemQuantity);
            }
        }

        private void comboBox_CharacterRace_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string response;
            bool bIsThisANewRace = true;

            if(comboBox_CharacterRace.SelectedIndex > 7)
            {
                if(comboBox_CharacterRace.SelectedIndex == 8)
                {
                    response = CallBox("What do you call this race?");
                    foreach(string race in comboBox_CharacterRace.Items)
                    {
                        if(response == race)
                        {
                            bIsThisANewRace = false;
                        }
                    }
                    if(bIsThisANewRace == true)
                    {
                        comboBox_CharacterRace.Items.Add(response);
                    }
                    comboBox_CharacterRace.SelectedItem = response;
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Race = response;
                }
                else if(comboBox_CharacterRace.SelectedItem.ToString() != Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Race)
                {
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Race = comboBox_CharacterRace.Text;
                    response = CallBox("What is the first racial trait?");
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait1 = response;
                    textBox_CharacterTrait1.Text = response;

                    response = CallBox("What is the second racial trait?");
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2 = response;
                    comboBox_CharacterTrait2.Items.Add(response);
                    comboBox_CharacterTrait2.SelectedItem = response;
                }
            }
            else
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Race = comboBox_CharacterRace.Text;
            }
            RefreshCharacterTraitOptions();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait1 = textBox_CharacterTrait1.Text;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_CharacterUntrainedSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            Skill selectedSkill = new Skill();
            selectedSkill.SkillName = (Character.CharacterSkill)comboBox_CharacterUntrainedSkills.SelectedItem;
            selectedSkill.SkillLevel = 1;
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Add(selectedSkill);
            listBox_CharacterSkills.Items.Add(selectedSkill.SkillName + "\t" + selectedSkill.SkillLevel);
            comboBox_CharacterUntrainedSkills.Items.Remove(comboBox_CharacterUntrainedSkills.SelectedItem);
            if (Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Count == 1)
            {
                Skill defaultSkill = new Skill();
                defaultSkill.SkillLevel = 2;
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Add(defaultSkill);
                listBox_CharacterSkills.Items.Add(defaultSkill.SkillName + "\t" + defaultSkill.SkillLevel);
            }
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
            string characterTrait = comboBox_CharacterTrait2.Text;
            RefreshCharacterTraitOptions();
            comboBox_CharacterTrait2.SelectedItem = characterTrait;
        }

        private void listBox_CharacterSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the skills numeric value button to match the selected skill
            Core.bIsSkillLevelAccessable = false;
            numericUpDown_CharacterSkillValue.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()].SkillLevel;
            Core.bIsSkillLevelAccessable = true;
            Core.skillSelectionIndex = listBox_CharacterSkills.SelectedIndex;
        }

        private void button_ResetSkills_Click(object sender, EventArgs e)
        {
            //Clear the skills from the slelected profile and add back the default skills
            comboBox_CharacterUntrainedSkills.Items.Clear();
            for (int i = 0; i < 46; i++)
            {
                comboBox_CharacterUntrainedSkills.Items.Add((Character.CharacterSkill)i);
            }

            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Clear();
            Skill defaultSkill = new Skill();
            defaultSkill.SkillName = Character.CharacterSkill.UnarmedAndGrappling;
            defaultSkill.SkillLevel = 2;
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Add(defaultSkill);

            listBox_CharacterSkills.Items.Clear();

            foreach (Skill skill in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList)
            {
                listBox_CharacterSkills.Items.Add(skill.SkillName + "\t" + skill.SkillLevel);
            }
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
            string characterTrait = comboBox_CharacterTrait2.Text;
            RefreshCharacterTraitOptions();
            comboBox_CharacterTrait2.SelectedItem = characterTrait;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Count == 0)
            {
                return;
            }

            if(Core.bIsSkillLevelAccessable == true)
            {
                Character.CharacterSkill skillName = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()].SkillName;
                int skillLevel = (int)numericUpDown_CharacterSkillValue.Value;
                Skill selectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()];

                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()].SkillLevel = (int)numericUpDown_CharacterSkillValue.Value;
                if(selectedItem.SkillName == Character.CharacterSkill.UnarmedAndGrappling && Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()].SkillLevel < 2)
                {
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()].SkillLevel = 2;
                }
                if (Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList[GetSkillsIndex()].SkillLevel < 1)
                {
                    RemoveCharacterSkill(selectedItem);
                    SortCharacterSkills();
                    listBox_CharacterSkills.SetSelected(0, true);
                }
                else
                {
                    SortCharacterSkills();
                    listBox_CharacterSkills.SetSelected(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.IndexOf(selectedItem), true);
                }
                CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
            }
        }

        private void SortCharacterSkills()
        {
            listBox_CharacterSkills.Items.Clear();
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Sort();
            foreach (Skill skill in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList)
            {
                listBox_CharacterSkills.Items.Add(skill.SkillName + "\t" + skill.SkillLevel);
            }
        }

        private void SortUntrainedSkills()
        {
            List<object> RemoveList = new List<object>();

            comboBox_CharacterUntrainedSkills.Items.Clear();
            for (int i = 0; i < 46; i++)
            {
                comboBox_CharacterUntrainedSkills.Items.Add((Character.CharacterSkill)i);
            }
            comboBox_CharacterUntrainedSkills.Items.Remove(Character.CharacterSkill.UnarmedAndGrappling);
            foreach(Skill skill in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList)
            {
                foreach(object skillText in comboBox_CharacterUntrainedSkills.Items)
                {
                    if (skillText.ToString() == skill.SkillName.ToString())
                    {
                        RemoveList.Add(skillText);
                    }
                }
            }
            foreach(object removeSkill in RemoveList)
            {
                comboBox_CharacterUntrainedSkills.Items.Remove(removeSkill);
            }

        }

        private void RemoveCharacterSkill(Skill skill)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList.Remove(skill);
            SortCharacterSkills();
            SortUntrainedSkills();
            listBox_CharacterSkills.SetSelected(0, true);

        }

        private void RefreshCharacterList()
        {
            listBox_Characters.Items.Clear();
            foreach (Character character in Core.ProfilesList[GetProfileIndex()].CharacterList)
            {
                listBox_Characters.Items.Add(character.Name);
            }
        }

        private void RefreshNotesList()
        {
            listBox_Notes.Items.Clear();
            foreach(Note note in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList)
            {
                listBox_Notes.Items.Add(note.NoteName);
            }
        }

        private void RefreshCharacterTraitOptions()
        {
            comboBox_CharacterTrait2.Items.Clear();
            switch (comboBox_CharacterRace.SelectedIndex)
            {
                case -1:
                    {
                        textBox_CharacterTrait1.Text = "";
                        break;
                    }
                case 0:
                    {
                        textBox_CharacterTrait1.Text = "Press On";
                        foreach(Skill skill in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList)
                        {
                            comboBox_CharacterTrait2.Items.Add("Specialist (" + skill.SkillName + ")");
                        }
                        comboBox_CharacterTrait2.Items.Add("Generalist");
                        break;
                    }
                case 1:
                    {
                        textBox_CharacterTrait1.Text = "Cursed Heritage";
                        comboBox_CharacterTrait2.Items.Add("Claws");
                        comboBox_CharacterTrait2.Items.Add("Frigid North");
                        break;
                    }
                case 2:
                    {
                        textBox_CharacterTrait1.Text = "Swift";
                        comboBox_CharacterTrait2.Items.Add("Ambush");
                        comboBox_CharacterTrait2.Items.Add("Unnatural Grace");
                        break;
                    }
                case 3:
                    {
                        textBox_CharacterTrait1.Text = "Stubborn";
                        comboBox_CharacterTrait2.Items.Add("Stalwart");
                        comboBox_CharacterTrait2.Items.Add("Strong Grip");
                        break;
                    }
                case 4:
                    {
                        textBox_CharacterTrait1.Text = "Discipline";
                        comboBox_CharacterTrait2.Items.Add("Battle Trance");
                        foreach (Skill skill in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].SkillsList)
                        {
                            comboBox_CharacterTrait2.Items.Add("Specialist (" + skill.SkillName + ")");
                        }
                        break;
                    }
                case 5:
                    {
                        textBox_CharacterTrait1.Text = "Cave Adaptation";
                        comboBox_CharacterTrait2.Items.Add("Impatient");
                        comboBox_CharacterTrait2.Items.Add("Me First");
                        break;
                    }
                case 6:
                    {
                        textBox_CharacterTrait1.Text = "Gift of the Gab";
                        comboBox_CharacterTrait2.Items.Add("Agile");
                        comboBox_CharacterTrait2.Items.Add("Sniper Shot");
                        break;
                    }
                case 7:
                    {
                        textBox_CharacterTrait1.Text = "Survivalist";
                        comboBox_CharacterTrait2.Items.Add("Alert");
                        comboBox_CharacterTrait2.Items.Add("Coloured Scales (Fire)");
                        comboBox_CharacterTrait2.Items.Add("Coloured Scales (Ice)");
                        comboBox_CharacterTrait2.Items.Add("Coloured Scales (Lightning)");
                        comboBox_CharacterTrait2.Items.Add("Coloured Scales (Poison & Venom)");
                        break;
                    }
            }
            if(comboBox_CharacterRace.SelectedIndex > 8)
            {
                if (Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait1 != null)
                {
                    textBox_CharacterTrait1.Text = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait1;
                }
                if (Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2 != null)
                {
                    comboBox_CharacterTrait2.Items.Add(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2);
                    comboBox_CharacterTrait2.SelectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2;
                }
            }
        }

        private void textBox_CharacterName_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox_Characters.SelectedIndex;
            DeselectSkillsList();
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Name = textBox_CharacterName.Text;
            RefreshCharacterList();
            listBox_Characters.SelectedIndex = selectedIndex;
        }

        private void DeselectSkillsList()
        {
            if (listBox_CharacterSkills.SelectedIndex != -1)
            {
                listBox_CharacterSkills.SetSelected(listBox_CharacterSkills.SelectedIndex, false);
            }
        }

        private void comboBox_UntrainedFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FeatsList.Add(comboBox_UntrainedFeats.SelectedItem.ToString());
            comboBox_UntrainedFeats.Items.Remove(comboBox_UntrainedFeats.SelectedItem);
            listBox_Feats.Items.Clear();
            foreach(string feat in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FeatsList)
            {
                listBox_Feats.Items.Add(feat);
            }
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
            //if(listBox_Feats.SelectedIndex != -1) listBox_Feats.SetSelected(listBox_Feats.SelectedIndex, false);
        }

        private void listBox_Feats_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RefreshUntrainedFeats()
        {
            comboBox_UntrainedFeats.Items.Clear();
            for (int i = 0; i < 53; i++)
            {
                comboBox_UntrainedFeats.Items.Add((Character.CharacterFeat)i);
            }
            try
            {
                foreach (string feat in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FeatsList)
                {
                    comboBox_UntrainedFeats.Items.Remove(feat);
                }
            }
            catch
            {
                return;
            }
        }

        private void RemoveCharacterFeat()
        {
            if (listBox_Feats.SelectedIndex != -1)
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FeatsList.Remove(listBox_Feats.SelectedItem.ToString());
                listBox_Feats.Items.Remove(listBox_Feats.SelectedItem);

            }
            RefreshUntrainedFeats();
        }

        private void button_RemoveCharacterFeat_Click(object sender, EventArgs e)
        {
            RemoveCharacterFeat();
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void comboBox_UntrainedFlaws_SelectedIndexChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FlawsList.Add(comboBox_UntrainedFlaws.SelectedItem.ToString());
            comboBox_UntrainedFlaws.Items.Remove(comboBox_UntrainedFlaws.SelectedItem);
            listBox_Flaws.Items.Clear();
            foreach (string flaw in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FlawsList)
            {
                listBox_Flaws.Items.Add(flaw);
            }
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void listBox_Flaws_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_RemoveCharacterFlaw_Click(object sender, EventArgs e)
        {
            RemoveCharacterFlaw();
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void RemoveCharacterFlaw()
        {
            if (listBox_Flaws.SelectedIndex != -1)
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FlawsList.Remove(listBox_Flaws.SelectedItem.ToString());
                listBox_Flaws.Items.Remove(listBox_Flaws.SelectedItem);

            }
            RefreshUntrainedFlaws();
        }

        private void RefreshUntrainedFlaws()
        {
            comboBox_UntrainedFlaws.Items.Clear();
            for (int i = 0; i < 52; i++)
            {
                comboBox_UntrainedFlaws.Items.Add((Character.CharacterFlaw)i);
            }
            try
            {
                foreach (string flaw in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FlawsList)
                {
                    comboBox_UntrainedFlaws.Items.Remove(flaw);
                }
            }
            catch
            {
                return;
            }

        }

        private void RefreshItemsList()
        {
            comboBox_CharacterItems.Items.Clear();
            for (int i = 0; i < 54; i++)
            {
                comboBox_CharacterItems.Items.Add((Character.CharacterItem)i);
            }
            try
            {
                foreach (Item item in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList)
                {
                    comboBox_CharacterItems.Items.Remove(item.ItemName);
                }
            }
            catch
            {
                return;
            }
        }

        private void button_NewCharacterFeat_Click(object sender, EventArgs e)
        {
            Form_Custom dlg1 = new Form_Custom("What is this feat called?");
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (dlg1.response != null && dlg1.response != "")
                {
                    listBox_Feats.Items.Add(dlg1.response);
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FeatsList.Add(dlg1.response);
                }
                dlg1.Dispose();
                CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
            }
        }

        private void button_NewCharacterFlaw_Click(object sender, EventArgs e)
        {
            Form_Custom dlg1 = new Form_Custom("What is this flaw called?");
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (dlg1.response != null && dlg1.response != "")
                {
                    listBox_Flaws.Items.Add(dlg1.response);
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].FlawsList.Add(dlg1.response);
                }
                dlg1.Dispose();
                CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
            }
        }

        private void CalculateCharacterValue(Character character)
        {
            if(Core.bIsRealisticModeActivated == false)
            {
                int characterValue = 0;
                bool bIsTrainedInCombat = false;
                int unarmedSkill = 2;
                foreach (Skill skill in character.SkillsList)
                {
                    if (skill.SkillLevel > 1 && bIsTrainedInCombat == false && (skill.SkillName == Character.CharacterSkill.SlashingWeapons || skill.SkillName == Character.CharacterSkill.CrushingWeapons || skill.SkillName == Character.CharacterSkill.PiercingWeapons || skill.SkillName == Character.CharacterSkill.GunpowderAndGrenades || skill.SkillName == Character.CharacterSkill.BowsAndCrossbows))
                    {
                        characterValue += skill.SkillLevel - 2;
                        bIsTrainedInCombat = true;
                    }
                    else if (skill.SkillName == Character.CharacterSkill.UnarmedAndGrappling)
                    {
                        unarmedSkill = skill.SkillLevel;
                        characterValue += skill.SkillLevel - 2;
                    }
                    else
                    {
                        characterValue += skill.SkillLevel;
                    }

                }
                if (bIsTrainedInCombat == false && unarmedSkill >= 3)
                {
                    if (unarmedSkill == 3)
                    {
                        characterValue -= 1;
                    }
                    else
                    {
                        characterValue -= 2;
                    }
                }

                foreach (string feat in character.FeatsList)
                {
                    characterValue += 2;
                }

                if (character.FeatsList.Count > 0 && character.FlawsList.Count > 1)
                {
                    characterValue -= 2;
                }

                if (character.FeatsList.Count > 1 && character.FlawsList.Count > 3)
                {
                    characterValue -= 2;
                }

                characterValue += (character.CharacterHealthMax / 5) - 2;
                characterValue += (character.CharacterSpeedMax / 5) - 2;
                characterValue += (character.CharacterManaMax / 5) - 2;

                label_CharacterPointsValue.Text = characterValue.ToString();
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterValue = characterValue;
            }
            else
            {
                int characterValue = 0;
                bool bIsTrainedInCombat = false;
                int unarmedSkill = 2;
                foreach (Skill skill in character.SkillsList)
                {
                    if (skill.SkillLevel > 1 && bIsTrainedInCombat == false && (skill.SkillName == Character.CharacterSkill.SlashingWeapons || skill.SkillName == Character.CharacterSkill.CrushingWeapons || skill.SkillName == Character.CharacterSkill.PiercingWeapons || skill.SkillName == Character.CharacterSkill.GunpowderAndGrenades || skill.SkillName == Character.CharacterSkill.BowsAndCrossbows))
                    {
                        characterValue += skill.SkillLevel - 2;
                        if(skill.SkillLevel > 3)
                        {
                            characterValue += skill.SkillLevel - 3;
                        }
                        if (skill.SkillLevel > 6)
                        {
                            characterValue += skill.SkillLevel - 6;
                        }
                        bIsTrainedInCombat = true;
                    }
                    else if (skill.SkillName == Character.CharacterSkill.UnarmedAndGrappling)
                    {
                        unarmedSkill = skill.SkillLevel;
                        characterValue += skill.SkillLevel - 2;
                        if (skill.SkillLevel > 3)
                        {
                            characterValue += skill.SkillLevel - 3;
                        }
                        if (skill.SkillLevel > 6)
                        {
                            characterValue += skill.SkillLevel - 6;
                        }
                    }
                    else
                    {
                        characterValue += skill.SkillLevel;
                        if (skill.SkillLevel > 3)
                        {
                            characterValue += skill.SkillLevel - 3;
                        }
                        if (skill.SkillLevel > 6)
                        {
                            characterValue += skill.SkillLevel - 6;
                        }
                    }

                }
                if (bIsTrainedInCombat == false && unarmedSkill >= 3)
                {
                    if (unarmedSkill == 3)
                    {
                        characterValue -= 1;
                    }
                    else
                    {
                        characterValue -= 3; //rank 4 of unarmed costs 2 cp in realistic mode, so taking four free ranks means the player is refunded for 5 points total.
                    }
                }

                foreach (string feat in character.FeatsList)
                {
                    characterValue += 2;
                }

                if (character.FeatsList.Count > 0 && character.FlawsList.Count > 1)
                {
                    characterValue -= 2;
                }

                if (character.FeatsList.Count > 1 && character.FlawsList.Count > 3)
                {
                    characterValue -= 2;
                }

                characterValue += (character.CharacterHealthMax / 5) - 2;
                characterValue += (character.CharacterSpeedMax / 5) - 2;
                characterValue += (character.CharacterManaMax / 5) - 2;

                label_CharacterPointsValue.Text = characterValue.ToString();
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterValue = characterValue;

            }
        }

        private void numericUpDown_HealthMax_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterHealthMax = (int)numericUpDown_HealthMax.Value;
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void numericUpDown_SpeedMax_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterSpeedMax = (int)numericUpDown_SpeedMax.Value;
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void numericUpDown_ManaMax_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterManaMax = (int)numericUpDown_ManaMax.Value;
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Core.bIsRealisticModeActivated = true;
            }
            else
            {
                Core.bIsRealisticModeActivated = false;
            }
            CalculateCharacterValue(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()]);
        }

        private void comboBox_CharacterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.Potion)
            {
                Form_Custom dlg1 = new Form_Custom("What is this potion called?");
                DialogResult dialogResult = dlg1.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    if (dlg1.response != null && dlg1.response != "")
                    {
                        listBox_CharacterItems.Items.Add(dlg1.response + "\t" + 1);
                        Item item = new Item();
                        item.ItemName = dlg1.response;
                        item.ItemQuantity = 1;
                        Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.Add(item);
                    }
                    dlg1.Dispose();
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    dlg1.Dispose();
                }
            }
            else if ((Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.Book)
            {
                Form_Custom dlg1 = new Form_Custom("What is this book called?");
                DialogResult dialogResult = dlg1.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    if (dlg1.response != null && dlg1.response != "")
                    {
                        listBox_CharacterItems.Items.Add(dlg1.response + "\t" + 1);
                        Item item = new Item();
                        item.ItemName = dlg1.response;
                        item.ItemQuantity = 1;
                        Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.Add(item);
                    }
                    dlg1.Dispose();
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    dlg1.Dispose();
                }
            }
            else if ((Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.AlchemySet || 
                (Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.MedicalKit ||
                (Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.RepairKit ||
                (Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.LockpickSet ||
                (Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.HuntersKit ||
                (Character.CharacterItem)comboBox_CharacterItems.SelectedItem == Character.CharacterItem.GamblersKit)
            {
                Item item = new Item();
                item.ItemName = comboBox_CharacterItems.SelectedItem.ToString();
                item.ItemQuantity = 10;
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.Add(item);
                listBox_CharacterItems.Items.Add(comboBox_CharacterItems.SelectedItem.ToString() + "\t" + 10);
                comboBox_CharacterItems.Items.Remove(comboBox_CharacterItems.SelectedItem);
            }
            else
            {
                Item item = new Item();
                item.ItemName = comboBox_CharacterItems.SelectedItem.ToString();
                item.ItemQuantity = 1;
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.Add(item);
                listBox_CharacterItems.Items.Add(comboBox_CharacterItems.SelectedItem.ToString() + "\t" + 1);
                comboBox_CharacterItems.Items.Remove(comboBox_CharacterItems.SelectedItem);
            }
        }

        private void button_DeleteItem_Click(object sender, EventArgs e)
        {
            if(listBox_CharacterItems.SelectedIndex != -1)
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.RemoveAt(GetItemIndex());
                listBox_CharacterItems.Items.RemoveAt(GetItemIndex());
                RefreshItemsList();
            }
        }

        private void numericUpDown_ItemQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            if (Core.bIsItemQuantityAccessable == true)
            {
                try
                {
                    string itemName = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList[GetItemIndex()].ItemName;
                    int itemQuantity = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList[GetItemIndex()].ItemQuantity;
                    Item selectedItem = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList[GetItemIndex()];

                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList[GetItemIndex()].ItemQuantity = (int)numericUpDown_ItemQuantity.Value;
                    listBox_CharacterItems.Items.Clear();
                    foreach (Item item in Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList)
                    {
                        listBox_CharacterItems.Items.Add(item.ItemName + "\t" + item.ItemQuantity);
                    }
                    listBox_CharacterItems.SetSelected(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.IndexOf(selectedItem), true);
                }
                catch
                {
                    return;
                }
            }
        }

        private void listBox_CharacterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Core.bIsItemQuantityAccessable = false;
            try
            {
                numericUpDown_ItemQuantity.Value = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList[GetItemIndex()].ItemQuantity;
            }
            catch
            {
                numericUpDown_ItemQuantity.Value = 0;
            }
            Core.bIsItemQuantityAccessable = true;
            Core.skillSelectionIndex = listBox_CharacterSkills.SelectedIndex;
        }

        private void button_CustomItem_Click(object sender, EventArgs e)
        {
            Form_Custom dlg1 = new Form_Custom("What is this item called?");
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (dlg1.response != null && dlg1.response != "")
                {
                    listBox_CharacterItems.Items.Add(dlg1.response + "\t" + 1);
                    Item item = new Item();
                    item.ItemName = dlg1.response;
                    item.ItemQuantity = 1;
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.Add(item);
                }
                dlg1.Dispose();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
            }
        }

        private void button_MoveUp_Click(object sender, EventArgs e)
        {
            if(listBox_CharacterItems.SelectedIndex != -1 && listBox_CharacterItems.SelectedIndex != 0)
            {
                string substitutionPlaceHolder = listBox_CharacterItems.Items[listBox_CharacterItems.SelectedIndex - 1].ToString();
                Item itemPlaceHolder = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList[listBox_CharacterItems.SelectedIndex - 1];
                int selectedIndex = listBox_CharacterItems.SelectedIndex;
                listBox_CharacterItems.Items.RemoveAt(selectedIndex - 1);
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.RemoveAt(selectedIndex - 1);
                listBox_CharacterItems.Items.Insert(selectedIndex, substitutionPlaceHolder);
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].ItemsList.Insert(selectedIndex, itemPlaceHolder);
            }
        }

        private void numericUpDown_Inspiration_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].Inspiration = (int)numericUpDown_Inspiration.Value;
        }

        private void numericUpDown_CombatDice_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CombatDice = (int)numericUpDown_CombatDice.Value;
        }

        private void numericUpDown_PerformanceDice_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].PerformanceDice = (int)numericUpDown_PerformanceDice.Value;
        }

        private void numericUpDown_CharacterPoints_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterPoints = (int)numericUpDown_CharacterPoints.Value;
        }

        private void listBox_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox_Characters.SelectedIndex;
            RefreshAll();
            listBox_Characters.SelectedIndex = selectedIndex;
        }

        private void comboBox_CharacterTrait2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].RacialTrait2 = comboBox_CharacterTrait2.Text;
        }

        private void button_DeleteProfile_Click(object sender, EventArgs e)
        {
            Core.ProfilesList.RemoveAt(listBox_Profiles.SelectedIndex);
            //listBox_Profiles.SelectedIndex = 0;

            if(Core.ProfilesList.Count == 0)
            {
                Profile profile = new Profile();
                profile.ProfileName = "default";
                Core.ProfilesList.Add(profile);
            }

            RefreshProfiles();
            RefreshCharacterList();
            RefreshAll();
        }

        private void button_NewNote_Click(object sender, EventArgs e)
        {
            Form_Custom dlg1 = new Form_Custom("What will you call this note?");
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (dlg1.response != null && dlg1.response != "")
                {
                    listBox_Notes.Items.Insert(0, dlg1.response);
                    Note note = new Note();
                    note.NoteName = dlg1.response;
                    note.NoteText = "";
                    Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.Insert(0, note);
                }
                dlg1.Dispose();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
            }
            RefreshNotesList();
        }

        private void button_DeleteNote_Click(object sender, EventArgs e)
        {
            if (Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.Count > 0)
            {
                richTextBox_CharacterNotes.Text = "";
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.RemoveAt(GetNotesIndex());
                RefreshNotes();
                RefreshNotesList();
            }
        }

        private void RefreshNotes()
        {
            if (Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.Count > 0)
            {
                richTextBox_CharacterNotes.Text = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList[GetNotesIndex()].NoteText;
            }
            else
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.Add(new Note());
            }
        }

        private int GetNotesIndex()
        {
            if(listBox_Notes.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return listBox_Notes.SelectedIndex;
            }
        }

        private void listBox_Notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox_CharacterNotes.Text = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList[GetNotesIndex()].NoteText;
        }

        private void richTextBox_CharacterNotes_TextChanged(object sender, EventArgs e)
        {
            if(Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.Count == 0)
            {
                Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList.Add(new Note());
                RefreshNotesList();
            }
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].NotesList[GetNotesIndex()].NoteText = richTextBox_CharacterNotes.Text;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LURPS Character Tool/Data"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LURPS Character Tool/Data");
            }
            XmlSerializer writer = new XmlSerializer(typeof(List<Profile>));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LURPS Character Tool/Data/Core.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, Core.ProfilesList);
            file.Close();
        }

        private void numericUpDown_Health_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterHealth = (int)numericUpDown_Health.Value;
        }

        private void numericUpDown_Speed_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterSpeed = (int)numericUpDown_Speed.Value;
        }

        private void numericUpDown_Mana_ValueChanged(object sender, EventArgs e)
        {
            Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()].CharacterMana = (int)numericUpDown_Mana.Value;
        }

        private void button_CopyTo_Click(object sender, EventArgs e)
        {
            Character CopyCharacter = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()];
            Form_CopyTo dlg1 = new Form_CopyTo();
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (dlg1.ProfileSelection != -1)
                {
                    Core.ProfilesList[dlg1.ProfileSelection].CharacterList.Add(CopyCharacter);
                }
                dlg1.Dispose();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            Character character = Core.ProfilesList[GetProfileIndex()].CharacterList[GetCharacterIndex()];
            Note note = new Note();
            note.NoteName = $"{character.Name}_Export";
            CalculateCharacterValue(character);
            string about = "No Description";
            foreach(Note characterNote in character.NotesList)
            {
                if(characterNote.NoteName == "About")
                {
                    if(characterNote.NoteText != "Write a backstory for your character in this box.")
                    {
                        about = characterNote.NoteText;
                    }
                    break;
                }
            }
            string characterSummary =
                $"{character.Name}\n" +
                $"{character.Race}\n\n" +
                $"{about}\n\n" +
                $"{textBox_CharacterTrait1.Text}\n" +
                $"{character.RacialTrait2}\n\n" +
                $"Inspiration: {character.Inspiration}\n" +
                $"Combat Dice: {character.CombatDice}\n" +
                $"Performance Dice: {character.PerformanceDice}\n" +
                $"Character Points: {character.CharacterPoints}\n" +
                $"Character Value: {character.CharacterValue}\n\n" +
                $"HTP: {character.CharacterHealth}/{character.CharacterHealthMax}\n" +
                $"SPD: {character.CharacterSpeed}/{character.CharacterSpeedMax}\n" +
                $"MAN: {character.CharacterMana}/{character.CharacterManaMax}\n\n";
                
            foreach(Skill skill in character.SkillsList)
            {
                characterSummary += $"{skill.SkillName}\t{skill.SkillLevel}\n";
            }
            characterSummary += "\n";
            foreach (string feat in character.FeatsList)
            {
                characterSummary += $"{feat}\n";
            }
            characterSummary += "\n";
            foreach (string flaw in character.FlawsList)
            {
                characterSummary += $"{flaw}\n";
            }
            characterSummary += "\n";
            foreach (Item item in character.ItemsList)
            {
                if(item.ItemQuantity > 1)
                {
                    characterSummary += $"{item.ItemName}\tx{item.ItemQuantity}\n";
                }
                else
                {
                    characterSummary += $"{item.ItemName}\n";
                }
            }
            note.NoteText = characterSummary;
            character.NotesList.Insert(0, note);
            RefreshNotesList();
        }

        private string CallBox(string text)
        {
            Form_Custom dlg1 = new Form_Custom(text);
            DialogResult dialogResult = dlg1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                dlg1.Dispose();
                return dlg1.response;
            }
            if (dialogResult == DialogResult.Cancel)
            {
                dlg1.Dispose();
                return "";
            }
            return "";
        }
    }
}
