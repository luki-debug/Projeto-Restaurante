using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    class MyConfig
    {
        public void MyconfigButton(Button button)
        {
            button.BackColor = Color.Black;
            button.FlatAppearance.MouseDownBackColor = Color.Black;
            button.FlatAppearance.MouseOverBackColor = Color.Orange;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.White;
        }

    }
}
