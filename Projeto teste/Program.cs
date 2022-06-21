// See https://aka.ms/new-console-template for more information
using Projeto_teste.Entities;
using Projeto_teste.Entities.Enums;

Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status");
OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, date);
Order order = new Order(DateTime.Now, Status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string nameProduct = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(nameProduct,price);
    OrderItem item = new OrderItem(quantity,price,product);

    order.AddItem(item);
}


Console.WriteLine();

Console.WriteLine("Order summary");
Console.WriteLine(order);