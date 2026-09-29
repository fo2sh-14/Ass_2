namespace Ass_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Answer Question 1 
            // a :              Class                            Struct                     
            //                 Ref Type                         Value Type                  
            // storid in         heap                              stack
            // Inheritance      support                          not support

            // b : because is suuport all principles of OOP
            #endregion

            #region Question 2
            // a : parent ==> Shipment 
            // b : child ==> ExpressShipment 
            // c : members ==> TrackingCode Property
            // d : because not repeat code and update easier 
            #endregion

            #region Part 2 Practical
            // 1. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // 2. Read the center name
            Console.Write("Enter Center Name: ");
            center.CenterName = Console.ReadLine();
                  
            // 3. Create one StandardShipment
            Console.WriteLine("\n--- Standard Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(city1, street1, buildingNumber1);

            StandardShipment standard =
                new StandardShipment(
                    trackingCode1,
                    description1,
                    weight1,
                    deliveryFee1,
                    address1
                );


            // 4. Create one ExpressShipment
            Console.WriteLine("\n--- Express Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber2 = int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(city2, street2, buildingNumber2);

            ExpressShipment express =
                new ExpressShipment(
                    trackingCode2,
                    description2,
                    weight2,
                    deliveryFee2,
                    address2,
                    extraFee
                );


            // 5. Create one InternationalShipment
            Console.WriteLine("\n--- International Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber3 = int.Parse(Console.ReadLine());

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(city3, street3, buildingNumber3);

            InternationalShipment international =
                new InternationalShipment(
                    trackingCode3,
                    description3,
                    weight3,
                    deliveryFee3,
                    address3,
                    customsFee
                );


            // 7. Add the shipments to the DeliveryCenter
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            // 8. Print all shipments
            Console.WriteLine("\n==============================");
            Console.WriteLine("      ALL SHIPMENTS"); 
            Console.WriteLine("==============================");

            center.PrintAllShipments();


            // 9. Search for a shipment using tracking code indexer
            Console.Write("\nEnter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            Shipment searchedShipment = center[searchCode]; // Indexer

            if (searchedShipment != null)
            {
                Console.WriteLine("\nShipment Found:");
                Console.WriteLine(searchedShipment);
            }
            else
            {
                Console.WriteLine("\nShipment Not Found.");
            }


            // 10. Remove one shipment using its tracking code
            Console.Write("\nEnter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();

            Shipment shipmentToRemove = center[removeCode];

            if (shipmentToRemove != null)
            {
                center.RemoveShipment(shipmentToRemove);
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }


            // 11. Print remaining shipments
            Console.WriteLine("\n==============================");
            Console.WriteLine("   REMAINING SHIPMENTS");
            Console.WriteLine("==============================");

            center.PrintAllShipments();
            #endregion

        }
    }
}
