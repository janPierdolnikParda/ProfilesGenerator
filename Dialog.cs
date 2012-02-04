using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    class Dialog
    {
        public String ID;
        public List<TalkReaction> Reactions;
        public List<TalkNode> Nodes;
        public List<TalkEdge> Edges;
        public List<TalkReply> Replies;

        public Dialog()
        {
            ID = "dNowyDialog";
            Reactions = new List<TalkReaction>();
            Nodes = new List<TalkNode>();
            Edges = new List<TalkEdge>();
            Replies = new List<TalkReply>();
        }
    }
}
