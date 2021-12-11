
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodProgram.Run();
            AbstractFactoryProgram.Run();
            BuilderProgram.Run();
            AdapterProgram.Run();
        }
    }
}
