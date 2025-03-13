namespace DCS_Compendium
{
    partial class UpdateEntry
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
            comboKeyToEdit = new ComboBox();
            label1 = new Label();
            txtFind = new TextBox();
            label2 = new Label();
            btnFind = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            lblFindResult = new Label();
            lblSuccess = new Label();
            rchtxtInfoToUpdateWith = new RichTextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // comboKeyToEdit
            // 
            comboKeyToEdit.FormattingEnabled = true;
            comboKeyToEdit.Items.AddRange(new object[] { "VehicleName", "VehicleType", "VehicleClass", "VehicleImagePath", "VehicleWeakness", "VehicleDescription" });
            comboKeyToEdit.Location = new Point(139, 291);
            comboKeyToEdit.Name = "comboKeyToEdit";
            comboKeyToEdit.Size = new Size(193, 23);
            comboKeyToEdit.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 273);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 11;
            label1.Text = "Select which key to edit";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(72, 77);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(324, 23);
            txtFind.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(139, 59);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 9;
            label2.Text = "Find the entry you want to update";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(197, 106);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(210, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Step #1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(210, 258);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Step #2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(210, 356);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "Step #3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(131, 371);
            label6.Name = "label6";
            label6.Size = new Size(201, 15);
            label6.TabIndex = 13;
            label6.Text = "Input info you want to update it with";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(185, 575);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 53);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFindResult
            // 
            lblFindResult.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFindResult.ForeColor = Color.White;
            lblFindResult.Location = new Point(72, 155);
            lblFindResult.Name = "lblFindResult";
            lblFindResult.Size = new Size(324, 81);
            lblFindResult.TabIndex = 6;
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuccess.ForeColor = Color.Lime;
            lblSuccess.Location = new Point(208, 647);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(64, 21);
            lblSuccess.TabIndex = 7;
            lblSuccess.Text = "Success";
            lblSuccess.Visible = false;
            // 
            // rchtxtInfoToUpdateWith
            // 
            rchtxtInfoToUpdateWith.Location = new Point(72, 401);
            rchtxtInfoToUpdateWith.Name = "rchtxtInfoToUpdateWith";
            rchtxtInfoToUpdateWith.Size = new Size(324, 144);
            rchtxtInfoToUpdateWith.TabIndex = 4;
            rchtxtInfoToUpdateWith.Text = "";
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
            // UpdateEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(498, 686);
            Controls.Add(btnBack);
            Controls.Add(rchtxtInfoToUpdateWith);
            Controls.Add(lblSuccess);
            Controls.Add(lblFindResult);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(txtFind);
            Controls.Add(label1);
            Controls.Add(comboKeyToEdit);
            Name = "UpdateEntry";
            Text = "UpdateEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboKeyToEdit;
        private Label label1;
        private TextBox txtFind;
        private Label label2;
        private Button btnFind;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnUpdate;
        private Label lblFindResult;
        private Label lblSuccess;
        private RichTextBox rchtxtInfoToUpdateWith;
        private Button btnBack;
    }
}