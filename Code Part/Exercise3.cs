using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQuestions.Code_Part
{
    public class Exercise3
    {
    }
    abstract class A
    {
        protected string Name;

        public abstract void PrintName();
    }

    class B : A
    {
        private void PrintName(string message)
        {
            Console.WriteLine("B: " + message);
        }

        public override void PrintName()
        {
            Console.WriteLine("B: " + Name);
        }
    }

    class C : B
    {
        public void PrintName(string message)
        {
            Console.WriteLine("C: " + message);
        }

    }

    class D : A
    {
        public D(string name)
        {
            Name = name;
        }

        public override void PrintName()
        {
            Console.WriteLine("D: " + Name);
        }
    }
}
