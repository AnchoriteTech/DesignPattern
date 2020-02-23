using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        // Call method:Operation of this.component
        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }
    }
}
