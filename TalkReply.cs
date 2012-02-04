using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    class TalkReply
    {
        public String ID;
        public String ReactionID;
        public String Text;
        public bool isEnding;

        public TalkReply()
        {
            ID = "rNowyReply";
        }
    }
}
