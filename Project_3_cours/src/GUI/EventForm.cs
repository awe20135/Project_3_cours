using Project_3_cours.src.bin;
using Project_3_cours.src.bin.actions;
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
    public partial class EventForm : Form
    {
        StartForm Start;
        public EventForm()
        {
            InitializeComponent();
            IndicatorProgress.Value = World.getIndicator();
            Random rnd = new Random();
            Event ev;
            do
            {
                ev = new Event(rnd.Next(1, 3));
            } while (!ev.Allow);
            World.startEvent(ev);
            descLabel.Text = World.InProgress.Desc;
            optionLabel1.Text = World.InProgress.Options[0].Desc;
            optionLabel2.Text = World.InProgress.Options[1].Desc;
        }

        private void optionLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Option opt = World.InProgress.Options[0];
            letsNext(opt);
        }

        private void optionLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Option opt = World.InProgress.Options[1];
            letsNext(opt);
        }

        private void letsNext(Option opt)
        {
            opt.doOption();
            if (opt.cardConsist())
            {
                World.Player.Cards.Add(opt.Card);
            }
            if (opt.enemyConsist())
            {
                MessageBox.Show("Oops, you met a monster", "Trouble");
                GUIController.nextWindow(StartForm.Start, new BattleForm(opt));
                return;
            }
            if (World.endEvent())
            {
                GUIController.nextWindow(StartForm.Start, new EventForm());
            }
            else
            {
                MessageBox.Show("Your indicator went down to zero.", "You Loose :(");
                GUIController.nextWindow(StartForm.Start, new StartForm());
            }
        }

        private void optionLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            label.LinkColor = Color.FromName("Salmon");
        }

        private void optionLabel1_MouseLeave(object sender, EventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            label.LinkColor = Color.FromName("Black");
        }
    }
}
