using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    class ConcreteDecoratorA : Decorator
    {
        // ConcreteDecoratorA only, which is different with other Decorator
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            this.addedState = "ConcreteDecoratorA state";
            Console.WriteLine(this.addedState);
        }
    }
}
