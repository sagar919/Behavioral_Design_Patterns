﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int executeStrategy(int num1, int num2)
        {
            return strategy.doOperation(num1, num2);
        }
    }
}
