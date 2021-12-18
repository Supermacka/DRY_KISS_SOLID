using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService : IOrderService
    {
        private readonly string PROCESS_ATTEMPT = "Attempting to process order with ID ";
        private readonly string PROCESS_SUCESS = "Succesfully processed order with ID ";
        private readonly string PROCESS_FAILED = "FAILED ORDER: Could not ship order with ID ";
        private readonly ILogger _logger;
        private readonly IMessageSender _messageSender;

        public OrderService(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void ProcessOrder(IOrder order)
        {
            bool isValid = false;
               
            Console.WriteLine(_logger.Log(PROCESS_ATTEMPT + order.ID));
            isValid = order.PriorityLevel.Process(order);

            if (isValid)
            {
                Console.WriteLine(_logger.Log(PROCESS_SUCESS + order.ID));
                Console.WriteLine(_messageSender.SendMessage(order.Email, order.ID));
            }
            else
            {
                _logger.Log(PROCESS_FAILED + order.ID);
            }
        }
    }
}
