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

        public TalkEdge()
        {
            ID = "eNowyEdge";
            FirstTalk = false;
            GotQuest = false;
            IsQuestDone = false;
            IsQuestFinished = false;
            ConditionQuestID = "pierwszy";
        }
    }
}
