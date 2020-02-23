using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    class OperationFactory
    {
        public static Operation CreateOperation(string op)
        {
            Operation operation = null;
            switch (op)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                default:
                    throw new NotImplementedException(string.Format("Not supported operator: {0}!", op));
            }
            return operation;
        }
    }
}
