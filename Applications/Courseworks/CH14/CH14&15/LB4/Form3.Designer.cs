namespace LB4
{
    partial class Form3
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
            lblStatement = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblStatement
            // 
            lblStatement.AutoSize = true;
            lblStatement.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatement.Location = new Point(23, 20);
            lblStatement.Name = "lblStatement";
            lblStatement.Size = new Size(0, 18);
            lblStatement.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(93, 543);
            label1.Name = "label1";
            label1.Size = new Size(216, 36);
            label1.TabIndex = 1;
            label1.Text = "Bank Statement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(170, 520);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 2;
            label2.Text = "GOLD";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 588);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStatement);
            Name = "Form3";
            Text = "Statement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatement;
        private Label label1;
        private Label label2;
    }
}