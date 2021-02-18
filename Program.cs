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
        public static IWorker GetTransport()
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
    public interface IWorker
    {
        void Work();
    }
    public class Car : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Drive");
        }
    }
    public class Boat : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Float");
        }
    }
    public class Plane : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Fly");
        }
    }
}
