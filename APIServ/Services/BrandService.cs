using APIServ.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIServ.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandLogic _brandLogic;
        public BrandService(IBrandLogic brandLogic)
        {
            _brandLogic = brandLogic;
        }
        public int InsertBrand(BrandItem brandItem)
        {
            _brandLogic.InsertBrandItem(brandItem);
            return brandItem.Id;
        }
        public List<BrandItem> GetAllBrand()
            {
                return _brandLogic.GetAllBrand();

            }
        public void DeleteBrand(int id)
                {
                    _brandLogic.DeleteBrandItem(id);
                }

        public void UpdateBrand(BrandItem brandItem)
        {
            _brandLogic.UpdateBrandItem(brandItem);

        }
    }
}
