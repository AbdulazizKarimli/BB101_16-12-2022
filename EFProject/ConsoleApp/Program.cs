using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess;
using Microsoft.EntityFrameworkCore;
#region Create
//Console.WriteLine("Hello, World!");

//AppDbContext context = new();

//Product p1 = new()
//{
//    Name="pro7",
//    Price=250
//};
//Product p2 = new()
//{
//    Name = "pro8",
//    Price = 250
//};
//Product p3 = new()
//{
//    Name = "pro9",
//    Price = 250
//};
//Console.WriteLine(context.Entry(p1).State);
//await context.Products.AddAsync(p1);
//await context.SaveChangesAsync();
//Console.WriteLine(p1.Id);

//await context.AddRangeAsync(p1, p2, p3);
//await context.SaveChangesAsync();

//context.Entry<Product>(p1).State=EntityState.Added;
//await context.SaveChangesAsync();
#endregion

#region Update
//AppDbContext context = new();
//Product product=context.Products.FirstOrDefault(p=>p.Id==1);
//product.Name = "Product1";
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(product).State);

//Product product2 = new()
//{
//    Id = 2,
//    Name = "Product2",
//    Price = 2000
//};

//context.Update(product2);
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(product2).State);
#endregion

#region Delete
//AppDbContext context = new();
//Product product = context.Products.Find(1);
//context.Products.Remove(product);
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(product).State);

//Product product2 = new()
//{
//    Id = 2
//};
//context.Remove(product2);
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(product2).State);

#endregion

#region Select, IEnumerable, IQueryable
//AppDbContext context = new();
//var price = 200;
//var products=context.Products.Where(p=>p.Price>price);
//var products =from product in context.Products 
//              where product.Price > price select product;
//price = 250;
//products.ToList();
//foreach (var product in products)
//{
//    Console.WriteLine(product.Name);
//}
#endregion