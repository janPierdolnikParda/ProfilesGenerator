﻿using System;
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
        public String Sound;
        public String Duration;
        public bool isEnding = false;

        public TalkReply()
        {
            ID = "NowyReply";
            ReactionID = "";
            Duration = "3,0";
            Sound = "";
        }
    }
}
