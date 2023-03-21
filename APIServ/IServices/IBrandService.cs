
using Entities.Entities;

namespace APIServ.IServices
{
    public interface IBrandService
    {
        List<BrandItem> GetAllBrand();
        int InsertBrand(BrandItem brandItem);
        void UpdateBrand(BrandItem brandItem);
        void DeleteBrand(int id);

    }
}
