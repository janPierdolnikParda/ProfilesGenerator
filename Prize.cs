using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    public class Prize
    {
        public List<String> Itemy;
        public String Gold;
        public String EXP;
        public String PrizeID;

        public Prize()
        {
            Itemy = new List<String>();
            PrizeID = "pNowyPrize";
            Gold = "0";
            EXP = "0";
        }
    }
}
