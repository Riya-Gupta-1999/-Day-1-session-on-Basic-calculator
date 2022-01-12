// See https://aka.ms/new-console-template for more information
using System;

namespace newsession
{

    public interface ICar
    {
        void Tyre(int number); 
        void Engine(int cc);
        void Weight(int kg);
    }

    public class Suv : ICar 
    {
        public void Tyre(int number) 
        {
            Console.WriteLine("SUV TYRES {0} ",number);
        }
        public void Engine(int cc) 
        {
            Console.WriteLine("SUV ENGINE {0}",cc);
        }
        public void Weight(int kg) 
        {
            Console.WriteLine("SUV  WEIGHT {0}",kg);
        }
    }

    public class Sedan : ICar 
    {
        public void Tyre(int number) 
        { 
            Console.WriteLine("SEDAN TYRES {0}",number);
        }
        public void Engine(int cc) 
        {
            Console.WriteLine("SEDAN ENGINE {0}",cc);
        }
        public void Weight(int kg)
        {
            Console.WriteLine("SEDAN  WEIGHT {0}",kg);
        }
    }

    public class Program 
    {
        public static void Main(string[] args) 
        {
            ICar car;
            car = new Suv();
            car.Tyre(4);
            car.Engine(1500);
            car.Weight(350);
            car = new Sedan();
            car.Tyre(4);
            car.Engine(1500);
            car.Weight(350);
        }
    }
}

