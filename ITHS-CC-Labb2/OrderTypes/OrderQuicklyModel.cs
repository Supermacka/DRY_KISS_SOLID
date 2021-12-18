using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderQuicklyModel : IOrder
    {
        public string Email { get; set; }
        public Guid ID { get; set; }
        public int TotalPrce { get; set; }
        public IProcessOrder PriorityLevel { get; set; } = new ProcessOrderQuickly();
    }
}
