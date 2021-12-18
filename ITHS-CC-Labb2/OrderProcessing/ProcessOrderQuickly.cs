using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    class ProcessOrderQuickly : IProcessOrder
    {
        public bool Process(IOrder order)
        {
            // Some logic we don't care about
            return true;
        }
    }
}
