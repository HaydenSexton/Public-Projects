namespace LB4
{
    partial class Form2
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
            SuspendLayout();
            // 
            // lblStatement
            // 
            lblStatement.AutoSize = true;
            lblStatement.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatement.Location = new Point(21, 19);
            lblStatement.Name = "lblStatement";
            lblStatement.Size = new Size(0, 20);
            lblStatement.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 222);
            Controls.Add(lblStatement);
            Name = "Form2";
            Text = "Statement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatement;
    }
}