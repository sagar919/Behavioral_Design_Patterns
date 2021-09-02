using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public interface IStrategy
    {
        public int doOperation(int num1, int num2);
    }
}
