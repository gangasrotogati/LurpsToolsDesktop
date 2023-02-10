
namespace LurpsTools
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonNewProfile = new System.Windows.Forms.Button();
            this.listBox_Profiles = new System.Windows.Forms.ListBox();
            this.listBox_Characters = new System.Windows.Forms.ListBox();
            this.button_NewCharacter = new System.Windows.Forms.Button();
            this.button_DeleteCharacter = new System.Windows.Forms.Button();
            this.textBox_CharacterName = new System.Windows.Forms.TextBox();
            this.comboBox_CharacterRace = new System.Windows.Forms.ComboBox();
            this.textBox_CharacterTrait1 = new System.Windows.Forms.TextBox();
            this.comboBox_CharacterTrait2 = new System.Windows.Forms.ComboBox();
            this.listBox_CharacterSkills = new System.Windows.Forms.ListBox();
            this.comboBox_CharacterUntrainedSkills = new System.Windows.Forms.ComboBox();
            this.numericUpDown_CharacterSkillValue = new System.Windows.Forms.NumericUpDown();
            this.button_ResetSkills = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Inspiration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CombatDice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CharacterPoints = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Mana = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Speed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Health = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_PerformanceDice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_ManaMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SpeedMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_HealthMax = new System.Windows.Forms.NumericUpDown();
            this.listBox_Feats = new System.Windows.Forms.ListBox();
            this.listBox_Flaws = new System.Windows.Forms.ListBox();
            this.comboBox_UntrainedFeats = new System.Windows.Forms.ComboBox();
            this.comboBox_UntrainedFlaws = new System.Windows.Forms.ComboBox();
            this.button_NewCharacterFeat = new System.Windows.Forms.Button();
            this.button_RemoveCharacterFeat = new System.Windows.Forms.Button();
            this.button_NewCharacterFlaw = new System.Windows.Forms.Button();
            this.button_RemoveCharacterFlaw = new System.Windows.Forms.Button();
            this.label_CharacterPoints = new System.Windows.Forms.Label();
            this.label_CharacterPointsValue = new System.Windows.Forms.Label();
            this.listBox_CharacterItems = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_Realistic = new System.Windows.Forms.Label();
            this.numericUpDown_ItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.button_DeleteItem = new System.Windows.Forms.Button();
            this.comboBox_CharacterItems = new System.Windows.Forms.ComboBox();
            this.listBox_Notes = new System.Windows.Forms.ListBox();
            this.button_NewNote = new System.Windows.Forms.Button();
            this.button_DeleteNote = new System.Windows.Forms.Button();
            this.richTextBox_CharacterNotes = new System.Windows.Forms.RichTextBox();
            this.button_CustomItem = new System.Windows.Forms.Button();
            this.button_MoveUp = new System.Windows.Forms.Button();
            this.button_CopyTo = new System.Windows.Forms.Button();
            this.button_DeleteProfile = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CharacterSkillValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Inspiration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CombatDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CharacterPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PerformanceDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ManaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HealthMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewProfile
            // 
            this.buttonNewProfile.Location = new System.Drawing.Point(14, 594);
            this.buttonNewProfile.Name = "buttonNewProfile";
            this.buttonNewProfile.Size = new System.Drawing.Size(76, 23);
            this.buttonNewProfile.TabIndex = 1;
            this.buttonNewProfile.Text = "New Profile";
            this.buttonNewProfile.UseVisualStyleBackColor = true;
            this.buttonNewProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_Profiles
            // 
            this.listBox_Profiles.FormattingEnabled = true;
            this.listBox_Profiles.ItemHeight = 15;
            this.listBox_Profiles.Location = new System.Drawing.Point(15, 479);
            this.listBox_Profiles.Name = "listBox_Profiles";
            this.listBox_Profiles.Size = new System.Drawing.Size(221, 109);
            this.listBox_Profiles.TabIndex = 3;
            this.listBox_Profiles.SelectedIndexChanged += new System.EventHandler(this.listBox_Profiles_SelectedIndexChanged);
            // 
            // listBox_Characters
            // 
            this.listBox_Characters.FormattingEnabled = true;
            this.listBox_Characters.ItemHeight = 15;
            this.listBox_Characters.Location = new System.Drawing.Point(251, 479);
            this.listBox_Characters.Name = "listBox_Characters";
            this.listBox_Characters.Size = new System.Drawing.Size(221, 109);
            this.listBox_Characters.TabIndex = 4;
            this.listBox_Characters.SelectedIndexChanged += new System.EventHandler(this.listBox_Characters_SelectedIndexChanged);
            // 
            // button_NewCharacter
            // 
            this.button_NewCharacter.Location = new System.Drawing.Point(251, 594);
            this.button_NewCharacter.Name = "button_NewCharacter";
            this.button_NewCharacter.Size = new System.Drawing.Size(71, 23);
            this.button_NewCharacter.TabIndex = 5;
            this.button_NewCharacter.Text = "New Character";
            this.button_NewCharacter.UseVisualStyleBackColor = true;
            this.button_NewCharacter.Click += new System.EventHandler(this.button_NewCharacter_Click);
            // 
            // button_DeleteCharacter
            // 
            this.button_DeleteCharacter.Location = new System.Drawing.Point(401, 594);
            this.button_DeleteCharacter.Name = "button_DeleteCharacter";
            this.button_DeleteCharacter.Size = new System.Drawing.Size(71, 23);
            this.button_DeleteCharacter.TabIndex = 6;
            this.button_DeleteCharacter.Text = "Delete Character";
            this.button_DeleteCharacter.UseVisualStyleBackColor = true;
            this.button_DeleteCharacter.Click += new System.EventHandler(this.button_DeleteCharacter_Click);
            // 
            // textBox_CharacterName
            // 
            this.textBox_CharacterName.Location = new System.Drawing.Point(12, 12);
            this.textBox_CharacterName.Name = "textBox_CharacterName";
            this.textBox_CharacterName.Size = new System.Drawing.Size(253, 23);
            this.textBox_CharacterName.TabIndex = 7;
            this.textBox_CharacterName.Text = "unnamed";
            this.textBox_CharacterName.TextChanged += new System.EventHandler(this.textBox_CharacterName_TextChanged);
            // 
            // comboBox_CharacterRace
            // 
            this.comboBox_CharacterRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CharacterRace.FormattingEnabled = true;
            this.comboBox_CharacterRace.Location = new System.Drawing.Point(12, 41);
            this.comboBox_CharacterRace.Name = "comboBox_CharacterRace";
            this.comboBox_CharacterRace.Size = new System.Drawing.Size(253, 23);
            this.comboBox_CharacterRace.TabIndex = 8;
            this.comboBox_CharacterRace.SelectedIndexChanged += new System.EventHandler(this.comboBox_CharacterRace_SelectedIndexChanged_1);
            // 
            // textBox_CharacterTrait1
            // 
            this.textBox_CharacterTrait1.Enabled = false;
            this.textBox_CharacterTrait1.Location = new System.Drawing.Point(12, 70);
            this.textBox_CharacterTrait1.Name = "textBox_CharacterTrait1";
            this.textBox_CharacterTrait1.Size = new System.Drawing.Size(253, 23);
            this.textBox_CharacterTrait1.TabIndex = 9;
            this.textBox_CharacterTrait1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox_CharacterTrait2
            // 
            this.comboBox_CharacterTrait2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CharacterTrait2.FormattingEnabled = true;
            this.comboBox_CharacterTrait2.Location = new System.Drawing.Point(13, 100);
            this.comboBox_CharacterTrait2.Name = "comboBox_CharacterTrait2";
            this.comboBox_CharacterTrait2.Size = new System.Drawing.Size(252, 23);
            this.comboBox_CharacterTrait2.TabIndex = 10;
            this.comboBox_CharacterTrait2.SelectedIndexChanged += new System.EventHandler(this.comboBox_CharacterTrait2_SelectedIndexChanged);
            // 
            // listBox_CharacterSkills
            // 
            this.listBox_CharacterSkills.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_CharacterSkills.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_CharacterSkills.FormattingEnabled = true;
            this.listBox_CharacterSkills.ItemHeight = 15;
            this.listBox_CharacterSkills.Location = new System.Drawing.Point(13, 129);
            this.listBox_CharacterSkills.Name = "listBox_CharacterSkills";
            this.listBox_CharacterSkills.Size = new System.Drawing.Size(253, 124);
            this.listBox_CharacterSkills.TabIndex = 11;
            this.listBox_CharacterSkills.SelectedIndexChanged += new System.EventHandler(this.listBox_CharacterSkills_SelectedIndexChanged);
            // 
            // comboBox_CharacterUntrainedSkills
            // 
            this.comboBox_CharacterUntrainedSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CharacterUntrainedSkills.FormattingEnabled = true;
            this.comboBox_CharacterUntrainedSkills.Location = new System.Drawing.Point(14, 289);
            this.comboBox_CharacterUntrainedSkills.Name = "comboBox_CharacterUntrainedSkills";
            this.comboBox_CharacterUntrainedSkills.Size = new System.Drawing.Size(252, 23);
            this.comboBox_CharacterUntrainedSkills.TabIndex = 12;
            this.comboBox_CharacterUntrainedSkills.SelectedIndexChanged += new System.EventHandler(this.comboBox_CharacterUntrainedSkills_SelectedIndexChanged);
            // 
            // numericUpDown_CharacterSkillValue
            // 
            this.numericUpDown_CharacterSkillValue.Location = new System.Drawing.Point(15, 259);
            this.numericUpDown_CharacterSkillValue.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_CharacterSkillValue.Name = "numericUpDown_CharacterSkillValue";
            this.numericUpDown_CharacterSkillValue.Size = new System.Drawing.Size(91, 23);
            this.numericUpDown_CharacterSkillValue.TabIndex = 13;
            this.numericUpDown_CharacterSkillValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_CharacterSkillValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CharacterSkillValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button_ResetSkills
            // 
            this.button_ResetSkills.Location = new System.Drawing.Point(111, 259);
            this.button_ResetSkills.Name = "button_ResetSkills";
            this.button_ResetSkills.Size = new System.Drawing.Size(155, 23);
            this.button_ResetSkills.TabIndex = 14;
            this.button_ResetSkills.Text = "Reset";
            this.button_ResetSkills.UseVisualStyleBackColor = true;
            this.button_ResetSkills.Click += new System.EventHandler(this.button_ResetSkills_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inspiration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(519, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Combat Dice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(519, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Character Points";
            // 
            // numericUpDown_Inspiration
            // 
            this.numericUpDown_Inspiration.Location = new System.Drawing.Point(652, 13);
            this.numericUpDown_Inspiration.Name = "numericUpDown_Inspiration";
            this.numericUpDown_Inspiration.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_Inspiration.TabIndex = 18;
            this.numericUpDown_Inspiration.ValueChanged += new System.EventHandler(this.numericUpDown_Inspiration_ValueChanged);
            // 
            // numericUpDown_CombatDice
            // 
            this.numericUpDown_CombatDice.Location = new System.Drawing.Point(652, 42);
            this.numericUpDown_CombatDice.Name = "numericUpDown_CombatDice";
            this.numericUpDown_CombatDice.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_CombatDice.TabIndex = 19;
            this.numericUpDown_CombatDice.ValueChanged += new System.EventHandler(this.numericUpDown_CombatDice_ValueChanged);
            // 
            // numericUpDown_CharacterPoints
            // 
            this.numericUpDown_CharacterPoints.Location = new System.Drawing.Point(652, 102);
            this.numericUpDown_CharacterPoints.Name = "numericUpDown_CharacterPoints";
            this.numericUpDown_CharacterPoints.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_CharacterPoints.TabIndex = 20;
            this.numericUpDown_CharacterPoints.ValueChanged += new System.EventHandler(this.numericUpDown_CharacterPoints_ValueChanged);
            // 
            // numericUpDown_Mana
            // 
            this.numericUpDown_Mana.Location = new System.Drawing.Point(326, 71);
            this.numericUpDown_Mana.Name = "numericUpDown_Mana";
            this.numericUpDown_Mana.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_Mana.TabIndex = 26;
            this.numericUpDown_Mana.ValueChanged += new System.EventHandler(this.numericUpDown_Mana_ValueChanged);
            // 
            // numericUpDown_Speed
            // 
            this.numericUpDown_Speed.Location = new System.Drawing.Point(326, 42);
            this.numericUpDown_Speed.Name = "numericUpDown_Speed";
            this.numericUpDown_Speed.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_Speed.TabIndex = 25;
            this.numericUpDown_Speed.ValueChanged += new System.EventHandler(this.numericUpDown_Speed_ValueChanged);
            // 
            // numericUpDown_Health
            // 
            this.numericUpDown_Health.Location = new System.Drawing.Point(326, 13);
            this.numericUpDown_Health.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Health.Name = "numericUpDown_Health";
            this.numericUpDown_Health.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_Health.TabIndex = 24;
            this.numericUpDown_Health.ValueChanged += new System.EventHandler(this.numericUpDown_Health_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(279, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "MAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(279, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "SPD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(279, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "HTP";
            // 
            // numericUpDown_PerformanceDice
            // 
            this.numericUpDown_PerformanceDice.Location = new System.Drawing.Point(652, 71);
            this.numericUpDown_PerformanceDice.Name = "numericUpDown_PerformanceDice";
            this.numericUpDown_PerformanceDice.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_PerformanceDice.TabIndex = 28;
            this.numericUpDown_PerformanceDice.ValueChanged += new System.EventHandler(this.numericUpDown_PerformanceDice_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(519, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Performance Dice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(391, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(391, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(391, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "/";
            // 
            // numericUpDown_ManaMax
            // 
            this.numericUpDown_ManaMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_ManaMax.Location = new System.Drawing.Point(411, 71);
            this.numericUpDown_ManaMax.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_ManaMax.Name = "numericUpDown_ManaMax";
            this.numericUpDown_ManaMax.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_ManaMax.TabIndex = 34;
            this.numericUpDown_ManaMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_ManaMax.ValueChanged += new System.EventHandler(this.numericUpDown_ManaMax_ValueChanged);
            // 
            // numericUpDown_SpeedMax
            // 
            this.numericUpDown_SpeedMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_SpeedMax.Location = new System.Drawing.Point(411, 42);
            this.numericUpDown_SpeedMax.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_SpeedMax.Name = "numericUpDown_SpeedMax";
            this.numericUpDown_SpeedMax.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_SpeedMax.TabIndex = 33;
            this.numericUpDown_SpeedMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_SpeedMax.ValueChanged += new System.EventHandler(this.numericUpDown_SpeedMax_ValueChanged);
            // 
            // numericUpDown_HealthMax
            // 
            this.numericUpDown_HealthMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_HealthMax.Location = new System.Drawing.Point(411, 13);
            this.numericUpDown_HealthMax.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_HealthMax.Name = "numericUpDown_HealthMax";
            this.numericUpDown_HealthMax.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_HealthMax.TabIndex = 32;
            this.numericUpDown_HealthMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_HealthMax.ValueChanged += new System.EventHandler(this.numericUpDown_HealthMax_ValueChanged);
            // 
            // listBox_Feats
            // 
            this.listBox_Feats.FormattingEnabled = true;
            this.listBox_Feats.ItemHeight = 15;
            this.listBox_Feats.Location = new System.Drawing.Point(15, 318);
            this.listBox_Feats.Name = "listBox_Feats";
            this.listBox_Feats.Size = new System.Drawing.Size(203, 94);
            this.listBox_Feats.TabIndex = 35;
            this.listBox_Feats.SelectedIndexChanged += new System.EventHandler(this.listBox_Feats_SelectedIndexChanged);
            // 
            // listBox_Flaws
            // 
            this.listBox_Flaws.FormattingEnabled = true;
            this.listBox_Flaws.ItemHeight = 15;
            this.listBox_Flaws.Location = new System.Drawing.Point(227, 318);
            this.listBox_Flaws.Name = "listBox_Flaws";
            this.listBox_Flaws.Size = new System.Drawing.Size(205, 94);
            this.listBox_Flaws.TabIndex = 36;
            this.listBox_Flaws.SelectedIndexChanged += new System.EventHandler(this.listBox_Flaws_SelectedIndexChanged);
            // 
            // comboBox_UntrainedFeats
            // 
            this.comboBox_UntrainedFeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UntrainedFeats.FormattingEnabled = true;
            this.comboBox_UntrainedFeats.Location = new System.Drawing.Point(14, 418);
            this.comboBox_UntrainedFeats.Name = "comboBox_UntrainedFeats";
            this.comboBox_UntrainedFeats.Size = new System.Drawing.Size(204, 23);
            this.comboBox_UntrainedFeats.TabIndex = 37;
            this.comboBox_UntrainedFeats.SelectedIndexChanged += new System.EventHandler(this.comboBox_UntrainedFeats_SelectedIndexChanged);
            // 
            // comboBox_UntrainedFlaws
            // 
            this.comboBox_UntrainedFlaws.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UntrainedFlaws.FormattingEnabled = true;
            this.comboBox_UntrainedFlaws.Location = new System.Drawing.Point(227, 418);
            this.comboBox_UntrainedFlaws.Name = "comboBox_UntrainedFlaws";
            this.comboBox_UntrainedFlaws.Size = new System.Drawing.Size(205, 23);
            this.comboBox_UntrainedFlaws.TabIndex = 38;
            this.comboBox_UntrainedFlaws.SelectedIndexChanged += new System.EventHandler(this.comboBox_UntrainedFlaws_SelectedIndexChanged);
            // 
            // button_NewCharacterFeat
            // 
            this.button_NewCharacterFeat.Location = new System.Drawing.Point(15, 448);
            this.button_NewCharacterFeat.Name = "button_NewCharacterFeat";
            this.button_NewCharacterFeat.Size = new System.Drawing.Size(91, 23);
            this.button_NewCharacterFeat.TabIndex = 39;
            this.button_NewCharacterFeat.Text = "Custom Feat";
            this.button_NewCharacterFeat.UseVisualStyleBackColor = true;
            this.button_NewCharacterFeat.Click += new System.EventHandler(this.button_NewCharacterFeat_Click);
            // 
            // button_RemoveCharacterFeat
            // 
            this.button_RemoveCharacterFeat.Location = new System.Drawing.Point(112, 448);
            this.button_RemoveCharacterFeat.Name = "button_RemoveCharacterFeat";
            this.button_RemoveCharacterFeat.Size = new System.Drawing.Size(91, 23);
            this.button_RemoveCharacterFeat.TabIndex = 40;
            this.button_RemoveCharacterFeat.Text = "Remove Feat";
            this.button_RemoveCharacterFeat.UseVisualStyleBackColor = true;
            this.button_RemoveCharacterFeat.Click += new System.EventHandler(this.button_RemoveCharacterFeat_Click);
            // 
            // button_NewCharacterFlaw
            // 
            this.button_NewCharacterFlaw.Location = new System.Drawing.Point(236, 449);
            this.button_NewCharacterFlaw.Name = "button_NewCharacterFlaw";
            this.button_NewCharacterFlaw.Size = new System.Drawing.Size(91, 23);
            this.button_NewCharacterFlaw.TabIndex = 41;
            this.button_NewCharacterFlaw.Text = "Custom Flaw";
            this.button_NewCharacterFlaw.UseVisualStyleBackColor = true;
            this.button_NewCharacterFlaw.Click += new System.EventHandler(this.button_NewCharacterFlaw_Click);
            // 
            // button_RemoveCharacterFlaw
            // 
            this.button_RemoveCharacterFlaw.Location = new System.Drawing.Point(333, 449);
            this.button_RemoveCharacterFlaw.Name = "button_RemoveCharacterFlaw";
            this.button_RemoveCharacterFlaw.Size = new System.Drawing.Size(91, 23);
            this.button_RemoveCharacterFlaw.TabIndex = 42;
            this.button_RemoveCharacterFlaw.Text = "Remove Flaw";
            this.button_RemoveCharacterFlaw.UseVisualStyleBackColor = true;
            this.button_RemoveCharacterFlaw.Click += new System.EventHandler(this.button_RemoveCharacterFlaw_Click);
            // 
            // label_CharacterPoints
            // 
            this.label_CharacterPoints.AutoSize = true;
            this.label_CharacterPoints.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CharacterPoints.Location = new System.Drawing.Point(279, 102);
            this.label_CharacterPoints.Name = "label_CharacterPoints";
            this.label_CharacterPoints.Size = new System.Drawing.Size(108, 19);
            this.label_CharacterPoints.TabIndex = 43;
            this.label_CharacterPoints.Text = "Character Value:";
            // 
            // label_CharacterPointsValue
            // 
            this.label_CharacterPointsValue.AutoSize = true;
            this.label_CharacterPointsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CharacterPointsValue.Location = new System.Drawing.Point(388, 102);
            this.label_CharacterPointsValue.Name = "label_CharacterPointsValue";
            this.label_CharacterPointsValue.Size = new System.Drawing.Size(17, 19);
            this.label_CharacterPointsValue.TabIndex = 44;
            this.label_CharacterPointsValue.Text = "0";
            // 
            // listBox_CharacterItems
            // 
            this.listBox_CharacterItems.FormattingEnabled = true;
            this.listBox_CharacterItems.ItemHeight = 15;
            this.listBox_CharacterItems.Location = new System.Drawing.Point(442, 318);
            this.listBox_CharacterItems.Name = "listBox_CharacterItems";
            this.listBox_CharacterItems.Size = new System.Drawing.Size(268, 94);
            this.listBox_CharacterItems.TabIndex = 45;
            this.listBox_CharacterItems.SelectedIndexChanged += new System.EventHandler(this.listBox_CharacterItems_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(421, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_Realistic
            // 
            this.label_Realistic.AutoSize = true;
            this.label_Realistic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Realistic.Location = new System.Drawing.Point(435, 102);
            this.label_Realistic.Name = "label_Realistic";
            this.label_Realistic.Size = new System.Drawing.Size(63, 19);
            this.label_Realistic.TabIndex = 47;
            this.label_Realistic.Text = "Realistic?";
            // 
            // numericUpDown_ItemQuantity
            // 
            this.numericUpDown_ItemQuantity.Location = new System.Drawing.Point(442, 448);
            this.numericUpDown_ItemQuantity.Name = "numericUpDown_ItemQuantity";
            this.numericUpDown_ItemQuantity.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown_ItemQuantity.TabIndex = 48;
            this.numericUpDown_ItemQuantity.ValueChanged += new System.EventHandler(this.numericUpDown_ItemQuantity_ValueChanged_1);
            // 
            // button_DeleteItem
            // 
            this.button_DeleteItem.Location = new System.Drawing.Point(615, 448);
            this.button_DeleteItem.Name = "button_DeleteItem";
            this.button_DeleteItem.Size = new System.Drawing.Size(95, 23);
            this.button_DeleteItem.TabIndex = 49;
            this.button_DeleteItem.Text = "Remove Item";
            this.button_DeleteItem.UseVisualStyleBackColor = true;
            this.button_DeleteItem.Click += new System.EventHandler(this.button_DeleteItem_Click);
            // 
            // comboBox_CharacterItems
            // 
            this.comboBox_CharacterItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CharacterItems.FormattingEnabled = true;
            this.comboBox_CharacterItems.Location = new System.Drawing.Point(442, 418);
            this.comboBox_CharacterItems.Name = "comboBox_CharacterItems";
            this.comboBox_CharacterItems.Size = new System.Drawing.Size(167, 23);
            this.comboBox_CharacterItems.TabIndex = 50;
            this.comboBox_CharacterItems.SelectedIndexChanged += new System.EventHandler(this.comboBox_CharacterItems_SelectedIndexChanged);
            // 
            // listBox_Notes
            // 
            this.listBox_Notes.FormattingEnabled = true;
            this.listBox_Notes.ItemHeight = 15;
            this.listBox_Notes.Location = new System.Drawing.Point(489, 479);
            this.listBox_Notes.Name = "listBox_Notes";
            this.listBox_Notes.Size = new System.Drawing.Size(221, 109);
            this.listBox_Notes.TabIndex = 51;
            this.listBox_Notes.SelectedIndexChanged += new System.EventHandler(this.listBox_Notes_SelectedIndexChanged);
            // 
            // button_NewNote
            // 
            this.button_NewNote.Location = new System.Drawing.Point(488, 594);
            this.button_NewNote.Name = "button_NewNote";
            this.button_NewNote.Size = new System.Drawing.Size(69, 23);
            this.button_NewNote.TabIndex = 52;
            this.button_NewNote.Text = "New Note";
            this.button_NewNote.UseVisualStyleBackColor = true;
            this.button_NewNote.Click += new System.EventHandler(this.button_NewNote_Click);
            // 
            // button_DeleteNote
            // 
            this.button_DeleteNote.Location = new System.Drawing.Point(563, 594);
            this.button_DeleteNote.Name = "button_DeleteNote";
            this.button_DeleteNote.Size = new System.Drawing.Size(79, 23);
            this.button_DeleteNote.TabIndex = 53;
            this.button_DeleteNote.Text = "Delete Note";
            this.button_DeleteNote.UseVisualStyleBackColor = true;
            this.button_DeleteNote.Click += new System.EventHandler(this.button_DeleteNote_Click);
            // 
            // richTextBox_CharacterNotes
            // 
            this.richTextBox_CharacterNotes.Location = new System.Drawing.Point(276, 137);
            this.richTextBox_CharacterNotes.Name = "richTextBox_CharacterNotes";
            this.richTextBox_CharacterNotes.Size = new System.Drawing.Size(426, 164);
            this.richTextBox_CharacterNotes.TabIndex = 54;
            this.richTextBox_CharacterNotes.Text = "";
            this.richTextBox_CharacterNotes.TextChanged += new System.EventHandler(this.richTextBox_CharacterNotes_TextChanged);
            // 
            // button_CustomItem
            // 
            this.button_CustomItem.Location = new System.Drawing.Point(514, 448);
            this.button_CustomItem.Name = "button_CustomItem";
            this.button_CustomItem.Size = new System.Drawing.Size(95, 23);
            this.button_CustomItem.TabIndex = 55;
            this.button_CustomItem.Text = "Custom Item";
            this.button_CustomItem.UseVisualStyleBackColor = true;
            this.button_CustomItem.Click += new System.EventHandler(this.button_CustomItem_Click);
            // 
            // button_MoveUp
            // 
            this.button_MoveUp.Location = new System.Drawing.Point(615, 419);
            this.button_MoveUp.Name = "button_MoveUp";
            this.button_MoveUp.Size = new System.Drawing.Size(95, 23);
            this.button_MoveUp.TabIndex = 56;
            this.button_MoveUp.Text = "Move Up";
            this.button_MoveUp.UseVisualStyleBackColor = true;
            this.button_MoveUp.Click += new System.EventHandler(this.button_MoveUp_Click);
            // 
            // button_CopyTo
            // 
            this.button_CopyTo.Location = new System.Drawing.Point(326, 594);
            this.button_CopyTo.Name = "button_CopyTo";
            this.button_CopyTo.Size = new System.Drawing.Size(71, 23);
            this.button_CopyTo.TabIndex = 57;
            this.button_CopyTo.Text = "Copy To";
            this.button_CopyTo.UseVisualStyleBackColor = true;
            this.button_CopyTo.Click += new System.EventHandler(this.button_CopyTo_Click);
            // 
            // button_DeleteProfile
            // 
            this.button_DeleteProfile.Location = new System.Drawing.Point(93, 594);
            this.button_DeleteProfile.Name = "button_DeleteProfile";
            this.button_DeleteProfile.Size = new System.Drawing.Size(87, 23);
            this.button_DeleteProfile.TabIndex = 58;
            this.button_DeleteProfile.Text = "Delete Profile";
            this.button_DeleteProfile.UseVisualStyleBackColor = true;
            this.button_DeleteProfile.Click += new System.EventHandler(this.button_DeleteProfile_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(183, 594);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(53, 23);
            this.button_Save.TabIndex = 59;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(648, 594);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(61, 23);
            this.button_Export.TabIndex = 60;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(725, 629);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_DeleteProfile);
            this.Controls.Add(this.button_CopyTo);
            this.Controls.Add(this.button_MoveUp);
            this.Controls.Add(this.button_CustomItem);
            this.Controls.Add(this.richTextBox_CharacterNotes);
            this.Controls.Add(this.button_DeleteNote);
            this.Controls.Add(this.button_NewNote);
            this.Controls.Add(this.listBox_Notes);
            this.Controls.Add(this.comboBox_CharacterItems);
            this.Controls.Add(this.button_DeleteItem);
            this.Controls.Add(this.numericUpDown_ItemQuantity);
            this.Controls.Add(this.label_Realistic);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox_CharacterItems);
            this.Controls.Add(this.label_CharacterPointsValue);
            this.Controls.Add(this.label_CharacterPoints);
            this.Controls.Add(this.button_RemoveCharacterFlaw);
            this.Controls.Add(this.button_NewCharacterFlaw);
            this.Controls.Add(this.button_RemoveCharacterFeat);
            this.Controls.Add(this.button_NewCharacterFeat);
            this.Controls.Add(this.comboBox_UntrainedFlaws);
            this.Controls.Add(this.comboBox_UntrainedFeats);
            this.Controls.Add(this.listBox_Flaws);
            this.Controls.Add(this.listBox_Feats);
            this.Controls.Add(this.numericUpDown_ManaMax);
            this.Controls.Add(this.numericUpDown_SpeedMax);
            this.Controls.Add(this.numericUpDown_HealthMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_PerformanceDice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_Mana);
            this.Controls.Add(this.numericUpDown_Speed);
            this.Controls.Add(this.numericUpDown_Health);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_CharacterPoints);
            this.Controls.Add(this.numericUpDown_CombatDice);
            this.Controls.Add(this.numericUpDown_Inspiration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ResetSkills);
            this.Controls.Add(this.numericUpDown_CharacterSkillValue);
            this.Controls.Add(this.comboBox_CharacterUntrainedSkills);
            this.Controls.Add(this.listBox_CharacterSkills);
            this.Controls.Add(this.comboBox_CharacterTrait2);
            this.Controls.Add(this.textBox_CharacterTrait1);
            this.Controls.Add(this.comboBox_CharacterRace);
            this.Controls.Add(this.textBox_CharacterName);
            this.Controls.Add(this.button_DeleteCharacter);
            this.Controls.Add(this.button_NewCharacter);
            this.Controls.Add(this.listBox_Characters);
            this.Controls.Add(this.listBox_Profiles);
            this.Controls.Add(this.buttonNewProfile);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(741, 668);
            this.MinimumSize = new System.Drawing.Size(741, 668);
            this.Name = "Main";
            this.Text = "LURPS Character Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CharacterSkillValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Inspiration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CombatDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CharacterPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PerformanceDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ManaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HealthMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ItemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewProfile;
        private System.Windows.Forms.ListBox listBox_Profiles;
        private System.Windows.Forms.ListBox listBox_Characters;
        private System.Windows.Forms.Button button_NewCharacter;
        private System.Windows.Forms.Button button_DeleteCharacter;
        private System.Windows.Forms.TextBox textBox_CharacterName;
        private System.Windows.Forms.ComboBox comboBox_CharacterRace;
        private System.Windows.Forms.TextBox textBox_CharacterTrait1;
        private System.Windows.Forms.ComboBox comboBox_CharacterTrait2;
        private System.Windows.Forms.ListBox listBox_CharacterSkills;
        private System.Windows.Forms.ComboBox comboBox_CharacterUntrainedSkills;
        private System.Windows.Forms.NumericUpDown numericUpDown_CharacterSkillValue;
        private System.Windows.Forms.Button button_ResetSkills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Inspiration;
        private System.Windows.Forms.NumericUpDown numericUpDown_CombatDice;
        private System.Windows.Forms.NumericUpDown numericUpDown_CharacterPoints;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mana;
        private System.Windows.Forms.NumericUpDown numericUpDown_Speed;
        private System.Windows.Forms.NumericUpDown numericUpDown_Health;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_PerformanceDice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_ManaMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_SpeedMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_HealthMax;
        private System.Windows.Forms.ListBox listBox_Feats;
        private System.Windows.Forms.ListBox listBox_Flaws;
        private System.Windows.Forms.ComboBox comboBox_UntrainedFeats;
        private System.Windows.Forms.ComboBox comboBox_UntrainedFlaws;
        private System.Windows.Forms.Button button_NewCharacterFeat;
        private System.Windows.Forms.Button button_RemoveCharacterFeat;
        private System.Windows.Forms.Button button_NewCharacterFlaw;
        private System.Windows.Forms.Button button_RemoveCharacterFlaw;
        private System.Windows.Forms.Label label_CharacterPoints;
        private System.Windows.Forms.Label label_CharacterPointsValue;
        private System.Windows.Forms.ListBox listBox_CharacterItems;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_Realistic;
        private System.Windows.Forms.NumericUpDown numericUpDown_ItemQuantity;
        private System.Windows.Forms.Button button_DeleteItem;
        private System.Windows.Forms.ComboBox comboBox_CharacterItems;
        private System.Windows.Forms.ListBox listBox_Notes;
        private System.Windows.Forms.Button button_NewNote;
        private System.Windows.Forms.Button button_DeleteNote;
        private System.Windows.Forms.RichTextBox richTextBox_CharacterNotes;
        private System.Windows.Forms.Button button_CustomItem;
        private System.Windows.Forms.Button button_MoveUp;
        private System.Windows.Forms.Button button_CopyTo;
        private System.Windows.Forms.Button button_DeleteProfile;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Export;
    }
}

