using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.npc
{
    public abstract class NPC
    {
        public string Name { get; set; }
        public int HpCount { get; set; }
        public int Poison { get; set; }

        public void takeDamage(int damage)
        {
            HpCount -= damage;
        }

        public void healHP(int heal)
        {
            HpCount += heal;
        }

        public void addPoison(int poisonCount)
        {
            Poison += poisonCount;

        }

        public void decresePoison()
        {
            if (Poison > 0)
            {
                takeDamage(Poison);
                Poison--;
            }
        }

        public bool isDead()
        {
            return HpCount <= 0;
        }
    }
}
