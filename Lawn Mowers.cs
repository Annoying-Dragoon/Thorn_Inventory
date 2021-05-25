using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Inventory
{
    class Lawn_Mowers : IShippable
    {
        private string LawnMowers;
        private decimal shipCost;
        public decimal ShipCost
        {
            get { return shipCost; }
        }
        public string Product
        {
            get { return LawnMowers; }
        }
        public Lawn_Mowers(decimal Shipcost, string lwnmwrs)
        {
            LawnMowers = lwnmwrs;
            shipCost = Shipcost;
        }
    }
}
