using Project_3_cours.src.bin;
using Project_3_cours.src.bin.actions;
using Project_3_cours.src.bin.things;
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
    public partial class BattleForm : Form
    {
        static Option Opt;
        static Panel panel;
        static List<Card> hand;
        static List<Card> discharge;
        List<Card> stack;
        int locationX;

        public BattleForm(Option opt)
        {
            stack = new List<Card>(World.Player.Cards);
            discharge = new List<Card>();
            hand = new List<Card>();
            Opt = opt;
            InitializeComponent();
            locationX = 0;
            panel = panel1;
            refreshInfo();
            inputCard();
        }

        public void clickCard(int ID)
        {
            if (!World.Player.mpIsEmpty())
            {

                if (World.Player.useMP(hand[ID].ManaCost))
                {
                    hand[ID].useCard(Opt.Enemy);
                    discard(ID);
                    refreshInfo();
                    if (Opt.Enemy.isDead())
                    {
                        MessageBox.Show("You defided the monster", "Congratulation!!!");
                        GUIController.nextWindow(StartForm.Start, new EventForm());
                    }
                }
                else
                {
                    MessageBox.Show("You haven`t MP for this card");
                }
            }
            else
            {
                MessageBox.Show("Your mp is empty", "Warning");
            }
        }

        void refreshInfo()
        {
            enNameLabel.Text = Opt.Enemy.Name != "" ? Opt.Enemy.Name : "Name undifined";
            enHpLabel.Text = $"{Opt.Enemy.HpCount}";
            plHpLabel.Text = $"{World.Player.HpCount} / 100";
            plMpLabel.Text = $"{World.Player.getCurrentMP()} / {World.Player.MPCount}";
        }

        void inputCard()
        {
            for (int i = 0; i < 3; i++)
            {
                if (stack.Count == 0)
                {
                    stack.AddRange(discharge);
                    shuffle();
                }
                hand.Add(stack[i]);
                CardElement el = new CardElement(i, this);
                el.setName(hand[i].Name);
                el.setDesc(hand[i].Desc + "\n" + hand[i].Effect);
                el.Location = new Point(locationX, el.Location.Y);
                panel1.Controls.Add(el);
                locationX += 65;
            }
        }

        void discard(int id)
        {
            discharge.Add(hand[id]);
            hand.RemoveAt(id);
            panel.Controls.RemoveAt(id);
        }

        void shuffle()
        {
            List<Card> shuffling = new List<Card>();
            List<int> pos = new List<int>();
            for (int i = 0; i < stack.Count; i++)
            {
                pos.Add(i);
            }
            for (int i = 0; i < pos.Count; i++)
            {
                Random rnd = new Random();
                int next = rnd.Next(0, pos.Count);
                shuffling.Add(stack[pos[next]]);
                pos.RemoveAt(next);
            }
            stack = shuffling;
            locationX = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int afHP = World.Player.HpCount;
            Opt.Enemy.Actions[rnd.Next(Opt.Enemy.Actions.Count)].doAction(World.Player);
            int bfHP = World.Player.HpCount;
            MessageBox.Show($"Еhe enemy did you damage in the amount of {afHP - bfHP}", "Enemy attacked");
            for (int i = 0;i < panel1.Controls.Count; i++)
            {
                discard(i);
            }
            refreshInfo();
            World.Player.restoreMP();
            inputCard();
            locationX = 0;
        }
    }
}
