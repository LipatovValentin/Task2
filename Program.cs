using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = GetTransport();

            obj.Work();

            Console.ReadKey();
        }
        public static Transport GetTransport()
        {
            switch (new Random().Next(0, 3))
            {
                case 0: return new Car();
                case 1: return new Boat();
                case 2: return new Plane();
                default: throw new Exception("Unknown mode of transport");
            }
        }
    }
    public class Transport
    {
        public virtual void Work()
        {
            throw new Exception("Method is not overridden");
        }
    }
    public class Car : Transport
    {
        public override void Work()
        {
            Console.WriteLine("Drive");
        }
    }
    public class Boat : Transport
    {
        public override void Work()
        {
            Console.WriteLine("Float");
        }
    }
    public class Plane : Transport
    {
        public override void Work()
        {
            Console.WriteLine("Fly");
        }
    }
}
