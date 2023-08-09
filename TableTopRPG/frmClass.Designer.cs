
namespace TableTopRPG
{
    partial class frmClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBarbarian = new System.Windows.Forms.Button();
            this.btnBard = new System.Windows.Forms.Button();
            this.btnCleric = new System.Windows.Forms.Button();
            this.btnDruid = new System.Windows.Forms.Button();
            this.btnFighter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWizard = new System.Windows.Forms.Button();
            this.btnWarlock = new System.Windows.Forms.Button();
            this.btnSorcerer = new System.Windows.Forms.Button();
            this.btnRogue = new System.Windows.Forms.Button();
            this.btnRanger = new System.Windows.Forms.Button();
            this.btnPaladin = new System.Windows.Forms.Button();
            this.btnMonk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboProficiencies = new System.Windows.Forms.ListBox();
            this.txtHitDice = new System.Windows.Forms.TextBox();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.lboEquipmentChoiceOptions = new System.Windows.Forms.ListBox();
            this.txtSubClassDesc = new System.Windows.Forms.RichTextBox();
            this.lboSubClassChoice = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lboEquipmentChoices = new System.Windows.Forms.ListBox();
            this.lboStarterEquipment = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRepickProf = new System.Windows.Forms.Button();
            this.txtProfChoiceDesc = new System.Windows.Forms.RichTextBox();
            this.lboProfChoices = new System.Windows.Forms.ListBox();
            this.txtProfChoices = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBarbarian
            // 
            this.btnBarbarian.Location = new System.Drawing.Point(6, 19);
            this.btnBarbarian.Name = "btnBarbarian";
            this.btnBarbarian.Size = new System.Drawing.Size(75, 23);
            this.btnBarbarian.TabIndex = 0;
            this.btnBarbarian.Text = "Barbarian";
            this.btnBarbarian.UseVisualStyleBackColor = true;
            this.btnBarbarian.Click += new System.EventHandler(this.btnBarbarian_Click);
            // 
            // btnBard
            // 
            this.btnBard.Location = new System.Drawing.Point(6, 49);
            this.btnBard.Name = "btnBard";
            this.btnBard.Size = new System.Drawing.Size(75, 23);
            this.btnBard.TabIndex = 1;
            this.btnBard.Text = "Bard";
            this.btnBard.UseVisualStyleBackColor = true;
            this.btnBard.Click += new System.EventHandler(this.btnBard_Click);
            // 
            // btnCleric
            // 
            this.btnCleric.Location = new System.Drawing.Point(6, 79);
            this.btnCleric.Name = "btnCleric";
            this.btnCleric.Size = new System.Drawing.Size(75, 23);
            this.btnCleric.TabIndex = 2;
            this.btnCleric.Text = "Cleric";
            this.btnCleric.UseVisualStyleBackColor = true;
            this.btnCleric.Click += new System.EventHandler(this.btnCleric_Click);
            // 
            // btnDruid
            // 
            this.btnDruid.Location = new System.Drawing.Point(6, 109);
            this.btnDruid.Name = "btnDruid";
            this.btnDruid.Size = new System.Drawing.Size(75, 23);
            this.btnDruid.TabIndex = 3;
            this.btnDruid.Text = "Druid";
            this.btnDruid.UseVisualStyleBackColor = true;
            this.btnDruid.Click += new System.EventHandler(this.btnDruid_Click);
            // 
            // btnFighter
            // 
            this.btnFighter.Location = new System.Drawing.Point(6, 139);
            this.btnFighter.Name = "btnFighter";
            this.btnFighter.Size = new System.Drawing.Size(75, 23);
            this.btnFighter.TabIndex = 4;
            this.btnFighter.Text = "Fighter";
            this.btnFighter.UseVisualStyleBackColor = true;
            this.btnFighter.Click += new System.EventHandler(this.btnFighter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWizard);
            this.groupBox1.Controls.Add(this.btnWarlock);
            this.groupBox1.Controls.Add(this.btnSorcerer);
            this.groupBox1.Controls.Add(this.btnRogue);
            this.groupBox1.Controls.Add(this.btnRanger);
            this.groupBox1.Controls.Add(this.btnPaladin);
            this.groupBox1.Controls.Add(this.btnMonk);
            this.groupBox1.Controls.Add(this.btnBarbarian);
            this.groupBox1.Controls.Add(this.btnFighter);
            this.groupBox1.Controls.Add(this.btnBard);
            this.groupBox1.Controls.Add(this.btnDruid);
            this.groupBox1.Controls.Add(this.btnCleric);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 382);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a Class";
            // 
            // btnWizard
            // 
            this.btnWizard.Location = new System.Drawing.Point(7, 349);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(75, 23);
            this.btnWizard.TabIndex = 11;
            this.btnWizard.Text = "Wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
            // 
            // btnWarlock
            // 
            this.btnWarlock.Location = new System.Drawing.Point(7, 319);
            this.btnWarlock.Name = "btnWarlock";
            this.btnWarlock.Size = new System.Drawing.Size(75, 23);
            this.btnWarlock.TabIndex = 10;
            this.btnWarlock.Text = "Warlock";
            this.btnWarlock.UseVisualStyleBackColor = true;
            this.btnWarlock.Click += new System.EventHandler(this.btnWarlock_Click);
            // 
            // btnSorcerer
            // 
            this.btnSorcerer.Location = new System.Drawing.Point(7, 289);
            this.btnSorcerer.Name = "btnSorcerer";
            this.btnSorcerer.Size = new System.Drawing.Size(75, 23);
            this.btnSorcerer.TabIndex = 9;
            this.btnSorcerer.Text = "Sorcerer";
            this.btnSorcerer.UseVisualStyleBackColor = true;
            this.btnSorcerer.Click += new System.EventHandler(this.btnSorcerer_Click);
            // 
            // btnRogue
            // 
            this.btnRogue.Location = new System.Drawing.Point(7, 259);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.Size = new System.Drawing.Size(75, 23);
            this.btnRogue.TabIndex = 8;
            this.btnRogue.Text = "Rogue";
            this.btnRogue.UseVisualStyleBackColor = true;
            this.btnRogue.Click += new System.EventHandler(this.btnRogue_Click);
            // 
            // btnRanger
            // 
            this.btnRanger.Location = new System.Drawing.Point(7, 229);
            this.btnRanger.Name = "btnRanger";
            this.btnRanger.Size = new System.Drawing.Size(75, 23);
            this.btnRanger.TabIndex = 7;
            this.btnRanger.Text = "Ranger";
            this.btnRanger.UseVisualStyleBackColor = true;
            this.btnRanger.Click += new System.EventHandler(this.btnRanger_Click);
            // 
            // btnPaladin
            // 
            this.btnPaladin.Location = new System.Drawing.Point(7, 199);
            this.btnPaladin.Name = "btnPaladin";
            this.btnPaladin.Size = new System.Drawing.Size(75, 23);
            this.btnPaladin.TabIndex = 6;
            this.btnPaladin.Text = "Paladin";
            this.btnPaladin.UseVisualStyleBackColor = true;
            this.btnPaladin.Click += new System.EventHandler(this.btnPaladin_Click);
            // 
            // btnMonk
            // 
            this.btnMonk.Location = new System.Drawing.Point(7, 169);
            this.btnMonk.Name = "btnMonk";
            this.btnMonk.Size = new System.Drawing.Size(75, 23);
            this.btnMonk.TabIndex = 5;
            this.btnMonk.Text = "Monk";
            this.btnMonk.UseVisualStyleBackColor = true;
            this.btnMonk.Click += new System.EventHandler(this.btnMonk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hit Dice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proficiencies:";
            // 
            // lboProficiencies
            // 
            this.lboProficiencies.FormattingEnabled = true;
            this.lboProficiencies.Location = new System.Drawing.Point(114, 54);
            this.lboProficiencies.Name = "lboProficiencies";
            this.lboProficiencies.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboProficiencies.Size = new System.Drawing.Size(160, 108);
            this.lboProficiencies.TabIndex = 8;
            // 
            // txtHitDice
            // 
            this.txtHitDice.Location = new System.Drawing.Point(114, 22);
            this.txtHitDice.Name = "txtHitDice";
            this.txtHitDice.ReadOnly = true;
            this.txtHitDice.Size = new System.Drawing.Size(100, 20);
            this.txtHitDice.TabIndex = 9;
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.lboEquipmentChoiceOptions);
            this.grpName.Controls.Add(this.txtSubClassDesc);
            this.grpName.Controls.Add(this.lboSubClassChoice);
            this.grpName.Controls.Add(this.label6);
            this.grpName.Controls.Add(this.label5);
            this.grpName.Controls.Add(this.lboEquipmentChoices);
            this.grpName.Controls.Add(this.lboStarterEquipment);
            this.grpName.Controls.Add(this.label4);
            this.grpName.Controls.Add(this.btnRepickProf);
            this.grpName.Controls.Add(this.txtProfChoiceDesc);
            this.grpName.Controls.Add(this.lboProfChoices);
            this.grpName.Controls.Add(this.txtProfChoices);
            this.grpName.Controls.Add(this.label3);
            this.grpName.Controls.Add(this.lboProficiencies);
            this.grpName.Controls.Add(this.txtHitDice);
            this.grpName.Controls.Add(this.label1);
            this.grpName.Controls.Add(this.label2);
            this.grpName.Location = new System.Drawing.Point(109, 12);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(679, 598);
            this.grpName.TabIndex = 12;
            this.grpName.TabStop = false;
            this.grpName.Text = "\"\"";
            // 
            // lboEquipmentChoiceOptions
            // 
            this.lboEquipmentChoiceOptions.FormattingEnabled = true;
            this.lboEquipmentChoiceOptions.Location = new System.Drawing.Point(449, 397);
            this.lboEquipmentChoiceOptions.Name = "lboEquipmentChoiceOptions";
            this.lboEquipmentChoiceOptions.Size = new System.Drawing.Size(224, 43);
            this.lboEquipmentChoiceOptions.TabIndex = 23;
            this.lboEquipmentChoiceOptions.SelectedIndexChanged += new System.EventHandler(this.lboEquipmentChoiceOptions_SelectedIndexChanged);
            // 
            // txtSubClassDesc
            // 
            this.txtSubClassDesc.Location = new System.Drawing.Point(354, 459);
            this.txtSubClassDesc.Name = "txtSubClassDesc";
            this.txtSubClassDesc.Size = new System.Drawing.Size(319, 96);
            this.txtSubClassDesc.TabIndex = 22;
            this.txtSubClassDesc.Text = "";
            // 
            // lboSubClassChoice
            // 
            this.lboSubClassChoice.FormattingEnabled = true;
            this.lboSubClassChoice.Location = new System.Drawing.Point(114, 459);
            this.lboSubClassChoice.Name = "lboSubClassChoice";
            this.lboSubClassChoice.Size = new System.Drawing.Size(234, 56);
            this.lboSubClassChoice.TabIndex = 21;
            this.lboSubClassChoice.SelectedIndexChanged += new System.EventHandler(this.lboSubClassChoice_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Subclass Option(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Equipment Choice";
            // 
            // lboEquipmentChoices
            // 
            this.lboEquipmentChoices.FormattingEnabled = true;
            this.lboEquipmentChoices.Location = new System.Drawing.Point(114, 397);
            this.lboEquipmentChoices.Name = "lboEquipmentChoices";
            this.lboEquipmentChoices.Size = new System.Drawing.Size(329, 43);
            this.lboEquipmentChoices.TabIndex = 17;
            this.lboEquipmentChoices.SelectedIndexChanged += new System.EventHandler(this.lboEquipmentChoices_SelectedIndexChanged);
            // 
            // lboStarterEquipment
            // 
            this.lboStarterEquipment.FormattingEnabled = true;
            this.lboStarterEquipment.Location = new System.Drawing.Point(114, 335);
            this.lboStarterEquipment.Name = "lboStarterEquipment";
            this.lboStarterEquipment.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboStarterEquipment.Size = new System.Drawing.Size(234, 56);
            this.lboStarterEquipment.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Equipment:";
            // 
            // btnRepickProf
            // 
            this.btnRepickProf.Enabled = false;
            this.btnRepickProf.Location = new System.Drawing.Point(318, 289);
            this.btnRepickProf.Name = "btnRepickProf";
            this.btnRepickProf.Size = new System.Drawing.Size(125, 23);
            this.btnRepickProf.TabIndex = 14;
            this.btnRepickProf.Text = "Repick Proficiencies";
            this.btnRepickProf.UseVisualStyleBackColor = true;
            this.btnRepickProf.Click += new System.EventHandler(this.btnRepickProf_Click);
            // 
            // txtProfChoiceDesc
            // 
            this.txtProfChoiceDesc.Location = new System.Drawing.Point(493, 174);
            this.txtProfChoiceDesc.Name = "txtProfChoiceDesc";
            this.txtProfChoiceDesc.Size = new System.Drawing.Size(180, 135);
            this.txtProfChoiceDesc.TabIndex = 13;
            this.txtProfChoiceDesc.Text = "";
            // 
            // lboProfChoices
            // 
            this.lboProfChoices.FormattingEnabled = true;
            this.lboProfChoices.Location = new System.Drawing.Point(280, 175);
            this.lboProfChoices.Name = "lboProfChoices";
            this.lboProfChoices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboProfChoices.Size = new System.Drawing.Size(206, 108);
            this.lboProfChoices.TabIndex = 12;
            this.lboProfChoices.SelectedIndexChanged += new System.EventHandler(this.lboProfChoices_SelectedIndexChanged);
            // 
            // txtProfChoices
            // 
            this.txtProfChoices.Location = new System.Drawing.Point(114, 174);
            this.txtProfChoices.Name = "txtProfChoices";
            this.txtProfChoices.Size = new System.Drawing.Size(160, 135);
            this.txtProfChoices.TabIndex = 11;
            this.txtProfChoices.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proficiency Choices:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(18, 415);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClass";
            this.Text = "Class ";
            this.groupBox1.ResumeLayout(false);
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarbarian;
        private System.Windows.Forms.Button btnBard;
        private System.Windows.Forms.Button btnCleric;
        private System.Windows.Forms.Button btnDruid;
        private System.Windows.Forms.Button btnFighter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWizard;
        private System.Windows.Forms.Button btnWarlock;
        private System.Windows.Forms.Button btnSorcerer;
        private System.Windows.Forms.Button btnRogue;
        private System.Windows.Forms.Button btnRanger;
        private System.Windows.Forms.Button btnPaladin;
        private System.Windows.Forms.Button btnMonk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboProficiencies;
        private System.Windows.Forms.TextBox txtHitDice;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lboProfChoices;
        private System.Windows.Forms.RichTextBox txtProfChoices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtProfChoiceDesc;
        private System.Windows.Forms.Button btnRepickProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboStarterEquipment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboEquipmentChoices;
        private System.Windows.Forms.RichTextBox txtSubClassDesc;
        private System.Windows.Forms.ListBox lboSubClassChoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lboEquipmentChoiceOptions;
    }
}