using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfilesGenerator
{
    public class ItemProfile
    {
        public string IdString;
        public string Name;
        public string Type;
        public string Description;
        public string Mesh;
        public string InventoryMaterial;
        public string Mass;
        public string IsPickable;
        public string IsContainer;
        public string NameOffset;
        public string PrizeID;
        public string Price;
		public string HandleOffset;
        public string IloscRzutow;
        public string JakoscRzutow;

        public ItemProfile()
        {
            IdString = "iNowyProfil";
            NameOffset = "x|y|z";
            IsPickable = "false";
            IsContainer = "false";
            Type = "DescribedProfile";
            PrizeID = "";
            Price = "0";
			HandleOffset = "x|y|z";
            IloscRzutow = "1";
            JakoscRzutow = "6";
        }
    }
}
