// See https://aka.ms/new-console-template for more information
using System;

namespace newsession
{
    public abstract class Program
    {
        abstract public void Calculate(double a, double b);

    }
    class Add:Program
    {
        double result;
        
        public override void Calculate(double a, double b)
        {
            result=a+b;
            Console.WriteLine("ADDITION IS  : {0}" ,result);
        }
    }
    class Sub:Program
    {
        double result;
        
        public override void Calculate(double a, double b)
        {
            result=a-b;
            Console.WriteLine("SUBSTRACTION IS  : {0}",result);
        }
    }
    class Mul:Program
    {
        double result;
        
        public override void Calculate(double a, double b)
        {
            result=a*b;
            Console.WriteLine("MULTIPLICATION IS  : {0}",result);
        }
    }
    class Div:Program
    {
        double result;
        
        public override void Calculate(double a, double b)
        {
            result=a/b;
            Console.WriteLine("DIVISION IS  : {0}",result);
        }
    }
    class Operations
    {
        static void Main(string[] args)
        {
            double one=0.0, two=0.0;
            Program p;
           // p=new Add();
            //p.Calculate(2,3);
            Console.WriteLine("Enter Number One : ");
            double.TryParse(Console.ReadLine(),out one);
            Console.WriteLine("Enter Number Two : ");
            double.TryParse(Console.ReadLine(),out two);

            Console.Write("Type 1 for ADD ; Type 2 for SUBSTRACTION ; Type 3 for MULTIPLICATION ; Type 4 for DIVISION..... \n");
            int number=Convert.ToInt32(Console.ReadLine());

            switch(number)
           {
               case 1:
               {
                   p=new Add();
                   p.Calculate ( one, two );
                   break;
               }
               case 2:
               {
                   p=new Sub();
                   p.Calculate ( one, two );
                   break;
               }
               case 3:
               {
                   p=new Mul();
                   p.Calculate ( one, two );
                   break;
               }
               case 4:
               {
                   p=new Div();
                   p.Calculate ( one, two );
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

