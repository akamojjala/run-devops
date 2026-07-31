using MongoDB.Driver;
using Shopping.API.Models;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            Console.WriteLine($"Conn: {configuration["DatabaseSettings:ConnectionString"]}, DB: {configuration["DatabaseSettings:DatabaseName"]}, Coll: {configuration["DatabaseSettings:CollectionName"]}");
            SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
        private void SeedData(IMongoCollection<Product> products)
        {
            bool productsExist = products.Find(p => true).Any();
            if (!productsExist)
                products.InsertManyAsync(PreConfiguredProducts);
        }

        public static readonly List<Product> PreConfiguredProducts = new List<Product>
        {
            new Product(){
                Name="Iphone X",
                Category="Smart Phone",
                Description="This phone is apple",
                ImageFile="product-1.png",
                Price=100.00m
            },
            new Product(){
                Name="Samsung 10",
                Category="Smart Phone",
                Description="This phone is Samsung",
                ImageFile="product-2.png",
                Price=102.00m
            },
            new Product(){
                Name="LG G7",
                Category="Home Kitchen",
                Description="This phone is Biggest",
                ImageFile="product-6.png",
                Price=110.00m
            },
            new Product(){
                Name="HP Pavilion",
                Category="Home Laptop",
                Description="This laptop is Biggest",
                ImageFile="product-7.png",
                Price=210.00m
            }
        };
    }
}
