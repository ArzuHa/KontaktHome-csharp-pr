using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontaktHome.Core.Exstensions
{
    static partial class GetCurretnRow
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        internal static void RoundControl(this Control control,int width,int height,int nWidthEllipse, int nHeightEllipse)
        { 
          control.Region = Region.FromHrgn(GetCurretnRow.CreateRoundRectRgn(0, 0, width, height, nWidthEllipse, nHeightEllipse));
        }
    }
}
