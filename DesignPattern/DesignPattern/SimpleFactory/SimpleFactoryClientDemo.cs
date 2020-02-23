using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    class SimpleFactoryDemo
    {
        public void Demo()
        {
            Operation opAdd = OperationFactory.CreateOperation("+");
            opAdd.NumA = 1;
            opAdd.NumB = 2;
            Console.WriteLine("Operation for Adding:{0}", opAdd.GetResult());

            Operation opSub = OperationFactory.CreateOperation("-");
            opSub.NumA = 1;
            opSub.NumB = 2;
            Console.WriteLine("Operation for Substraction:{0}", opSub.GetResult());
        }
    }
}