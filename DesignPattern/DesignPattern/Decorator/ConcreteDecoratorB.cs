using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            this.AddedState();
        }

        // ConcreteDecoratorB only, which is different with other Decorator
        private void AddedState()
        {
            Console.WriteLine("ConcreteDecoratorB state");
        }
    }
}
