﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    public class Enemy
    {
        public String DisplayName;
        public String ProfileName;
        public String BodyMass;
        public String MeshName;
        public String WalkSpeed;
        public String DisplayNameOffset;
        public String HeadOffset;
        public String BodyScaleFactor;
        public String ZasiegWzroku;
        public String ZasiegOgolny;
        public String WW;
        public String ZR;
        public String ZY;
        public String OP;
        public String CH;
        public String K;
		public String ODP;
		public String Ataki;
        public String FriendlyType;
        public String DropPrize;
        public String IloscRzutow;
        public String JakoscRzutow;
        public String ContactDistance;

        public Enemy()
        {
            ProfileName = "eNowyProfil";
            WalkSpeed = "1,85";
            DisplayNameOffset = "x|y|z";
            HeadOffset = "x|y|z";
            BodyScaleFactor = "x|y|z";

            WW = "20";
            K = "20";
            ZR = "20";
            ZY = "4";
            OP = "20";
            ODP = "20";
            CH = "20";
			Ataki = "1";
            IloscRzutow = "0";
            JakoscRzutow = "0";
            ContactDistance = "1";

            FriendlyType = "0";
            DropPrize = "";
        }
    }
}
