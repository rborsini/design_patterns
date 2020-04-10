using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            var output = abstraction.Operation();
            Console.WriteLine(output);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            output = abstraction.Operation();
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
