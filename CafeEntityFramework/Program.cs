// See https://aka.ms/new-console-template for more information

using CafeEntityFramework;

using (var context = new AppContextDb())
{
    Console.WriteLine("Enter Name of Coffee");
    var name = Console.ReadLine();
    Console.WriteLine("Enter the price");
    var price = decimal.Parse(Console.ReadLine());

    var coffee = new Coffee()
    {
        
        Id = 1,
        
        CoffeeName = name,
        Price = price
    };
    context.Coffees.Add(coffee);
    context.SaveChanges();

    var allcoffees = context.Coffees.ToList();

}