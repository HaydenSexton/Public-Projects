using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public interface ICard
    {
        string Name { get; }
        System.Drawing.Image Image { get; }
        double Value { get; }

        void ShowCard(PictureBox pictureBox, Label label);
    }
}
