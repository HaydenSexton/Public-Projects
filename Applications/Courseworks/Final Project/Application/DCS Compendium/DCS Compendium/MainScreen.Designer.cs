namespace DCS_Compendium
{
    partial class formMainScreen
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btncreateNewEntry = new Button();
            btnGround = new Button();
            btnAir = new Button();
            btnNaval = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(155, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(173, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btncreateNewEntry
            // 
            btncreateNewEntry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncreateNewEntry.Location = new Point(666, 11);
            btncreateNewEntry.Name = "btncreateNewEntry";
            btncreateNewEntry.Size = new Size(122, 55);
            btncreateNewEntry.TabIndex = 5;
            btncreateNewEntry.Text = "Create New Entry";
            btncreateNewEntry.UseVisualStyleBackColor = true;
            btncreateNewEntry.Click += btncreateNewEntry_Click;
            // 
            // btnGround
            // 
            btnGround.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGround.Location = new Point(33, 351);
            btnGround.Name = "btnGround";
            btnGround.Size = new Size(134, 76);
            btnGround.TabIndex = 2;
            btnGround.Text = "Ground";
            btnGround.UseVisualStyleBackColor = true;
            btnGround.Click += btnGround_Click;
            // 
            // btnAir
            // 
            btnAir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAir.Location = new Point(198, 351);
            btnAir.Name = "btnAir";
            btnAir.Size = new Size(134, 76);
            btnAir.TabIndex = 3;
            btnAir.Text = "Air";
            btnAir.UseVisualStyleBackColor = true;
            btnAir.Click += btnAir_Click;
            // 
            // btnNaval
            // 
            btnNaval.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNaval.Location = new Point(367, 351);
            btnNaval.Name = "btnNaval";
            btnNaval.Size = new Size(134, 76);
            btnNaval.TabIndex = 4;
            btnNaval.Text = "Naval";
            btnNaval.UseVisualStyleBackColor = true;
            btnNaval.Click += btnNaval_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(668, 72);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 55);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Entry";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(668, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 55);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Entry";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // formMainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DCS_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNaval);
            Controls.Add(btnAir);
            Controls.Add(btnGround);
            Controls.Add(btncreateNewEntry);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "formMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DCS Compendium";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btncreateNewEntry;
        private Button btnGround;
        private Button btnAir;
        private Button btnNaval;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
