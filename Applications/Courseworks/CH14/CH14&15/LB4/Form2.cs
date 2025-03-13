using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form2 : Form
    {
        public Form2(List <string> statements)
        {
            InitializeComponent();

            foreach (var item in statements)
            {
                lblStatement.Text += item;
            }
        }
    }
}
