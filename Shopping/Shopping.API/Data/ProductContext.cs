using Shopping.API.Models;

namespace Shopping.API.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
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
            }
        };
    }
}
