using System;

namespace oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assignement 1 _ q1
            DeliveryAddress address1 = new DeliveryAddress("Alex", "Gamal Abdelnasser", 13);
            DeliveryAddress address2 = address1;

            address2.City = "aswan";
            address2.BuildingNumber = 1;

            Console.WriteLine($"Address 1 (Original): {address1.GetFullAddress()}");
            Console.WriteLine($"Address 2 (Copied):   {address2.GetFullAddress()}");
            #endregion

            #region Question 6 point a
            // Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();
            #endregion

            #region Question 6 points b & c
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i + 1} Data");

                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int bNum = int.Parse(Console.ReadLine());

                DeliveryAddress addr = new DeliveryAddress(city, street, bNum);
                Shipment shipment = new Shipment(code, desc, weight, fee, addr);

                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("\nShipment added successfully.\n");
                }
            }
            #endregion

            #region Question 6 point d
            for (int i = 0; i < center.Count; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine();
            }
            #endregion

            #region Question 6 point e, f, g
            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment.TrackingCode != null)
            {
                Console.WriteLine($"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }
            #endregion

            #region Question 6 point h
            DeliveryAddress originalAddr = new DeliveryAddress("Alex", "Fawzy Moaaz Street", 15);
            DeliveryAddress copiedAddr = originalAddr;

            copiedAddr.Street = "Port Saied Street";
            copiedAddr.BuildingNumber = 20;

            Console.WriteLine($"Original Address: {originalAddr.GetFullAddress()}");
            Console.WriteLine($"Copied Address:   {copiedAddr.GetFullAddress()}");
            #endregion
        }


    }
}