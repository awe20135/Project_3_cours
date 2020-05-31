using Project_3_cours.src.bin.npc;
using Project_3_cours.src.bin.dbNetwork;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.things
{
    class Card
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ManaCost { get; set; }
        public string Effect { get; set; }
        public Icon Img { get; set; }

        public Card(int id)
        {
            List<string[]> get = DBAction.GetValue(DBQuery.Card + id);
            Name = get[0][1];
            Desc = get[0][2];
            Effect = get[0][4];
            int mana=-1;
            int.TryParse(get[0][5], out mana);
            ManaCost = mana;
        }

       

        public void useCard(NPC target)
        {
            string[] devid = Effect.Split(':');
            int num = 0;
            int.TryParse(devid[1], out num);
            switch (devid[0])
            {
                case "DD":
                    target.takeDamage(num);
                    break;
          
                case "H":
                    World.Player.healHP(num);
                    break;

                case "P":
                    target.addPoison(num);
                    break;
            }

            target.decresePoison();
        }

    }
}
