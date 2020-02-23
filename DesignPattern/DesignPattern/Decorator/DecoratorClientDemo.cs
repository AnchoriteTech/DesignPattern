using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    class DecoratorClientDemo
    {
        public void Demo()
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();
            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);

            decoratorB.Operation();
        }
    }
}
