using System;

namespace Thorn_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
             bool Breakout = false;
            Shipper shipper = new Shipper();
            do
            {
                Console.Clear();
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6.Compute Shipping Charges");
                ConsoleKeyInfo Selection = Console.ReadKey();
               
                if(Selection.Key == ConsoleKey.D1|| Selection.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    IShippable bikes = new Bicycles(9.50m, "Bicycle");
                    shipper.Add(bikes);
                    Console.WriteLine(shipper.ShipperConfirm());
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D2 || Selection.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    IShippable lawnMower = new Lawn_Mowers(24.00m, "Lawn Mower");
                    shipper.Add(lawnMower);
                    Console.WriteLine(shipper.ShipperConfirm());
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D3 || Selection.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    IShippable baseballglove = new Baseball_Gloves(3.23m, "Baseball Glove");
                    shipper.Add(baseballglove);
                    Console.WriteLine(shipper.ShipperConfirm());
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D4 || Selection.Key == ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    IShippable cracka = new Crackers(.57m, "Crackers");
                    shipper.Add(cracka);
                    Console.WriteLine(shipper.ShipperConfirm());
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D5 || Selection.Key == ConsoleKey.NumPad5)
                {
                    Console.Clear();
                    shipper.List();
                    shipper.Reset();
                    Console.WriteLine(shipper.BicycleOutput());
                    Console.WriteLine(shipper.GloveOutput());
                    Console.WriteLine(shipper.MowerOutput());
                    Console.WriteLine(shipper.CrackerOutput());
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D6 || Selection.Key == ConsoleKey.NumPad6)
                {
                    Console.Clear();
                    Console.WriteLine(shipper.HowMuch());
                    Console.WriteLine("Press any key to close...");
                    Console.ReadKey();
                    Breakout = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please press the 1-6 key. ");
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                    Breakout = false;
                }
            } while (Breakout == false);
        }
        
    }
}
