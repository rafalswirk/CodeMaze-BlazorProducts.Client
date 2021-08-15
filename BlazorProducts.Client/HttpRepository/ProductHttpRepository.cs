using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public class ProductHttpRepository : IProductHttpRepository
    {
        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
