// See https://aka.ms/new-console-template for more information
using System;

namespace Operations
{
    class Calculations
    {

        public void Sum ( double a, double b )
        {
            double c;
            c=a+b;
            Console.Write("Addition : "+c+"\n");
        }

        public void Substract ( double a, double b )
        {
            double c;
            c=a-b;
            Console.Write("Substraction : "+c+"\n");
        }

        public void Multiply ( double a, double b )
        {
            double c;
            c=a*b;
            Console.Write("Multiplication : "+c+"\n");
        }
        public void Division ( double a, double b )
        {
            double c;
            c=a/b;
            Console.Write("Division : "+c+"\n");
        }
    }
}