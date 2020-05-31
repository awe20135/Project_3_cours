using Project_3_cours.src.bin.dbNetwork;
using Project_3_cours.src.bin.things;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.npc
{
    class Enemy : NPC
    {
        //internal Item Item { get; set; }
        public string Desc { get; set; }
        internal List<things.Action> Actions { get; set; }

        public Enemy(int id)
        {
            Actions = new List<things.Action>();
            List<string[]> get = DBAction.GetValue(DBQuery.Enemy + id);
            Name = get[0][1];
            Desc = get[0][2];
            HpCount = int.Parse(get[0][4]);
            get = DBAction.GetValue(DBQuery.EnemyActions + id);
            foreach(var mass in get)
            {
                Actions.Add(new things.Action(int.Parse(mass[0])));
            }
        }
       
    }
}
