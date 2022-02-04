using Course.Web.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Services.Interface
{
    public interface IOrderService
    {
        //Senkron iletişim- direkt microservise istek yapılacak
        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput);
        //Asenkron iletişim- sipariş bilgileri RabbitMQ gönderilecek
        Task<OrderSuspendViewModel> SuspendOrder(CheckoutInfoInput checkoutInfoInput);
        Task<List<OrderViewModel>> GetOrder();
    }
}
