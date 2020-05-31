using Project_3_cours.src.bin.dbNetwork;
using Project_3_cours.src.bin.npc;
using Project_3_cours.src.bin.things;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.actions
{
    public class Option
    {
        public string Desc { get; set; }
        public int Reward { get; set; }
        internal Enemy Enemy { get; set; }
        internal Card Card { get; set; }

        public Option(int id, bool isGood)
        {
            List<string[]> get;
            if (isGood)
            {
                get = DBAction.GetValue(DBQuery.GoodOption + id);
                if (get[0][3] != "")
                    Card = new Card(int.Parse(get[0][3]));
            }
            else
            {
                get = DBAction.GetValue(DBQuery.BadOption + id);
                if (get[0][3] != "")
                    Enemy = new Enemy(int.Parse(get[0][3]));
            }
            Desc = get[0][1];
            Reward = int.Parse(get[0][2]);
        }

        public bool enemyConsist()
        {
            return Enemy != null;
        }

        public bool cardConsist()
        {
            return Card != null;
        }

        public void doOption()
        {
            World.changeInd(Reward);
        }

        public bool haveEnemy()
        {
            return Enemy != null;
        }

        public void startBattle(NPC en)
        {
            en = Enemy;
        }
    }
}
