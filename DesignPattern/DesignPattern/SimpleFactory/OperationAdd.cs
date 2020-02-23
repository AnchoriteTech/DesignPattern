using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }
}
