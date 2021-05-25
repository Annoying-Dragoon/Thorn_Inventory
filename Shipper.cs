using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Inventory
{
    class Shipper
    {
        private int Bikes = 0;
        private int crackers = 0;
        private int baseballglove = 0;
        private int lawnmowers = 0;
        private IShippable[] Shipment = new IShippable[10];
        private int i = 0;
        private IShippable Ship;
        private string[] Output = new string[4];
        public void Add(IShippable shippable)
        {
            Ship = shippable;
            Shipment[i] = shippable;
            i++;
            
        }
        public void List()
        {
            for (int A = 0; A < 10; A++)
            {
                if (Shipment[A] != null)
                {
                    if (Shipment[A].Product == "Bicycle")
                    {
                        Bikes = Bikes + 1;
                    }
                }
            }
            for (int A = 0; A < 10; A++)
            {
                if (Shipment[A] != null)
                {
                    if (Shipment[A].Product == "Crackers")
                    {
                        crackers = crackers + 1;
                    }
                }
            }

            for (int A = 0; A < 10; A++)
            {
                if (Shipment[A] != null)
                {
                    if (Shipment[A].Product == "Baseball Glove")
                    {
                        baseballglove = baseballglove + 1;
                    }
                }
            }
            for (int A = 0; A < 10; A++)
            {
                if (Shipment[A] != null)
                {
                    if (Shipment[A].Product == "Lawn Mower")
                    {
                        lawnmowers = lawnmowers + 1;
                    }
                }
            }



                    if (IsPlural(Bikes) == true)
            {
                Output[0] = Bikes + " Bicylces";
            }
            else
            {
                Output[0] = Bikes + " Bicycle";
            }
            if (IsPlural(baseballglove) == true)
            {
                Output[1] = baseballglove + " Baseball Gloves";
            }
            else
            {
                Output[1] = baseballglove + " Baseball Glove";
            }
            if (IsPlural(lawnmowers) == true)
            {
                Output[2] = lawnmowers + " Lawn Mowers";
            }
            else
            {
                Output[2] = lawnmowers + " Lawn Mower";
            }
            if (IsPlural(crackers) == true)
            {
                Output[3] = crackers + " Crackers";
            }
            else
            {
                Output[3] = crackers + " Crackers";
            }
        }
        public string ShipperConfirm()
        {
            return "1 " + Ship.Product + " has been added.";
        }
        public bool IsPlural(decimal productamount)
        {
            if(productamount>1 || productamount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
       public string BicycleOutput()
        {
            return Output[0];
        }
        public string GloveOutput()
        {
            return Output[1];
        }
        public string MowerOutput()
        {
            return Output[2];
        }
        public string CrackerOutput()
        {
            return Output[3];
        }
        public void Reset()
        {
         lawnmowers = 0;
         Bikes = 0;
         crackers = 0;
         baseballglove = 0;
        }
        public string HowMuch()
        {
             decimal Total_Cost = 0;
           for(int C = 0; C<10; C++)
           {
                if (Shipment[C] != null)
                {
                    Total_Cost = Shipment[C].ShipCost + Total_Cost;
                }
           }
            return "Total shipping cost for this order is " + string.Format("{0:C}", Total_Cost);
        }
    }

}
