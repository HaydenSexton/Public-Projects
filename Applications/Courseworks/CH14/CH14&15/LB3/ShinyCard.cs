using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class ShinyCard : ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;
        private System.Drawing.Font _font;
        private System.Drawing.Color _backColor;
        private System.Drawing.Color _foreColor;

        public ShinyCard(string name, System.Drawing.Image image, double value, System.Drawing.Font font, System.Drawing.Color backColor, System.Drawing.Color foreColor)
        {
            _name = name;

            _image = image;
            _value = value;
            _font = font;
            _backColor = backColor;
            _foreColor = foreColor;
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

        public System.Drawing.Font Font
        {
            get { return _font; }
            set { _font = value; }
        }

        public System.Drawing.Color BackColor
        {
            get { return _backColor; }
            set { _backColor = value; }
        }

        public System.Drawing.Color ForeColor
        {
            get { return _foreColor; }
            set { _foreColor = value; }
        }

        public void ShowCard(PictureBox pictureBox, Label label)
        {
            pictureBox.Image = _image;
            label.Text = _name;

            label.Font = _font;
            label.BackColor = _backColor;
            label.ForeColor = _foreColor;
        }
    }
}
