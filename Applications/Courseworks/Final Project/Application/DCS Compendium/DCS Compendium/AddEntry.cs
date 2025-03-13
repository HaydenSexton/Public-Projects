using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DCS_Compendium
{
    public class AddEntry
    {
        private string _passCode = "shinyPenny123"; // not my real password ofc
        private bool _passFound;

        public bool passFound
        {
            get; set;
        }
        public void checkLogin(string passAttempt)
        {
            if (passAttempt != _passCode)
            {
                MessageBox.Show("Incorrect Password, please try again.", "Wrong Password");
                passFound = false;
            }
            else
            {
                passFound = true;
            }
        }
    }
}
