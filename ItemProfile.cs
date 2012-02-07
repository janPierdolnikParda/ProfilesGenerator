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
        public string IsEquipment;
        public string IsContainer;
        public string NameOffset;
        public string PrizeID;

        public ItemProfile()
        {
            IdString = "iNowyProfil";
            NameOffset = "x|y|z";
            IsPickable = "false";
            IsEquipment = "false";
            IsContainer = "false";
            Type = "DescribedProfile";
            PrizeID = "";
        }
    }
}
