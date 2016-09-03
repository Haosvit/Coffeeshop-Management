using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.WinformControls
{
    public class AlphaImageButton : PictureBox
    {
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            BackColor = Color.White;
            //BackColor = Color.FromArgb(BackColor.A - 100, BackColor.R, BackColor.G, BackColor.B);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.LightGray;
            //BackColor = Color.FromArgb(BackColor.A + 100, BackColor.R, BackColor.G, BackColor.B);
        }


    }
}
