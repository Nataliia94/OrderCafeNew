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

                ClientName = "ClientA",
                PhoneNumber = "63747484848",
                FirstDish = "Meat with potato",
                SecondDish = "Soup",
                Price = 50,
                Amount = 3,
                TotalPrice = 150
            });


            _orders.Add(new Order
            {

                ClientName = "ClientB",
                PhoneNumber = "63747484848",
                FirstDish = "Meat with potato",
                SecondDish = "",
                Price = 50,
                Amount = 3,
                TotalPrice = 150
            });

            _orders.Add(new Order
            {

                ClientName = "ClientC",
                PhoneNumber = "63747484848",
                FirstDish = "",
                SecondDish = "Meat with potato",
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
            return _orders.SingleOrDefault(x => x.ClientName.Equals(number, StringComparison.InvariantCultureIgnoreCase));
        }

        public string AddOrder(Order order)
        {
            _orders.Add(order);
            return order.ClientName;
        }

        public string UpdateOrder(string orderNumber, Order model)
        {
            var order = GetOrder(orderNumber);
            order.ClientName = model.ClientName;
            order.PhoneNumber = model.PhoneNumber;
            order.PayMethodos = model.PayMethodos;
            order.FirstDish = model.FirstDish;
            order.SecondDish = model.SecondDish;
            order.Price = model.Price;
            order.Amount = model.Amount;
            order.TotalPrice = model.TotalPrice;
            return model.ClientName;
        }

        public void DeleteOrder(string orderNumber)
        {
            var order = GetOrder(orderNumber);
            _orders.Remove(order);
        }
    }
}
