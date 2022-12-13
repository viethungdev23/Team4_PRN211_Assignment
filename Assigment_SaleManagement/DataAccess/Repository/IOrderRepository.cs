using DataAccess.Models;


namespace DataAccess.Repository;

public interface IOrderRepository
{
    IEnumerable<Order> GetOrders();

    IEnumerable<Order> GetOrdersByMemberId(int memberId);

    Order GetOrderById(int id);

    void Delete(int orderId);

    void Create(Order order);
    
    void Update(Order order);
}
