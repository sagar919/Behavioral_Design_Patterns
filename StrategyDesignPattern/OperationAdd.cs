﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class OperationAdd : IStrategy
    {
        
        public int doOperation(int num1, int num2)
    {
        return num1 + num2;
    }
}
}
