using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    internal class ZadaniaLab1
    {
        public int ProverkaNum(string vvod)
        {
            Console.Write(vvod);
            string input = Console.ReadLine();

            int num;

            while (!int.TryParse(input, out num))
            {
                Console.Write("Введите число: ");
                input = Console.ReadLine();
            }
            return num;
        }

        public int sumLastNums(int x)
        {
            x = Math.Abs(x);
            int a = x % 10;
            int b = x / 10 % 10;
            return (a + b);
        }

        public bool isPositive(int x)
        {
            return x > 0;
        }

        public bool isUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        public bool isDivisor(int a, int b)
        {
            return (a != 0 && b != 0 && (a % b == 0 || b % a == 0));
        }

        public int lastNumSum(int a, int b)
        {
            return Math.Abs(a % 10) + Math.Abs(b % 10);
        }

        public double safeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return (double)x / y;
        }

        public String makeDecision(int x, int y)
        {
            if (x > y)
            {
                return $"{x} > {y}";
            }
            if (x < y)
            {
                return $"{x} < {y}";
            }
            return $"{x} == {y}";
        }

        public bool sum3(int x, int y, int z)
        {
            return (x + y == z) || (x + z == y) || (y + z == x);
        }

        public String age(int x)
        {
            if (x % 100 >= 11 && x % 100 <= 14)
            {
                return $"{x} лет";
            }

            if (x % 10 == 1)
            {
                return $"{x} год";
            }

            if ((x % 10 == 2) || (x % 10 == 3) || (x % 10 == 4))
            {
                return $"{x} года";
            }
            return $"{x} лет";

        }

        public void printDays(String x)
        {
            switch (x)
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    goto case "вторник";

                case "вторник":
                    Console.WriteLine("вторник");
                    goto case "среда";

                case "среда":
                    Console.WriteLine("среда");
                    goto case "четверг";

                case "четверг":
                    Console.WriteLine("четверг");
                    goto case "пятница";

                case "пятница":
                    Console.WriteLine("пятница");
                    goto case "суббота";

                case "суббота":
                    Console.WriteLine("суббота");
                    goto case "воскресенье";

                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;

                default:
                    Console.WriteLine("Вы ввели не день недели.");
                    break;
            }
        }





    }
}
