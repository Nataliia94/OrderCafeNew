using OrderCafe.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCafe.Service
{
    public class DataManagmant : IDataManagmant
    {
        private IList<Order> _orders = new List<Order>();
        public DataManagmant()
        {
            _orders.Add(new Order
            {

                FullClientName = "ClientA",
                PhoneNumber = "63747484848",
                ComplexDish = "Meat with potato",
                
                Price = 50,
                Amount = 3,
                TotalPrice = 150
            });


            _orders.Add(new Order
            {

                FullClientName = "ClientB",
                PhoneNumber = "63747484848",
                ComplexDish = "Soup",
                
                Price = 50,
                Amount = 3,
                TotalPrice = 150
            });

            _orders.Add(new Order
            {

                FullClientName = "ClientC",
                PhoneNumber = "63747484848",
                ComplexDish="Rice with vegetables",
                Price = 50,
                Amount = 3,
                TotalPrice = 150
            });


        }
        public IList<Order> GetOrders(PayMethodos? payMethodos = null)
        {
            var result = _orders;
            if(payMethodos.HasValue)
            {
                result = result.Where(x => x.PayMethodos == payMethodos.Value).ToList();
            }
            return result;
        }

        public Order GetOrder(string number)
        {
            return _orders.SingleOrDefault(x => x.FullClientName.Equals(number, StringComparison.InvariantCultureIgnoreCase));
        }

        public string AddOrder(Order order)
        {
            _orders.Add(order);
            return order.FullClientName;
        }

        public string UpdateOrder(string orderNumber, Order model)
        {
            var order = GetOrder(orderNumber);
            order.FullClientName = model.FullClientName;
            order.PhoneNumber = model.PhoneNumber;
            order.PayMethodos = model.PayMethodos;
            order.ComplexDish = model.ComplexDish;
            order.Price = model.Price;
            order.Amount = model.Amount;
            order.TotalPrice = model.TotalPrice;
            return model.FullClientName;
        }

        public void DeleteOrder(string orderNumber)
        {
            var order = GetOrder(orderNumber);
            _orders.Remove(order);
        }
    }
}
