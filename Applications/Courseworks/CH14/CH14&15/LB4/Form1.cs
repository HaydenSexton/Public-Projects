using System.Diagnostics.Eventing.Reader;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Account loggedInAccount;
        bool silverpermissions = false;
        bool goldpermissions = false;
        const decimal taxamount = .01m;

        List<Account> accountList = new List<Account>()
        {
            new Account("157-351-454", "2887", "Charlie Johnson", (decimal)8237.66),
            new SilverAccount("105-288-294", "5272", "Alice Jones", (decimal)3912.21),
            new SilverAccount("161-113-356", "1549", "Eve Brown", (decimal)8744.88),
            new GoldAccount("324-896-288", "5785", "Bob Johnson", (decimal)8728.38),
            new GoldAccount("136-981-812", "7027", "Diana Smith", (decimal)5311.11)
        };
        List<string> silverStatements = new List<string>();
        List<string> goldStatements = new List<string>();
        private void Logout()
        {
            lblwelcomeMSG.Text = "You are logged out.";
            lblaccountBalance.Text = "";
            lblaccountType.Text = "";
            txtaccountNum.Text = "";
            txtpinNum.Text = "";
            txtDeposit.Text = "";
            txtWithdraw.Text = "";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lblERROR.Visible = false;
            decimal amount = Convert.ToDecimal(txtDeposit.Text);
            silverStatements.Insert(0, $"DEPOSIT - ${amount}\n");
            goldStatements.Insert(0, $"DEPOSIT - ${amount}\n");

            foreach (Account account in accountList)
            {
                if (loggedInAccount == account)
                {
                    account.makeDeposit(amount);
                    lblaccountBalance.Text = $"Your new account balance is ${account.GetBalance()}";
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            lblERROR.Visible = false;
            decimal amount = Convert.ToDecimal(txtWithdraw.Text);

            foreach (Account account in accountList)
            {
                if (loggedInAccount == account)
                {
                    if (silverpermissions == true && account.GetBalance() - amount < 1000 || account.GetBalance() - amount <= 0)
                    {
                        lblERROR.Visible = true;
                        lblERROR.Text = "Not Enough Funds.";
                        break;
                    }
                    if (goldpermissions == true && account.GetBalance() - amount < 5000 || account.GetBalance() - amount <= 0)
                    {
                        lblERROR.Visible = true;
                        lblERROR.Text = "Not Enough Funds.";
                        break;
                    }
                    if (account is GoldAccount)
                    {
                        account.makeWithdrawal(amount);
                        decimal balance = account.GetBalance();
                        lblaccountBalance.Text = $"Your new account balance is ${account.GetBalance()}";
                    }
                    else
                    {
                        decimal taxedamount = amount + (amount * taxamount);
                        account.makeWithdrawal(taxedamount);
                        decimal balance = account.GetBalance();
                        lblaccountBalance.Text = $"Your new account balance is ${account.GetBalance()}";
                    }
                    silverStatements.Insert(0, $"WITHDRAW - ${amount}\n");
                    goldStatements.Insert(0, $"WITHDRAW - ${amount}\n");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblERROR.Visible = false;
            Boolean accFound = false;
            string accountNumber = txtaccountNum.Text;
            string pin = txtpinNum.Text;

            foreach (Account account in accountList)
            {
                if (accountNumber == (account.getAccountNumber()) && pin == account.GetPin())
                {
                    accFound = true;
                    string name = account.GetName();
                    decimal balance = account.GetBalance();
                    loggedInAccount = account;

                    lblwelcomeMSG.Text = $"Welcome, {name}!";
                    lblaccountBalance.Text = $"Your current account balance is ${balance}";
                    goldpermissions = false;
                    silverpermissions = false;

                    if (account is GoldAccount)
                    {
                        lblaccountType.Text = "Account Type: Gold";
                        goldpermissions = true;
                    }
                    else if (account is SilverAccount)
                    {
                        lblaccountType.Text = "Account Type: Silver";
                        silverpermissions = true;
                    }
                    else
                    {
                        lblaccountType.Text = "Account Type: Bronze";
                    }
                    break;
                }
            }
            if (!accFound)
            {
                lblwelcomeMSG.Text = "Invalid account or PIN.";
                lblaccountBalance.Text = "";
                lblaccountType.Text = "";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblERROR.Visible = false;
            Logout();
            silverStatements.Clear();
            goldStatements.Clear();
        }

        private void btnprintStatement_Click(object sender, EventArgs e)
        {
            lblERROR.Visible = false;
            if (silverpermissions == true)
            {
                Form2 printSilverStatements = new Form2(silverStatements);
                printSilverStatements.ShowDialog();
            }
            if (goldpermissions == true)
            {
                Form3 printGoldStatements = new Form3(goldStatements); // tried my best to make a "fancy" statement
                printGoldStatements.ShowDialog();
            }
            if (!goldpermissions && !silverpermissions)
            {
                lblERROR.Visible = true;
                lblERROR.Text = "You cannot print statements.";
            }
        }
    }
}
