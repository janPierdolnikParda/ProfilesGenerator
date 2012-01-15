using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    public class Character
    {
        public String DisplayName;
        public String ProfileName;
        public String BodyMass;
        public String MeshName;
        public String WalkSpeed;
        public String DisplayNameOffset;
        public String HeadOffset;
        public String BodyScaleFactor;
        public String Type;

        public Character()
        {
            ProfileName = "cNowyProfil";
            WalkSpeed = "1,85";
            DisplayNameOffset = "x|y|z";
            HeadOffset = "x|y|z";
            BodyScaleFactor = "x|y|z";
            Type = "DescribedProfile";
        }
    }
}
