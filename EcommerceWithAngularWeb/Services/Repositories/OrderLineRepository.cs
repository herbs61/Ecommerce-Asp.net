using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastuctures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class OrderLineRepository : IOrderLine
    {
        private ApplicationDbContext _context;
        public OrderLineRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.OrderLines.Count();
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _context.OrderLines;
        }

        public OrderLine GetOrderLine(int id)
        {
            var orderLine = _context.OrderLines.FirstOrDefault(c => c.Id == id);
            if (orderLine != null)
            {
                return orderLine;
            }
            return null;

        }

        public void Insert(OrderLine orderLine)
        {
            _context.OrderLines.Add(orderLine);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(OrderLine orderLine)
        {
            _context.OrderLines.Update(orderLine);
        }
    }
}
