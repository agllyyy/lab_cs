using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    internal class ZadaniaLab1
    {
        public int ProverkaNum(string x)
        {
            Console.Write(x);
            string input = Console.ReadLine();
            int num = 0;

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
            if (x > 0)
            {
                return true;
            }
            return false;
        }


        public bool isUpperCase(char x)
        {
            if ("QWERTYUIOPASDFGHJKLZXCVBNM".Contains(x))
            {
                return true;
            }
            return false;
        }


        public bool isDivisor(int a, int b)
        {
            if (a % b == 0 || b % a == 0)
            {
                return true;
            }
            return false;
        }


        public int lastNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }


    }
}
