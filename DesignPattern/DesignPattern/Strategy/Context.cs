using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    // Use One ConcreteStrategy to config and maintain reference of Strategy
    class Context
    {
        Strategy strategy;
        // Pass instance of Strategy(ConcreteStrategyX)
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextMethod()
        {
            this.strategy.Algorithm();
        }
    }
}
