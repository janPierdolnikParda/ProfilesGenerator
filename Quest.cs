using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    class Quest
    {
        public String ID;
        public String Name;
        public String PrizeID;
        public Dictionary<String, int> Items;
        public Dictionary<String, int> Enemies;

        public Quest()
        {
            Items = new Dictionary<String, int>();
            Enemies = new Dictionary<String, int>();
            ID = "qNowyQuest";
        }
    }
}
