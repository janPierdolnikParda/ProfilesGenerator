﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    class TalkReaction
    {
        public string ID;
        public List<String> Edges;

        public TalkReaction()
        {
            ID = "NowaReakcja";
            Edges = new List<String>();
        }
    }
}
