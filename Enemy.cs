using System;
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
        public String SI;
        public String WY;
        public String FriendlyType;

        public Enemy()
        {
            ProfileName = "eNowyProfil";
            WalkSpeed = "1,85";
            DisplayNameOffset = "x|y|z";
            HeadOffset = "x|y|z";
            BodyScaleFactor = "x|y|z";

            WW = "30";
            SI = "2";
            ZR = "30";
            ZY = "4";
            OP = "30";
            WY = "2";
            CH = "30";

            FriendlyType = "0";
        }
    }
}
