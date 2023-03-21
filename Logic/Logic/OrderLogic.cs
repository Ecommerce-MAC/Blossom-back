using Data;
using Entities.Entities;
using Logic.ILogic;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public List<OrderItem> GetAllOrders()
        {
            return _serviceContext.Set<OrderItem>().ToList();
        }
        public int InsertOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
            return orderItem.Id;
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            _serviceContext.SaveChanges();
            
        }

        public void DeleteOrderItem(int id)
        {
            var orderToDelete = _serviceContext.Set<OrderItem>()
                 .Where(o => o.Id == id).First();

            orderToDelete.IsActive = false;

            _serviceContext.SaveChanges();

        }
    }
}
