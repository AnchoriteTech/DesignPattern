using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    class ConcreteStrategyB : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Logic of AlogrithmB");
        }
    }
}
