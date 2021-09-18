using BlazorProducts.Client.HttpRepository;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class Products
    {
        public List<Product> ProductList { get; set; } = new List<Product>();
        public Metadata Metadata { get; set; } = new Metadata();
        private ProductParameters _productParameters = new ProductParameters() { PageSize = 4 };
        [Inject]
        public IProductHttpRepository ProductRepo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var pagingResponse = await ProductRepo.GetProducts(_productParameters);
            ProductList = pagingResponse.Items;
            Metadata = pagingResponse.MetaData;
            foreach (var product in ProductList)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
