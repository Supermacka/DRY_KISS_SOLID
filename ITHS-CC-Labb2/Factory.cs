using ITHS_CC_Labb2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public static class Factory
    {
        public static IOrder CreateNormalOrder()
        {
            return new OrderNormallyModel();
        }
        public static IOrder CreateQuickOrder()
        {
            return new OrderQuicklyModel();
        }
        public static IOrder CreateLightningSpeedOrder()
        {
            return new OrderLightningSpeedModel();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }

        public static IOrderService CreateOrderService()
        {
            return new OrderService(CreateLogger(), CreateMessageSender());
        }

    }
}
