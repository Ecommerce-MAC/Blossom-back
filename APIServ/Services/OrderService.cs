using APIServ.IServices;
using Data;
using Entities.Entities;
using Logic.ILogic;

namespace APIServ.Services
{
    public class OrderService: IOrderService
    {
            private readonly IOrderLogic _orderLogic;
            public OrderService(IOrderLogic orderLogic)
            {
                _orderLogic = orderLogic;
            }
            public int InsertOrder(OrderItem orderItem)
            {
                _orderLogic.InsertOrderItem(orderItem);
                return orderItem.Id;
            }
            public List<OrderItem> GetAllOrder()
            {
                return _orderLogic.GetAllOrders();
            }

            public void DeleteOrder(int id)
            {
                _orderLogic.DeleteOrderItem(id);
            }

            public void UpdateOrder(OrderItem orderItem)
            {
                _orderLogic.UpdateOrderItem(orderItem);
            }
           

    }
}
