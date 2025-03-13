using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class NormalCard : ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;

        public NormalCard(string name, System.Drawing.Image image, double value)
        {
            _name = name;
            _image = image;
            _value = value;
        }

        public string Name

        {
            get { return _name; }
            set { _name = value; }
        }

        public System.Drawing.Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void ShowCard(PictureBox pictureBox, Label label)
        {
            pictureBox.Image = _image;
            label.Text = _name;

            label.Font = new System.Drawing.Font("Arial", 12);
            label.BackColor = default(Color); 
            label.ForeColor = default(Color);
        }
    }
}
