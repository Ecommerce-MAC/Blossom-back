using Entities.Entities;

namespace APIServ.IServices
{
    public interface IOrderService
    {
        List<OrderItem> GetAllOrder();
        int InsertOrder(OrderItem orderItem);
        void UpdateOrder(OrderItem orderItem);
        void DeleteOrder(int id);
    }
}
