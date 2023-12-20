using OrderChallenge.Entities.Enum;
using OrderChallenge.Entities;
using System;

namespace OrderChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameClient, email;
            Client client;
            DateTime birthDate, moment = DateTime.Now;
            int qntItems;
            Order order;
            Product product;
            OrderItem item;
            

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            nameClient = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth Date: ");
            birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("how many items to this order?: ");
            qntItems = int.Parse(Console.ReadLine());

            client = new Client(nameClient, email, birthDate);
            order = new Order(moment, status, client);

            for (int i = 0; i < qntItems; i++)
            {
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                product = new Product(productName, productPrice);
                item = new OrderItem(productQuantity, productPrice, product);
                order.addItem(item);
               
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}