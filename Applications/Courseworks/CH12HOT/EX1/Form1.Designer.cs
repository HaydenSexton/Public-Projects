namespace EX1
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
            lblmd5Hash = new Label();
            txtInput = new TextBox();
            btnCrack = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblmd5Hash
            // 
            lblmd5Hash.AutoSize = true;
            lblmd5Hash.Font = new Font("Arial Narrow", 15.75F);
            lblmd5Hash.Location = new Point(42, 28);
            lblmd5Hash.Name = "lblmd5Hash";
            lblmd5Hash.Size = new Size(95, 25);
            lblmd5Hash.TabIndex = 3;
            lblmd5Hash.Text = "MD5 Hash";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(42, 55);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(366, 23);
            txtInput.TabIndex = 0;
            // 
            // btnCrack
            // 
            btnCrack.Location = new Point(431, 54);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(75, 23);
            btnCrack.TabIndex = 1;
            btnCrack.Text = "Crack";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(42, 126);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 16);
            lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 202);
            Controls.Add(lblResult);
            Controls.Add(btnCrack);
            Controls.Add(txtInput);
            Controls.Add(lblmd5Hash);
            Name = "Form1";
            Text = "Password Cracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmd5Hash;
        private TextBox txtInput;
        private Button btnCrack;
        private Label lblResult;
    }
}
