namespace DCS_Compendium
{
    partial class AdminLogin
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
            lblpassword = new Label();
            txtpassCode = new TextBox();
            btnEnter = new Button();
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
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(12, 52);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(60, 15);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password:";
            // 
            // txtpassCode
            // 
            txtpassCode.Location = new Point(90, 49);
            txtpassCode.Name = "txtpassCode";
            txtpassCode.Size = new Size(218, 23);
            txtpassCode.TabIndex = 2;
            txtpassCode.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(330, 49);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 94);
            Controls.Add(btnEnter);
            Controls.Add(txtpassCode);
            Controls.Add(lblpassword);
            Controls.Add(btnBack);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblpassword;
        private TextBox txtpassCode;
        private Button btnEnter;
    }
}