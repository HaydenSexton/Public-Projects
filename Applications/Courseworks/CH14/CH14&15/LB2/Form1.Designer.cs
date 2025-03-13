namespace LB2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            lblCost = new Label();
            lblfinalInfo = new Label();
            grpboxFrame = new GroupBox();
            rbtnFramed = new RadioButton();
            rbtnMatted = new RadioButton();
            rbtnUnframed = new RadioButton();
            grpboxcolors = new GroupBox();
            rbtnWhite = new RadioButton();
            rbtnBlue = new RadioButton();
            rbtnGreen = new RadioButton();
            rbtnRed = new RadioButton();
            rbtnBlack = new RadioButton();
            grpboxmaterial = new GroupBox();
            rbtnGold = new RadioButton();
            rbtnSilver = new RadioButton();
            rbtnSteel = new RadioButton();
            rbtnOak = new RadioButton();
            rbtnPine = new RadioButton();
            grpboxstyle = new GroupBox();
            rbtnEclectic = new RadioButton();
            rbtnVintage = new RadioButton();
            rbtnAntique = new RadioButton();
            rbtnModern = new RadioButton();
            rbtnSimple = new RadioButton();
            grpboxFrame.SuspendLayout();
            grpboxcolors.SuspendLayout();
            grpboxmaterial.SuspendLayout();
            grpboxstyle.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Width (in)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Height (in)";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(89, 18);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(328, 23);
            txtWidth.TabIndex = 2;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(89, 60);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(328, 23);
            txtHeight.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(23, 397);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 26;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCost.Location = new Point(183, 405);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(0, 37);
            lblCost.TabIndex = 27;
            // 
            // lblfinalInfo
            // 
            lblfinalInfo.AutoSize = true;
            lblfinalInfo.Location = new Point(23, 457);
            lblfinalInfo.Name = "lblfinalInfo";
            lblfinalInfo.Size = new Size(0, 15);
            lblfinalInfo.TabIndex = 28;
            // 
            // grpboxFrame
            // 
            grpboxFrame.Controls.Add(rbtnFramed);
            grpboxFrame.Controls.Add(rbtnMatted);
            grpboxFrame.Controls.Add(rbtnUnframed);
            grpboxFrame.Location = new Point(46, 105);
            grpboxFrame.Name = "grpboxFrame";
            grpboxFrame.Size = new Size(200, 106);
            grpboxFrame.TabIndex = 29;
            grpboxFrame.TabStop = false;
            grpboxFrame.Text = "Frame";
            // 
            // rbtnFramed
            // 
            rbtnFramed.AutoSize = true;
            rbtnFramed.Location = new Point(19, 72);
            rbtnFramed.Name = "rbtnFramed";
            rbtnFramed.Size = new Size(65, 19);
            rbtnFramed.TabIndex = 30;
            rbtnFramed.TabStop = true;
            rbtnFramed.Text = "Framed";
            rbtnFramed.UseVisualStyleBackColor = true;
            // 
            // rbtnMatted
            // 
            rbtnMatted.AutoSize = true;
            rbtnMatted.Location = new Point(19, 47);
            rbtnMatted.Name = "rbtnMatted";
            rbtnMatted.Size = new Size(63, 19);
            rbtnMatted.TabIndex = 31;
            rbtnMatted.TabStop = true;
            rbtnMatted.Text = "Matted";
            rbtnMatted.UseVisualStyleBackColor = true;
            // 
            // rbtnUnframed
            // 
            rbtnUnframed.AutoSize = true;
            rbtnUnframed.Location = new Point(19, 22);
            rbtnUnframed.Name = "rbtnUnframed";
            rbtnUnframed.Size = new Size(78, 19);
            rbtnUnframed.TabIndex = 30;
            rbtnUnframed.TabStop = true;
            rbtnUnframed.Text = "Unframed";
            rbtnUnframed.UseVisualStyleBackColor = true;
            // 
            // grpboxcolors
            // 
            grpboxcolors.Controls.Add(rbtnWhite);
            grpboxcolors.Controls.Add(rbtnBlue);
            grpboxcolors.Controls.Add(rbtnGreen);
            grpboxcolors.Controls.Add(rbtnRed);
            grpboxcolors.Controls.Add(rbtnBlack);
            grpboxcolors.Location = new Point(23, 217);
            grpboxcolors.Name = "grpboxcolors";
            grpboxcolors.Size = new Size(107, 174);
            grpboxcolors.TabIndex = 30;
            grpboxcolors.TabStop = false;
            grpboxcolors.Text = "Color";
            // 
            // rbtnWhite
            // 
            rbtnWhite.AutoSize = true;
            rbtnWhite.Location = new Point(7, 122);
            rbtnWhite.Name = "rbtnWhite";
            rbtnWhite.Size = new Size(56, 19);
            rbtnWhite.TabIndex = 4;
            rbtnWhite.TabStop = true;
            rbtnWhite.Tag = "WHITE";
            rbtnWhite.Text = "White";
            rbtnWhite.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            rbtnBlue.AutoSize = true;
            rbtnBlue.Location = new Point(7, 97);
            rbtnBlue.Name = "rbtnBlue";
            rbtnBlue.Size = new Size(48, 19);
            rbtnBlue.TabIndex = 3;
            rbtnBlue.TabStop = true;
            rbtnBlue.Tag = "BLUE";
            rbtnBlue.Text = "Blue";
            rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rbtnGreen
            // 
            rbtnGreen.AutoSize = true;
            rbtnGreen.Location = new Point(7, 72);
            rbtnGreen.Name = "rbtnGreen";
            rbtnGreen.Size = new Size(56, 19);
            rbtnGreen.TabIndex = 2;
            rbtnGreen.TabStop = true;
            rbtnGreen.Tag = "GREEN";
            rbtnGreen.Text = "Green";
            rbtnGreen.UseVisualStyleBackColor = true;
            // 
            // rbtnRed
            // 
            rbtnRed.AutoSize = true;
            rbtnRed.Location = new Point(7, 47);
            rbtnRed.Name = "rbtnRed";
            rbtnRed.Size = new Size(45, 19);
            rbtnRed.TabIndex = 1;
            rbtnRed.TabStop = true;
            rbtnRed.Tag = "RED";
            rbtnRed.Text = "Red";
            rbtnRed.UseVisualStyleBackColor = true;
            // 
            // rbtnBlack
            // 
            rbtnBlack.AutoSize = true;
            rbtnBlack.Location = new Point(7, 22);
            rbtnBlack.Name = "rbtnBlack";
            rbtnBlack.Size = new Size(53, 19);
            rbtnBlack.TabIndex = 0;
            rbtnBlack.TabStop = true;
            rbtnBlack.Tag = "BLACK";
            rbtnBlack.Text = "Black";
            rbtnBlack.UseVisualStyleBackColor = true;
            // 
            // grpboxmaterial
            // 
            grpboxmaterial.Controls.Add(rbtnGold);
            grpboxmaterial.Controls.Add(rbtnSilver);
            grpboxmaterial.Controls.Add(rbtnSteel);
            grpboxmaterial.Controls.Add(rbtnOak);
            grpboxmaterial.Controls.Add(rbtnPine);
            grpboxmaterial.Location = new Point(148, 217);
            grpboxmaterial.Name = "grpboxmaterial";
            grpboxmaterial.Size = new Size(137, 174);
            grpboxmaterial.TabIndex = 31;
            grpboxmaterial.TabStop = false;
            grpboxmaterial.Text = "Material";
            // 
            // rbtnGold
            // 
            rbtnGold.AutoSize = true;
            rbtnGold.Location = new Point(6, 122);
            rbtnGold.Name = "rbtnGold";
            rbtnGold.Size = new Size(50, 19);
            rbtnGold.TabIndex = 4;
            rbtnGold.TabStop = true;
            rbtnGold.Tag = "GOLD";
            rbtnGold.Text = "Gold";
            rbtnGold.UseVisualStyleBackColor = true;
            // 
            // rbtnSilver
            // 
            rbtnSilver.AutoSize = true;
            rbtnSilver.Location = new Point(6, 97);
            rbtnSilver.Name = "rbtnSilver";
            rbtnSilver.Size = new Size(53, 19);
            rbtnSilver.TabIndex = 3;
            rbtnSilver.TabStop = true;
            rbtnSilver.Tag = "SILVER";
            rbtnSilver.Text = "Silver";
            rbtnSilver.UseVisualStyleBackColor = true;
            // 
            // rbtnSteel
            // 
            rbtnSteel.AutoSize = true;
            rbtnSteel.Location = new Point(6, 72);
            rbtnSteel.Name = "rbtnSteel";
            rbtnSteel.Size = new Size(50, 19);
            rbtnSteel.TabIndex = 2;
            rbtnSteel.TabStop = true;
            rbtnSteel.Tag = "STEEL";
            rbtnSteel.Text = "Steel";
            rbtnSteel.UseVisualStyleBackColor = true;
            // 
            // rbtnOak
            // 
            rbtnOak.AutoSize = true;
            rbtnOak.Location = new Point(6, 47);
            rbtnOak.Name = "rbtnOak";
            rbtnOak.Size = new Size(46, 19);
            rbtnOak.TabIndex = 1;
            rbtnOak.TabStop = true;
            rbtnOak.Tag = "OAK";
            rbtnOak.Text = "Oak";
            rbtnOak.UseVisualStyleBackColor = true;
            // 
            // rbtnPine
            // 
            rbtnPine.AutoSize = true;
            rbtnPine.Location = new Point(6, 22);
            rbtnPine.Name = "rbtnPine";
            rbtnPine.Size = new Size(48, 19);
            rbtnPine.TabIndex = 0;
            rbtnPine.TabStop = true;
            rbtnPine.Tag = "PINE";
            rbtnPine.Text = "Pine";
            rbtnPine.UseVisualStyleBackColor = true;
            // 
            // grpboxstyle
            // 
            grpboxstyle.Controls.Add(rbtnEclectic);
            grpboxstyle.Controls.Add(rbtnVintage);
            grpboxstyle.Controls.Add(rbtnAntique);
            grpboxstyle.Controls.Add(rbtnModern);
            grpboxstyle.Controls.Add(rbtnSimple);
            grpboxstyle.Location = new Point(291, 217);
            grpboxstyle.Name = "grpboxstyle";
            grpboxstyle.Size = new Size(126, 174);
            grpboxstyle.TabIndex = 32;
            grpboxstyle.TabStop = false;
            grpboxstyle.Text = "Style";
            // 
            // rbtnEclectic
            // 
            rbtnEclectic.AutoSize = true;
            rbtnEclectic.Location = new Point(6, 122);
            rbtnEclectic.Name = "rbtnEclectic";
            rbtnEclectic.Size = new Size(65, 19);
            rbtnEclectic.TabIndex = 4;
            rbtnEclectic.TabStop = true;
            rbtnEclectic.Tag = "ECLECTIC";
            rbtnEclectic.Text = "Eclectic";
            rbtnEclectic.UseVisualStyleBackColor = true;
            // 
            // rbtnVintage
            // 
            rbtnVintage.AutoSize = true;
            rbtnVintage.Location = new Point(6, 97);
            rbtnVintage.Name = "rbtnVintage";
            rbtnVintage.Size = new Size(65, 19);
            rbtnVintage.TabIndex = 3;
            rbtnVintage.TabStop = true;
            rbtnVintage.Tag = "VINTAGE";
            rbtnVintage.Text = "Vintage";
            rbtnVintage.UseVisualStyleBackColor = true;
            // 
            // rbtnAntique
            // 
            rbtnAntique.AutoSize = true;
            rbtnAntique.Location = new Point(6, 72);
            rbtnAntique.Name = "rbtnAntique";
            rbtnAntique.Size = new Size(67, 19);
            rbtnAntique.TabIndex = 2;
            rbtnAntique.TabStop = true;
            rbtnAntique.Tag = "ANTIQUE";
            rbtnAntique.Text = "Antique";
            rbtnAntique.UseVisualStyleBackColor = true;
            // 
            // rbtnModern
            // 
            rbtnModern.AutoSize = true;
            rbtnModern.Location = new Point(6, 47);
            rbtnModern.Name = "rbtnModern";
            rbtnModern.Size = new Size(67, 19);
            rbtnModern.TabIndex = 1;
            rbtnModern.TabStop = true;
            rbtnModern.Tag = "MODERN";
            rbtnModern.Text = "Modern";
            rbtnModern.UseVisualStyleBackColor = true;
            // 
            // rbtnSimple
            // 
            rbtnSimple.AutoSize = true;
            rbtnSimple.Location = new Point(6, 22);
            rbtnSimple.Name = "rbtnSimple";
            rbtnSimple.Size = new Size(61, 19);
            rbtnSimple.TabIndex = 0;
            rbtnSimple.TabStop = true;
            rbtnSimple.Tag = "SIMPLE";
            rbtnSimple.Text = "Simple";
            rbtnSimple.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 493);
            Controls.Add(grpboxstyle);
            Controls.Add(grpboxmaterial);
            Controls.Add(grpboxcolors);
            Controls.Add(grpboxFrame);
            Controls.Add(lblfinalInfo);
            Controls.Add(lblCost);
            Controls.Add(btnCalculate);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Photoshop";
            grpboxFrame.ResumeLayout(false);
            grpboxFrame.PerformLayout();
            grpboxcolors.ResumeLayout(false);
            grpboxcolors.PerformLayout();
            grpboxmaterial.ResumeLayout(false);
            grpboxmaterial.PerformLayout();
            grpboxstyle.ResumeLayout(false);
            grpboxstyle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Label lblCost;
        private Label lblfinalInfo;
        private GroupBox grpboxFrame;
        private RadioButton rbtnFramed;
        private RadioButton rbtnMatted;
        private RadioButton rbtnUnframed;
        private GroupBox grpboxcolors;
        private RadioButton rbtnWhite;
        private RadioButton rbtnBlue;
        private RadioButton rbtnGreen;
        private RadioButton rbtnRed;
        private RadioButton rbtnBlack;
        private GroupBox grpboxmaterial;
        private RadioButton rbtnGold;
        private RadioButton rbtnSilver;
        private RadioButton rbtnSteel;
        private RadioButton rbtnOak;
        private RadioButton rbtnPine;
        private GroupBox grpboxstyle;
        private RadioButton rbtnEclectic;
        private RadioButton rbtnVintage;
        private RadioButton rbtnAntique;
        private RadioButton rbtnModern;
        private RadioButton rbtnSimple;
    }
}
