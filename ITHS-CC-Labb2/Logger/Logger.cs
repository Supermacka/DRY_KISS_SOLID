﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class Logger : ILogger
    {
        public string Log(string message)
        {
            return $"{DateTime.Now}: {message}";
        }
    }
}
