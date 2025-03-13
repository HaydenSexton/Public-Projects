namespace LB4
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
            lblaccountNum = new Label();
            lblpinNum = new Label();
            txtaccountNum = new TextBox();
            txtpinNum = new TextBox();
            btnLogin = new Button();
            lblwelcomeMSG = new Label();
            lblaccountBalance = new Label();
            lblaccountType = new Label();
            lblmakeADeposit = new Label();
            lblmakeAWithdraw = new Label();
            txtDeposit = new TextBox();
            txtWithdraw = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnprintStatement = new Button();
            btnLogout = new Button();
            lblERROR = new Label();
            SuspendLayout();
            // 
            // lblaccountNum
            // 
            lblaccountNum.AutoSize = true;
            lblaccountNum.Location = new Point(12, 9);
            lblaccountNum.Name = "lblaccountNum";
            lblaccountNum.Size = new Size(62, 15);
            lblaccountNum.TabIndex = 0;
            lblaccountNum.Text = "Account #";
            // 
            // lblpinNum
            // 
            lblpinNum.AutoSize = true;
            lblpinNum.Location = new Point(19, 41);
            lblpinNum.Name = "lblpinNum";
            lblpinNum.Size = new Size(34, 15);
            lblpinNum.TabIndex = 1;
            lblpinNum.Text = "Pin #";
            // 
            // txtaccountNum
            // 
            txtaccountNum.Location = new Point(80, 6);
            txtaccountNum.Name = "txtaccountNum";
            txtaccountNum.Size = new Size(78, 23);
            txtaccountNum.TabIndex = 2;
            // 
            // txtpinNum
            // 
            txtpinNum.Location = new Point(80, 38);
            txtpinNum.Name = "txtpinNum";
            txtpinNum.Size = new Size(36, 23);
            txtpinNum.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(122, 38);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblwelcomeMSG
            // 
            lblwelcomeMSG.AutoSize = true;
            lblwelcomeMSG.Location = new Point(97, 93);
            lblwelcomeMSG.Name = "lblwelcomeMSG";
            lblwelcomeMSG.Size = new Size(0, 15);
            lblwelcomeMSG.TabIndex = 5;
            // 
            // lblaccountBalance
            // 
            lblaccountBalance.AutoSize = true;
            lblaccountBalance.Location = new Point(67, 121);
            lblaccountBalance.Name = "lblaccountBalance";
            lblaccountBalance.Size = new Size(0, 15);
            lblaccountBalance.TabIndex = 6;
            // 
            // lblaccountType
            // 
            lblaccountType.AutoSize = true;
            lblaccountType.Location = new Point(97, 146);
            lblaccountType.Name = "lblaccountType";
            lblaccountType.Size = new Size(0, 15);
            lblaccountType.TabIndex = 7;
            // 
            // lblmakeADeposit
            // 
            lblmakeADeposit.AutoSize = true;
            lblmakeADeposit.Location = new Point(19, 209);
            lblmakeADeposit.Name = "lblmakeADeposit";
            lblmakeADeposit.Size = new Size(188, 15);
            lblmakeADeposit.TabIndex = 8;
            lblmakeADeposit.Text = "Would you like to make a deposit?";
            // 
            // lblmakeAWithdraw
            // 
            lblmakeAWithdraw.AutoSize = true;
            lblmakeAWithdraw.Location = new Point(19, 310);
            lblmakeAWithdraw.Name = "lblmakeAWithdraw";
            lblmakeAWithdraw.Size = new Size(209, 15);
            lblmakeAWithdraw.TabIndex = 9;
            lblmakeAWithdraw.Text = "Would you like to make a Withdrawal?";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(19, 227);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(202, 23);
            txtDeposit.TabIndex = 10;
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(19, 328);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(204, 23);
            txtWithdraw.TabIndex = 11;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(229, 227);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(75, 23);
            btnDeposit.TabIndex = 12;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(229, 328);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 13;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnprintStatement
            // 
            btnprintStatement.Location = new Point(92, 373);
            btnprintStatement.Name = "btnprintStatement";
            btnprintStatement.Size = new Size(129, 23);
            btnprintStatement.TabIndex = 14;
            btnprintStatement.Text = "Print Statement";
            btnprintStatement.UseVisualStyleBackColor = true;
            btnprintStatement.Click += btnprintStatement_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(122, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblERROR
            // 
            lblERROR.AutoSize = true;
            lblERROR.ForeColor = Color.Red;
            lblERROR.Location = new Point(19, 185);
            lblERROR.Name = "lblERROR";
            lblERROR.Size = new Size(43, 15);
            lblERROR.TabIndex = 16;
            lblERROR.Text = "ERROR";
            lblERROR.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(lblERROR);
            Controls.Add(btnLogout);
            Controls.Add(btnprintStatement);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(txtWithdraw);
            Controls.Add(txtDeposit);
            Controls.Add(lblmakeAWithdraw);
            Controls.Add(lblmakeADeposit);
            Controls.Add(lblaccountType);
            Controls.Add(lblaccountBalance);
            Controls.Add(lblwelcomeMSG);
            Controls.Add(btnLogin);
            Controls.Add(txtpinNum);
            Controls.Add(txtaccountNum);
            Controls.Add(lblpinNum);
            Controls.Add(lblaccountNum);
            Name = "Form1";
            Text = "Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblaccountNum;
        private Label lblpinNum;
        private TextBox txtaccountNum;
        private TextBox txtpinNum;
        private Button btnLogin;
        private Label lblwelcomeMSG;
        private Label lblaccountBalance;
        private Label lblaccountType;
        private Label lblmakeADeposit;
        private Label lblmakeAWithdraw;
        private TextBox txtDeposit;
        private TextBox txtWithdraw;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnprintStatement;
        private Button btnLogout;
        private Label lblERROR;
    }
}
