using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities.Entities;
using Logic.ILogic;


namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }


        public List<ProductItem> GetAllProducts()
        {
            //filtrar por IsActive
            return _serviceContext.Set<ProductItem>()
                .Where(p => p.IsActive == true).ToList();
        }
        public int InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
            return productItem.Id;
        }

        public void UpdateProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);
            _serviceContext.SaveChanges();
        }


        public void DeleteProductItem(int id)
        {
            var productToDelete = _serviceContext.Set<ProductItem>()
             .Where(x => x.Id == id).First();
            productToDelete.IsActive = false;
            _serviceContext.SaveChanges();

        }
        public ProductItem GetProductById(int Id)
        {
            return _serviceContext.Set<ProductItem>().FirstOrDefault(p => p.Id == Id);
        }

    }
}
