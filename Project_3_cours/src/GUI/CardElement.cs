using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_cours.src.GUI
{
    public partial class CardElement : UserControl
    {
        BattleForm Bf;
        public int Id { get; set; }
        public CardElement(int id, BattleForm bf)
        {
            Id = id;
            Bf = bf;
            InitializeComponent();
        }

        public void setName(string name)
        {
            cardNameLabel.Text = name;
        }

        public void setDesc(string desc)
        {
            descCardBox.Text = desc;
        }

        public void setImg(Image img)
        {
            cardImgBox.BackgroundImage = img;
        }

        private void CardElement_Click(object sender, EventArgs e)
        {
            Bf.clickCard(Id);
        }

        private void CardElement_MouseMove(object sender, MouseEventArgs e)
        {
            Location = new Point(Location.X, Location.Y + 50);
        }

        private void CardElement_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
