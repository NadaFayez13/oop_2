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
        }
    }
}