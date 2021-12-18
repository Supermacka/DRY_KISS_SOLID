using System;

namespace ITHS_CC_Labb2
{
    public class ProcessOrderLightningSpeed : IProcessOrder
    {
        public bool Process(IOrder order)
        {
            // Some logic we don't care about
            return true;
        }
    }
}