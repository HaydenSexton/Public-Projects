namespace DCS_Compendium
{
    partial class CreateNewEntry
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
            pbNewImage = new PictureBox();
            btnUpload = new Button();
            lblName = new Label();
            txtName = new TextBox();
            txtClass = new TextBox();
            lblClass = new Label();
            lblType = new Label();
            lblDescription = new Label();
            lblWeakness = new Label();
            rchtxtDescription = new RichTextBox();
            rchtxtWeakness = new RichTextBox();
            btnCreate = new Button();
            txtType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbNewImage).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pbNewImage
            // 
            pbNewImage.Location = new Point(27, 41);
            pbNewImage.Name = "pbNewImage";
            pbNewImage.Size = new Size(308, 253);
            pbNewImage.TabIndex = 1;
            pbNewImage.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(142, 300);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(363, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(411, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 23);
            txtName.TabIndex = 1;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(411, 83);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(363, 23);
            txtClass.TabIndex = 2;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.ForeColor = Color.White;
            lblClass.Location = new Point(363, 86);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(37, 15);
            lblClass.TabIndex = 9;
            lblClass.Text = "Class:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(363, 133);
            lblType.Name = "lblType";
            lblType.Size = new Size(34, 15);
            lblType.TabIndex = 10;
            lblType.Text = "Type:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(186, 343);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblWeakness
            // 
            lblWeakness.AutoSize = true;
            lblWeakness.ForeColor = Color.White;
            lblWeakness.Location = new Point(581, 343);
            lblWeakness.Name = "lblWeakness";
            lblWeakness.Size = new Size(59, 15);
            lblWeakness.TabIndex = 12;
            lblWeakness.Text = "Weakness";
            // 
            // rchtxtDescription
            // 
            rchtxtDescription.Location = new Point(12, 361);
            rchtxtDescription.Name = "rchtxtDescription";
            rchtxtDescription.Size = new Size(407, 256);
            rchtxtDescription.TabIndex = 5;
            rchtxtDescription.Text = "";
            // 
            // rchtxtWeakness
            // 
            rchtxtWeakness.Location = new Point(427, 361);
            rchtxtWeakness.Name = "rchtxtWeakness";
            rchtxtWeakness.Size = new Size(347, 256);
            rchtxtWeakness.TabIndex = 6;
            rchtxtWeakness.Text = "";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(313, 633);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(220, 23);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtType
            // 
            txtType.Location = new Point(411, 130);
            txtType.Name = "txtType";
            txtType.Size = new Size(190, 23);
            txtType.TabIndex = 3;
            // 
            // CreateNewEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(810, 678);
            Controls.Add(txtType);
            Controls.Add(btnCreate);
            Controls.Add(rchtxtWeakness);
            Controls.Add(rchtxtDescription);
            Controls.Add(lblWeakness);
            Controls.Add(lblDescription);
            Controls.Add(lblType);
            Controls.Add(txtClass);
            Controls.Add(lblClass);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnUpload);
            Controls.Add(pbNewImage);
            Controls.Add(btnBack);
            Name = "CreateNewEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Entry";
            ((System.ComponentModel.ISupportInitialize)pbNewImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private PictureBox pbNewImage;
        private Button btnUpload;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtClass;
        private Label lblClass;
        private Label lblType;
        private Label lblDescription;
        private Label lblWeakness;
        private RichTextBox rchtxtDescription;
        private RichTextBox rchtxtWeakness;
        private Button btnCreate;
        private TextBox txtType;
    }
}