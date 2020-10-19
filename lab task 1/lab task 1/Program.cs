using System;

namespace lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" );

            Console.WriteLine("Aditto Al Ashir");

            int x = 11;
            int y = 22;
            int sum = x + y;
            Console.WriteLine("Sum is :  "sum);

            int a = 10;
            int b = 2;
            int divide = a / b;
            System.Console.WriteLine("Division is :  " +divide);


            int c = -5 + 8 * 6;
            Console.WriteLine("a. " + c);
            int d = (55 + 9) % 9;
            Console.WriteLine("b. " + d);
            int e = (20 + -3) * (5 / 8) ;
            Console.WriteLine("c. " + e);
            int f = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("d. " + f);

            int aa = 20;
            int bb = 10;
            int addition = aa + bb;
            int multiply = aa * bb;
            int subtraction = aa - bb;
            double division = aa / bb;
            Console.WriteLine("addition" + addition);
            Console.WriteLine("multiply " + multiply);
            Console.WriteLine("sub : " + subtraction);
            Console.WriteLine("divide: " + division);


            double aaa = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine(aaa);


            double Width = 5.6;
            double Height = 8.5;
            double area = Width * Height;
            double Perimeter = 2 * (Width + Height);
            Console.WriteLine("Area is 5.6 * 8.5 =" + area);
            Console.WriteLine("Perimeter is 2 * (5.6 + 8.5) = " + Perimeter);

        }
    }
}
