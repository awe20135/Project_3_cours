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
    class Item
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Effect { get; set; }
        public Icon Img { get; set; }

       public Item(int id)
        {
            //List<string[]> get = DBAction.GetValue(DBQuery.Item + id);
        }

        public void doEffect(Player player)
        {
            
        }
        
    }
}
