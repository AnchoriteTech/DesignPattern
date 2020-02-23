using DesignPattern.Decorator;
using DesignPattern.SimpleFactory;
using DesignPattern.Strategy;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactoryDemo demo = new SimpleFactoryDemo();
            demo.Demo();

            StrategyClientDemo strategyClientDemo = new StrategyClientDemo();
            strategyClientDemo.Demo();

            DecoratorClientDemo decoratorDemo = new DecoratorClientDemo();
            decoratorDemo.Demo();
        }
    }
}
