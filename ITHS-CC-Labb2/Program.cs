using ITHS_CC_Labb2;
using System;

IOrder slowOrder = Factory.CreateLightningSpeedOrder();
slowOrder.ID = Guid.NewGuid();
slowOrder.Email = "quickEmail@example.com"; 
slowOrder.TotalPrce = 100;

IOrderService orderService = Factory.CreateOrderService();
orderService.ProcessOrder(slowOrder);