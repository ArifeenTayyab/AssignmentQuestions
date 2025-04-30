using assignmentQuestions.Code_Part;
using System;

namespace assignmentQuestions
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            var randNum = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int number = randNum.Next(1, 101);
                Console.Write($"{i}: {number}");
                if (number % 7 == 0) Console.Write(" Lucky Number!");
                Console.WriteLine();
                if (i % 5 == 0) Console.WriteLine("******");
            }

            // Exercise3 part 1

            A a1 = new D("D-Class");
            a1.PrintName();

            A a2 = new B();
            a2.PrintName();

            C c = new C();
            c.PrintName("Hello from C");

            // A obj = new A(); Not allowed!  Reference to question1 of exercise 4.
        }
    }
}
