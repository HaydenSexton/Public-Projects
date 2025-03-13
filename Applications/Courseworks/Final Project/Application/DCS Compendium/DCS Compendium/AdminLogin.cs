using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCS_Compendium
{
    public partial class AdminLogin : Form
    {
        Vehicle vehicle = new Vehicle();
        AddEntry addEntry = new AddEntry();
        formMainScreen mainScreen = new formMainScreen();
        public AdminLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnEnter;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                formMainScreen formMainScreen = new formMainScreen();
                formMainScreen.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string passAttempt = txtpassCode.Text;
                addEntry.checkLogin(passAttempt);
                if (addEntry.passFound != false)
                {
                    if (Vehicle.Instance.FormToOpen == "Create")
                    {
                        this.Hide();
                        CreateNewEntry createNewEntry = new CreateNewEntry();
                        createNewEntry.ShowDialog();
                        this.Close();
                    }
                    else if (Vehicle.Instance.FormToOpen == "Delete")
                    {
                        this.Hide();
                        DeleteEntry deleteEntry = new DeleteEntry();
                        deleteEntry.ShowDialog();
                        this.Close();
                    }
                    else if (Vehicle.Instance.FormToOpen == "Update")
                    {
                        this.Hide();
                        UpdateEntry updateEntry = new UpdateEntry();
                        updateEntry.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
    }
}
