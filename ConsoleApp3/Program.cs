using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Program = new Program();
            Console.WriteLine("select Your operation: add,mul,div,sub");
            String Selection = Console.ReadLine();

            if(Selection == "add")
            {
                Console.WriteLine("write first number");
                int FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("write Second number");
                int SecondNumber = Convert.ToInt32(Console.ReadLine());

                Program.Sum(FirstNumber, SecondNumber);
            }
            else if (Selection ==  "mul")
                {
                Console.WriteLine("write first number");
                int FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("write Second number");
                int SecondNumber = Convert.ToInt32(Console.ReadLine());
                Program.Mul(FirstNumber, SecondNumber);

            }
            else if (Selection == "div")
            {
                Console.WriteLine("write first number");
                int FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("write Second number");
                int SecondNumber = Convert.ToInt32(Console.ReadLine());
                Program.Div(FirstNumber, SecondNumber);
            }
            else if (Selection == "sub")
            {
                Console.WriteLine("write first number");
                int FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("write Second number");
                int SecondNumber = Convert.ToInt32(Console.ReadLine());
                Program.Sub(FirstNumber, SecondNumber);
            }
            else
            {
               Console.WriteLine("wrong selection!!");
            }
            

            
           

        }
     
        static void Sum(int fn, int sn)
        {
            int Result = fn + sn;
            Console.WriteLine("sum = " + Result);


        }
        static void Mul(int fn, int sn)
        {
            int Result = fn * sn;
            Console.WriteLine("sum = " + Result);


        }
        static void Div(int fn, int sn)
        {
            int Result = fn / sn;
            Console.WriteLine("sum = " + Result);



        }
        static void Sub(int fn, int sn)
        {
            int Result = fn - sn;
            Console.WriteLine("sum = " + Result);


        }


      


    }
}
