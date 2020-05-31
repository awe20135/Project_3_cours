using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_cours.src.GUI
{
    static class GUIController
    {
        static public void nextWindow(Form thisF, Form newF)
        {
            thisF.Controls.Clear();
            int count = newF.Controls.Count;
            for (int i = 0; i < count; i++)
            {
                thisF.Controls.Add(newF.Controls[0]);
            }
        }
    }
}
