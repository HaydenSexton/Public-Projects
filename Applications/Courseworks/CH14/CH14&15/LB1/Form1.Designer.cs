namespace LB1
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
            rchtxttransactionLog = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRecipient = new TextBox();
            txtsentDate = new TextBox();
            txttrackingNumber = new TextBox();
            btnSend = new Button();
            lblFULL = new Label();
            SuspendLayout();
            // 
            // rchtxttransactionLog
            // 
            rchtxttransactionLog.Location = new Point(241, 12);
            rchtxttransactionLog.Name = "rchtxttransactionLog";
            rchtxttransactionLog.ReadOnly = true;
            rchtxttransactionLog.Size = new Size(236, 411);
            rchtxttransactionLog.TabIndex = 0;
            rchtxttransactionLog.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Recipient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(87, 89);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Sent Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(67, 145);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Tracking Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 189);
            label4.Name = "label4";
            label4.Size = new Size(185, 15);
            label4.TabIndex = 4;
            label4.Text = "(Additional Fee for certified letter)";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(23, 33);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(185, 23);
            txtRecipient.TabIndex = 5;
            // 
            // txtsentDate
            // 
            txtsentDate.Location = new Point(23, 107);
            txtsentDate.Name = "txtsentDate";
            txtsentDate.Size = new Size(185, 23);
            txtsentDate.TabIndex = 6;
            // 
            // txttrackingNumber
            // 
            txttrackingNumber.Location = new Point(23, 163);
            txttrackingNumber.Name = "txttrackingNumber";
            txttrackingNumber.Size = new Size(185, 23);
            txttrackingNumber.TabIndex = 7;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(87, 210);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblFULL
            // 
            lblFULL.AutoSize = true;
            lblFULL.ForeColor = Color.Red;
            lblFULL.Location = new Point(67, 246);
            lblFULL.Name = "lblFULL";
            lblFULL.Size = new Size(112, 15);
            lblFULL.TabIndex = 9;
            lblFULL.Text = "Transaction Log Full";
            lblFULL.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 435);
            Controls.Add(lblFULL);
            Controls.Add(btnSend);
            Controls.Add(txttrackingNumber);
            Controls.Add(txtsentDate);
            Controls.Add(txtRecipient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rchtxttransactionLog);
            Name = "Form1";
            Text = "Letter Delivery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchtxttransactionLog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRecipient;
        private TextBox txtsentDate;
        private TextBox txttrackingNumber;
        private Button btnSend;
        private Label lblFULL;
    }
}
