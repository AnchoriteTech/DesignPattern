using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    class StrategyClientDemo
    {
        public void Demo()
        {
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextMethod();

            context = new Context(new ConcreteStrategyB());
            context.ContextMethod();
        }
    }
}
