using Project_3_cours.src.bin.dbNetwork;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.actions
{
    class Event
    {
        public string Desc { get; set; }
        public int Diff { get; set; }
        public Image Img { get; set; }
        public bool Allow { get; set; }
        internal List<Option> Options { get; set; }

        public Event(int id)
        {
            Options = new List<Option>();
            List<string[]> get = DBAction.GetValue(DBQuery.Event + id);
            Diff = int.Parse(get[0][1]);
            Desc = get[0][3];
            get = DBAction.GetValue(DBQuery.EventOptions + id);
            Options.Add(new Option(int.Parse(get[0][0]), true));
            Options.Add(new Option(int.Parse(get[0][1]), false));
            Allow = checkAllow();
        }

        bool checkAllow()
        {
            return Diff <= World.Diff;
        }
    }
}
