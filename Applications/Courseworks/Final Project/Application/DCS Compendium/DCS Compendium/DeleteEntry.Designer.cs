namespace DCS_Compendium
{
    partial class DeleteEntry
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
            txtFind = new TextBox();
            btnFind = new Button();
            btnDelete = new Button();
            lblFindResult = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.Location = new Point(12, 65);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(674, 23);
            txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(530, 94);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(611, 94);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblFindResult
            // 
            lblFindResult.AutoSize = true;
            lblFindResult.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFindResult.ForeColor = Color.White;
            lblFindResult.Location = new Point(59, 141);
            lblFindResult.Name = "lblFindResult";
            lblFindResult.Size = new Size(0, 20);
            lblFindResult.TabIndex = 4;
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
            // DeleteEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(698, 232);
            Controls.Add(btnBack);
            Controls.Add(lblFindResult);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Name = "DeleteEntry";
            Text = "DeleteEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFind;
        private Button btnFind;
        private Button btnDelete;
        private Label lblFindResult;
        private Button btnBack;
    }
}