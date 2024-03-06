using System.Collections.Generic;
using dotnetapp.Models;
using dotnetapp.Repositories;

namespace dotnetapp.Services
{
public class OrderService : IOrderService
{
    private readonly OrderRepository _repository;

    public OrderService(OrderRepository repository)
    {
        _repository = repository;
    }

    public List<Order> GetOrders() => _repository.GetOrders();

    public Order GetOrder(int id) => _repository.GetOrder(id);

    public void SaveOrder(Order order) => _repository.SaveOrder(order);

    public void UpdateOrder(int id, Order order) => _repository.UpdateOrder(id, order);

    public bool DeleteOrder(int id) => _repository.DeleteOrder(id);
}

}
