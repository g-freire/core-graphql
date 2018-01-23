using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;

namespace aspnetcoregraphql.Data
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>{
                new Product()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Petfun",
                    Cardbrand = "Visa",
                    MerchantReference = 273280056000000,
                    MCC = 25

                },
                new Product()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Amanda Gas",
                    Cardbrand = "Visa",
                    MerchantReference = 158808235000000,
                    MCC = 5

                },
                new Product()
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Casa da Racao",
                    Cardbrand = "Master",
                    MerchantReference = 164239266000000,
                    MCC = 78

                },
                new Product()
                {
                    Id = 4,
                    CategoryId = 1,
                    Name = "Eletronica Goncalves",
                    Cardbrand = "Elo",
                    MerchantReference = 139095643000000,
                    MCC = 53

                }



            };
        }

        public Task<Product> GetProductAsync(int id)
        {
            return Task.FromResult(_products.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(_products);
        }
       
        public Task<List<Product>> GetProductsWithByCategoryIdAsync(int categoryId)
        {
            return Task.FromResult(_products.Where(x => x.CategoryId == categoryId).ToList());
        }
    }
}