using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    class ConcreteStrategyA : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Logic of AlgorithmA");
        }
    }
}
