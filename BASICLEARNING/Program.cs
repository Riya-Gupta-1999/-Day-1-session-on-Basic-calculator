// See https://aka.ms/new-console-template for more information
using System;
using Operations;

namespace basiclearning
{
    class Program
    {

        static void Main(string[] args)
        {
           Calculations op=new Calculations(); 

           Console.WriteLine("First Number : ");
           double a1=Convert.ToDouble(Console.ReadLine());

           Console.Write("Second Number : ");
           double b1=Convert.ToDouble(Console.ReadLine());

           Console.Write("Type 1 for ADD ; Type 2 for SUBSTRACTION ; Type 3 for MULTIPLICATION ; Type 4 for DIVISION..... \n");
           int number=Convert.ToInt32(Console.ReadLine());

           switch(number)
           {
               case 1:
               {
                   op.Sum ( a1, b1 );
                   break;
               }
               case 2:
               {
                   op.Substract ( a1, b1 );
                   break;
               }
               case 3:
               {
                   op.Multiply ( a1, b1 );
                   break;
               }
               case 4:
               {
                   op.Division ( a1, b1 );
                   break;
               }
               default:
               {
                   Console.Write("Select Appropriate Option");
                   break;
               }
           }

        }
    }
}