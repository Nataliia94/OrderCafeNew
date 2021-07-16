using OrderCafe.Models.DataBase;
using System.Collections.Generic;

namespace OrderCafe.Service
{
    public interface IDataManagmant
    {
        Order GetOrder(string number);
        IList<Order> GetOrders(PayMethodos? payMethodos = null);

        string AddOrder(Order order);

        string UpdateOrder(string orderNumber, Order model);
        void DeleteOrder(string orderNumber);


    }
}