using EcommerceWithAngularWeb.Models;

namespace EcommerceWithAngularWeb.Services.Infrastuctures
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void Insert(Order order);
        void Delete(int id);
        int Count();
        void Save();
    }
}
