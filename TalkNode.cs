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
        public String ActionEdge;
        public String ActionEdgeDialog;
        public String Text;

        public TalkNode()
        {
            ID = "nNowyNode";
            Actions = new List<int>();
            Replies = new List<String>();
        }
    }
}
