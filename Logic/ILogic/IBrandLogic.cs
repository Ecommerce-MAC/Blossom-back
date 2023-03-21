using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBrandLogic
    {
        List<BrandItem> GetAllBrand();
        int InsertBrandItem(BrandItem brandItem);
        void UpdateBrandItem(BrandItem brandItem);
        void DeleteBrandItem(int id);
    }
}
