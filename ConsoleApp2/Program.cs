using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Calc calc1 = new Calc(60);
            Calc calc2 = new Calc(70);
            Console.WriteLine(calc1.CheckAge());
            Console.WriteLine(calc2.CheckAge());
            Console.WriteLine(Calc.CheckRetirementStatus(calc1));
            Console.WriteLine(Calc.CheckRetirementStatus(calc2));
            Console.WriteLine("Текущий пенсионный возраст: " + Calc.RetirementAge);
            Calc.RetirementAge = 60;
            Console.WriteLine("Новый пенсионный возраст: " + Calc.RetirementAge);
            Calc.RetirementAge = 120;
        }
    }
}