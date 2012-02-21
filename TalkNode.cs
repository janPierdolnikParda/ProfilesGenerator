using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    class TalkNode
    {
        public String ID;
        public List<int> Actions;
        public List<String> Replies;
        public String ActionQuestID;
        public List<String> ActionEdge;
        public String ActionEdgeDialog;
        public String Text;
        public String Duration;
        public String Sound;
        public String Activator;

        public TalkNode()
        {
            ActionEdge = new List<string>();
            ID = "NowyNode";
            Actions = new List<int>();
            Replies = new List<String>();
            ActionQuestID = "";
            //ActionEdge = "";
            Duration = "3,0";
            Sound = "";
            Activator = "";
        }
    }
}
