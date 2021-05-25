using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Inventory
{
    class Baseball_Gloves : IShippable
    {
        string BaseBallGloves;
        decimal shipCost;
        public decimal ShipCost
        {
            get { return shipCost; }
        }
        public string Product
        {
            get { return BaseBallGloves; }
        }
        public Baseball_Gloves(decimal Shipcost, string bazeballgloves)
        {
            shipCost = Shipcost;
            BaseBallGloves = bazeballgloves;
        }
    }
}
