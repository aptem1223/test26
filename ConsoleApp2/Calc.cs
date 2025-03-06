using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calc
    {
        private int age;

        private static int retirementAge = 65;

        public Calc()
        {
            age = 0;
        }

        public Calc(int age)
        {
            this.age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string CheckAge()
        {
            if (age >= retirementAge)
            {
                return "Человек на пенсии.";
            }
            else
            {
                int yearsLeft = retirementAge - age;
                return $"До пенсии осталось {yearsLeft} лет.";
            }
        }

        public static int RetirementAge
        {
            get { return retirementAge; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    retirementAge = value;
                }
                else
                {
                    Console.WriteLine("Пенсионный возраст должен быть в пределах от 1 до 100 лет.");
                }
            }
        }


        public static string CheckRetirementStatus(Calc person)
        {
            if (person.age >= retirementAge)
            {
                return "Человек на пенсии.";
            }
            else
            {
                int yearsLeft = retirementAge - person.age;
                return $"До пенсии осталось {yearsLeft} лет.";
            }
        }
    }
}
