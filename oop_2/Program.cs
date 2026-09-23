using oop_2;
using System;

namespace oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assignement 1 _ q1
            //DeliveryAddress address1 = new DeliveryAddress("Alex", "Gamal Abdelnasser", 13);
            //DeliveryAddress address2 = address1;

            //address2.City = "aswan";
            //address2.BuildingNumber = 1;

            //Console.WriteLine($"Address 1 (Original): {address1.GetFullAddress()}");
            //Console.WriteLine($"Address 2 (Copied):   {address2.GetFullAddress()}");
            #endregion

            #region Question 6 point a
            //// Create a DeliveryCenter
            //DeliveryCenter center = new DeliveryCenter();
            #endregion

            #region Question 6 points b & c
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Shipment {i + 1} Data");

            //    Console.Write("Tracking Code: ");
            //    string code = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string desc = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int bNum = int.Parse(Console.ReadLine());

            //    DeliveryAddress addr = new DeliveryAddress(city, street, bNum);
            //    Shipment shipment = new Shipment(code, desc, weight, fee, addr);

            //    if (center.AddShipment(shipment))
            //    {
            //        Console.WriteLine("\nShipment added successfully.\n");
            //    }
            //}
            #endregion

            #region Question 6 point d
            //for (int i = 0; i < center.Count; i++)
            //{
            //    center[i].PrintShipment();
            //    Console.WriteLine();
            //}
            #endregion

            #region Question 6 point e, f, g
            //Console.Write("Enter a tracking code to search: ");
            //string searchCode = Console.ReadLine();

            //Shipment foundShipment = center[searchCode];

            //if (foundShipment.TrackingCode != null)
            //{
            //    Console.WriteLine($"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}");
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}
            #endregion

            #region Question 6 point h
            //DeliveryAddress original Addr = new DeliveryAddress("Alex", "Fawzy Moaaz Street", 15);
            //DeliveryAddress copiedAddr = originalAddr;

            //copiedAddr.Street = "Port Saied Street";
            //copiedAddr.BuildingNumber = 20;

            //Console.WriteLine($"Original Address: {originalAddr.GetFullAddress()}");
            //Console.WriteLine($"Copied Address:   {copiedAddr.GetFullAddress()}");
            #endregion

            #region assignment 2 - theoretical Question 1
            //a) What is the difference between a class and a struct?
            // class is reference type, while struct is  value type.
            // this means that when you create nstance of class, it is allocated on the heap and accessed through reference, while instance of struct is allocated on the stack and accessed directly.
            // classes support inheritance and polymorphism, while structs do not.

            //b) Why are classes more suitable than structs for large applications?
            //because they provide more flexibility and functionality than structs.
            //classes can have methods, properties, events, and other members, while structs are limited to fields and methods.
            //classes support inheritance and polymorphism, which allows for code reuse and extensibility.
            //classes can be used with interfaces and abstract classes, which can help to enforce design patterns and best practices in large applications.

            #endregion

            #region assignment 2 - theoretical Question 2

            //a) Which class is the parent class?
            // Shipment 
            //b) Which class is the child class?
            // ExpressShipment
            // c) What members are inherited by ExpressShipment?
            // ExpressShipment inherits the TrackingCode property from Shipment class.
            // d) Why is inheritance better than duplicating the same code in multiple classes?
            // inheritance allows for code reuse and promotes more organized and maintainable code structure.
            // also it enables the child class to inherit and extend the functionality of the parent class, reducing code duplication and improving overall efficiency.

            #endregion

            #region question 5.1,2
            //create DeliveryCenter and read center name from user
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            #endregion
            #region question 5.3,4,5,6
            // read shipment data from user and create instances
            Console.WriteLine("Entering Standard Shipment Data");
             DeliveryAddress addr1 = new DeliveryAddress("Alexandria", "souter Street", 12);
            StandardShipment std = new StandardShipment("1", "Books", 2.5m, 30m, addr1);

            Console.WriteLine("Entering Express Shipment Data");
            DeliveryAddress addr2 = new DeliveryAddress("Cairo", "Tahrir St", 45);
            ExpressShipment exp = new ExpressShipment("2", "Electronics", 1.5m, 50m, addr2, 20m);

            Console.WriteLine("Entering International Shipment Data");
            DeliveryAddress addr3 = new DeliveryAddress("sharkia", "Sheikh Zayed Rd", 101);
            InternationalShipment intl = new InternationalShipment("3", "Gift", 3.0m, 100m, addr3, "vv", 40m);
            #endregion
        }
    }
}