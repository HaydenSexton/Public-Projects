using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class MattedPhoto : Photo
    {
        protected Color _color;
        
        public MattedPhoto(float width, float height, Color color) : base(width, height)
        {
            _color = color;
        }

        public override string ToString()
        {
            return $"{Width}x{Height} MattedPhoto ({Color})";
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public override float Price => base.Price + 10F;
    }
}