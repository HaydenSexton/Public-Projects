using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class FramedPhoto : Photo
    {
        protected Material _material;
        protected Style _style;

        public FramedPhoto(float width, float height, Material material, Style style) : base(width, height)
        {
            _style = style;
            _material = material;
        }

        public override string ToString()
        {
            return $"{Width}x{Height} FramedPhoto ({Material},{Style})";
        }

        public Material Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public Style Style
        {
            get { return _style; }
            set { _style = value; }
        }
        public override float Price => base.Price + 25F;
    }
}