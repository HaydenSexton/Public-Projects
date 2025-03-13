namespace DCS_Compendium
{
    partial class VehicleInfo
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
            btnBack = new Button();
            pbVehicleImage = new PictureBox();
            lblWeakness = new Label();
            rchtxtWeakness = new RichTextBox();
            lblnameOfUnit = new Label();
            lbltypeOfUnit = new Label();
            lblgroupOfUnit = new Label();
            lblDescription = new Label();
            rchtxtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pbVehicleImage
            // 
            pbVehicleImage.Image = Properties.Resources.DCS_background;
            pbVehicleImage.Location = new Point(12, 41);
            pbVehicleImage.Name = "pbVehicleImage";
            pbVehicleImage.Size = new Size(287, 218);
            pbVehicleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVehicleImage.TabIndex = 1;
            pbVehicleImage.TabStop = false;
            // 
            // lblWeakness
            // 
            lblWeakness.AutoSize = true;
            lblWeakness.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblWeakness.ForeColor = Color.Red;
            lblWeakness.Location = new Point(100, 287);
            lblWeakness.Name = "lblWeakness";
            lblWeakness.Size = new Size(95, 25);
            lblWeakness.TabIndex = 7;
            lblWeakness.Text = "Weakness";
            // 
            // rchtxtWeakness
            // 
            rchtxtWeakness.BackColor = Color.Silver;
            rchtxtWeakness.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rchtxtWeakness.Location = new Point(12, 315);
            rchtxtWeakness.Name = "rchtxtWeakness";
            rchtxtWeakness.ReadOnly = true;
            rchtxtWeakness.Size = new Size(287, 123);
            rchtxtWeakness.TabIndex = 4;
            rchtxtWeakness.Text = "";
            // 
            // lblnameOfUnit
            // 
            lblnameOfUnit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnameOfUnit.Location = new Point(370, 41);
            lblnameOfUnit.Name = "lblnameOfUnit";
            lblnameOfUnit.Size = new Size(384, 30);
            lblnameOfUnit.TabIndex = 0;
            lblnameOfUnit.Text = "Name of Unit";
            lblnameOfUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltypeOfUnit
            // 
            lbltypeOfUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltypeOfUnit.Location = new Point(370, 71);
            lbltypeOfUnit.Name = "lbltypeOfUnit";
            lbltypeOfUnit.Size = new Size(384, 21);
            lbltypeOfUnit.TabIndex = 1;
            lbltypeOfUnit.Text = "Type of Unit";
            lbltypeOfUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblgroupOfUnit
            // 
            lblgroupOfUnit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgroupOfUnit.Location = new Point(370, 92);
            lblgroupOfUnit.Name = "lblgroupOfUnit";
            lblgroupOfUnit.Size = new Size(384, 17);
            lblgroupOfUnit.TabIndex = 2;
            lblgroupOfUnit.Text = "Group of Unit";
            lblgroupOfUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(509, 162);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // rchtxtDescription
            // 
            rchtxtDescription.BackColor = Color.Silver;
            rchtxtDescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rchtxtDescription.Location = new Point(370, 190);
            rchtxtDescription.Name = "rchtxtDescription";
            rchtxtDescription.ReadOnly = true;
            rchtxtDescription.Size = new Size(384, 248);
            rchtxtDescription.TabIndex = 3;
            rchtxtDescription.Text = "";
            // 
            // VehicleInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(rchtxtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblgroupOfUnit);
            Controls.Add(lbltypeOfUnit);
            Controls.Add(lblnameOfUnit);
            Controls.Add(rchtxtWeakness);
            Controls.Add(lblWeakness);
            Controls.Add(pbVehicleImage);
            Controls.Add(btnBack);
            Name = "VehicleInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle Info";
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private PictureBox pbVehicleImage;
        private Label lblWeakness;
        private RichTextBox rchtxtWeakness;
        private Label lblnameOfUnit;
        private Label lbltypeOfUnit;
        private Label lblgroupOfUnit;
        private Label lblDescription;
        private RichTextBox rchtxtDescription;
    }
}