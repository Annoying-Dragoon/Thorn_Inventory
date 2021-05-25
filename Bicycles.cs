using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Inventory
{
    
    class Bicycles : IShippable
    {
        private string bicycles;
        private decimal shipCost;
        public decimal ShipCost
        {
           get { return shipCost; }
        }
        public string Product
        {
            get { return bicycles; }
        }
        public Bicycles( decimal ShipCost, string Bikes)
        {
            bicycles = Bikes;
            shipCost = ShipCost;
        }
    }
}
