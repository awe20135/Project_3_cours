using Project_3_cours.src.bin.dbNetwork;
using Project_3_cours.src.bin.things;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.npc
{
    class Player : NPC
    {
        int currentMP;
        public int MPCount { get; set; }
        internal List<Card> Cards { get; set; }
        //internal List<Item> Items { get; set; }

        public Player(int id)
        {
            Cards = new List<Card>();
            List<string[]> get = DBAction.GetValue(DBQuery.Player + id);
            HpCount = int.Parse(get[0][1]);
            MPCount = int.Parse(get[0][2]);
            get = DBAction.GetValue(DBQuery.PlayerCards + id);
            foreach(var mass in get)
            {
                Cards.Add(new Card(int.Parse(mass[0])));
            }
            restoreMP();
        }

        public void restoreMP()
        {
            currentMP = MPCount;
        }

        public int getCurrentMP()
        {
            return currentMP;
        }

        public bool useMP(int cost)
        {
            if (currentMP - cost >= 0)
            {
                currentMP -= cost;
                return true;
            }
            return false;
        }

        public bool mpIsEmpty()
        {
            return currentMP == 0;
        }

    }
}
