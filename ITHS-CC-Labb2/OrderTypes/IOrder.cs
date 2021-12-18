using System;

namespace ITHS_CC_Labb2
{
    public interface IOrder
    {
        string Email { get; set; }
        Guid ID { get; set; }
        int TotalPrce { get; set; }
        public IProcessOrder PriorityLevel { get; set; }
    }
}