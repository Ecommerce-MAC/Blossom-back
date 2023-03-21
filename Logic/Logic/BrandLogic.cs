using Data;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BrandLogic : BaseContextLogic, IBrandLogic
    {
        public BrandLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertBrandItem(BrandItem brandItem)
        {
            _serviceContext.Brand.Add(brandItem);
            _serviceContext.SaveChanges(); 
            return brandItem.Id;
        }
        public List<BrandItem> GetAllBrand()
            {
                return _serviceContext.Set<BrandItem>().ToList();
            }
        public void UpdateBrandItem(BrandItem brandItem)
        {
            _serviceContext.SaveChanges();
        }
        public void DeleteBrandItem(int id)
        {
           var brandToDelete = _serviceContext.Set<BrandItem>()
             .Where(u => u.Id == id).First();

            brandToDelete.IsActive = false;

            _serviceContext.SaveChanges();

         }
       

    }
    
}

  

    


  

 