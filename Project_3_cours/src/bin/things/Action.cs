using Project_3_cours.src.bin.dbNetwork;
using Project_3_cours.src.bin.npc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.things
{
   
    class Action
    { 
        public string Desc { get; set; }
        public string Effect { get; set; }
        public Image Img { get; set; }
        
        public Action(int id)
        {
            List<string[]> get = DBAction.GetValue(DBQuery.Action + id);
            Desc = get[0][1];
            Effect = get[0][3];
        }

        public void doAction(NPC target)
        {
            string[] devide = Effect.Split(':');
            int num = -1;
            int.TryParse(devide[1], out num);
            switch (devide[0])
            {
                case "DD":
                    target.takeDamage(num);
                    break;
            }
        }
    }
}
