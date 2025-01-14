using System;
using System.Collections.Generic;
using EnumsPlusCompositions;
using EnumsPlusCompositions.Entities;
using System.Globalization;


namespace EnumsPlusCompositions {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter Client data: ");
            Console.WriteLine("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many Items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++) {
                Console.WriteLine($"Ener #{i} item data: ");
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                
                Product product = new Product(productName, price);

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order summary: ");
            Console.WriteLine(order);


        }
    }
}