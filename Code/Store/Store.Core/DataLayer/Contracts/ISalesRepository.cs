using System;
using System.Linq;
using System.Threading.Tasks;
using Store.Core.DataLayer.DataContracts;
using Store.Core.EntityLayer.Dbo;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Contracts
{
    public interface ISalesRepository : IRepository
    {
        IQueryable<Customer> GetCustomers();

        Task<Customer> GetCustomerAsync(Customer entity);

        IQueryable<OrderInfo> GetOrders(Int16? currencyID = null, Int32? customerID = null, Int32? employeeID = null, Int16? orderStatusID = null, Guid? paymentMethodID = null, Int32? shipperID = null);

        Task<Order> GetOrderAsync(Order entity);

        Task<OrderDetail> GetOrderDetailAsync(OrderDetail entity);

        IQueryable<Shipper> GetShippers();

        Task<Shipper> GetShipperAsync(Shipper entity);

        IQueryable<OrderStatus> GetOrderStatus();

        Task<OrderStatus> GetOrderStatusAsync(OrderStatus entity);

        IQueryable<Currency> GetCurrencies();

        IQueryable<PaymentMethod> GetPaymentMethods();
    }
}
