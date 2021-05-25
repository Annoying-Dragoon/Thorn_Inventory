using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Inventory
{
    class Crackers : IShippable
    {
        private string crackers;
        private decimal shipCost;
        public decimal ShipCost
        {
            get { return shipCost; }
        }
        public string Product
        {
            get { return crackers; }
        }
        public Crackers(decimal shipcost, string qwackers)
        {
            shipCost = shipcost;
            crackers = qwackers;
        }
    }   
}
