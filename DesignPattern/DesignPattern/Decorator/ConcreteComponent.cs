using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Logic of ConcreteComponent");
        }
    }
}
