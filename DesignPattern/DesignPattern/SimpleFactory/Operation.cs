using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    class Operation
    {
        private double numA;
        private double numB;

        public double NumA
        {
            get
            {
                return this.numA;
            }
            set
            {
                this.numA = value;
            }
        }

        public double NumB
        {
            get
            {
                return this.numB;
            }
            set
            {
                this.numB = value;
            }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
