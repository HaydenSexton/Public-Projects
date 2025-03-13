using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Photo : Object
    {
        protected float _width;
        protected float _height;

        public Photo(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public override string ToString()
        {
            return $"{Width}x{Height} UnframedPhoto";
        }

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public virtual float Price
        {
            get
            {
                if (Width == 8 && Height == 10)
                    return 3.99F;
                else if (Width == 10 && Height == 12)
                    return 5.99F;
                else
                    return 9.99F; 
            }
        }
    }
}