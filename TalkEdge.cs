using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    class TalkEdge
    {
        public String ID;
        public String Node;
        public String ConditionQuestID;
        public bool FirstTalk;
        public bool GotQuest;
        public bool IsQuestDone;
        public bool IsQuestFinished;
        public bool GotGold;
        public String GoldRequired;

        public TalkEdge()
        {
            ID = "NowyEdge";
            FirstTalk = false;
            GotQuest = false;
            IsQuestDone = false;
            IsQuestFinished = false;
            GotGold = false;
            ConditionQuestID = "";
            GoldRequired = "0";
        }
    }
}
