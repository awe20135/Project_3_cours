using Project_3_cours.src.bin.actions;
using Project_3_cours.src.bin.npc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin
{
    static class World
    {
        static int indicator = 50;

        public static int Diff { get; set; }
        internal static Event InProgress { get; set; }
        internal static List<Event> Events { get; set; } = new List<Event>();
        public static Player Player{ get; set; }


        static public bool chooseDiff(int diff)
        {
            Diff = diff;
            return true;
        }

        static bool lossCheck()
        {
            return indicator > 0;
        }

        static public void changeInd(int changesValue)
        {
            indicator += changesValue;
            if (indicator > 100)
                indicator = 100;
            if (indicator < 0)
                indicator = 0;
        }

        static public int getIndicator()
        {
            return indicator;
        }

        static public void startEvent(Event now)
        {
            if(now.Allow)
                InProgress = now;
        }

        static public bool endEvent()
        {
            Events.Add(InProgress);
            InProgress = null;
            return lossCheck();
        }

        static public void startGame(Player pl)
        {
            Player = pl;
        }
    }
}
