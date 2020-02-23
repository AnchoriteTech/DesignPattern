using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }
}
