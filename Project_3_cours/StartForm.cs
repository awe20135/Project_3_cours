using Project_3_cours.src.bin.actions;
using Project_3_cours.src.bin.npc;
using Project_3_cours.src.bin.things;
using Project_3_cours.src.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_cours
{
    public partial class StartForm : Form
    {
        static public StartForm Start;
        public StartForm()
        {
            InitializeComponent();
            if(Start==null)
                Start = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIController.nextWindow(Start, new ChooseDiff());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start.Close();
        }

        private void StartForm_ResizeEnd(object sender, EventArgs e)
        {
            int fontSize = (int)(0.0417 * Size.Width /*0.0245 * (Size.Height+Size.Width)*/);

            Font resize = new Font(label1.Font.Name, fontSize, label1.Font.Style, label1.Font.Unit);
            label1.Font = resize;
            button1.Font = resize;
            button2.Font = resize;

            int labelNewX = (int)(0.072 * Size.Width);
            int labelNewY = (int)(0.139 * Size.Height);
            label1.Location = new Point(labelNewX, labelNewY);

            int buttonNewX = (int)(0.314 * Size.Width);
            int button1NewY = (int)(0.381 * Size.Height);
            int button2NewY = (int)(0.572 * Size.Height);
            button1.Location = new Point(buttonNewX, button1NewY);
            button2.Location = new Point(buttonNewX, button2NewY);

            int buttonNewWidth = (int)(0.341 * Size.Width);
            int buttonNewHeight = (int)(0.119 * Size.Height);
            button1.Size = new Size(buttonNewWidth, buttonNewHeight);
            button2.Size = new Size(buttonNewWidth, buttonNewHeight);
        }

    }
}
