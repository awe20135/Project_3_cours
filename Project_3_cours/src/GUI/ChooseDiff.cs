using Project_3_cours.src.bin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_cours.src.GUI
{
    public partial class ChooseDiff : Form
    {
        public ChooseDiff()
        {
            InitializeComponent();
            World.startGame(new bin.npc.Player(1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            World.chooseDiff(1);
            GUIController.nextWindow(StartForm.Start, new EventForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            World.chooseDiff(2);
            GUIController.nextWindow(StartForm.Start, new EventForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            World.chooseDiff(3);
            GUIController.nextWindow(StartForm.Start, new EventForm());
        }
    }
}
