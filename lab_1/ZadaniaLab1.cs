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

        public void RandomMas(int[] arr, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
        }

        public void PrintMas(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "    ");
            }
            Console.WriteLine();
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

        public String reverseListNums(int x)
        {
            string rez = "";
            for (int i = x; i >= 0; i--)
            {
                rez += i + " ";
            }
            return rez;
        }

        public int pow(int x, int y)
        {
            int rez = 1;
            for (int i = 0; i < y; i++)
            {
                rez *= x;
            }
            return rez;
        }

        public bool equalNum(int x)
        {
            int posl_el = x % 10;

            while (x > 0)
            {
                if (x % 10 != posl_el)
                {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void guessGame()
        {
            Random rnd = new Random();
            int zagad_num = rnd.Next(0, 10);

            int x = ProverkaNum("Введите число от 0 до 9: ");
            int count = 0;

            while (zagad_num != x)
            {
                x = ProverkaNum("Вы не угадали, введите число от 0 до 9: ");
                count++;
            }
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Вы отгадали число за {count + 1} попытки");
        }



        public int findLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int[] add(int[] arr, int x, int pos)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < pos)
                {
                    newArr[i] = arr[i];
                }
                else if (i == pos)
                {
                    newArr[i] = x;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }
            return newArr;
        }

        public void reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int protiv_el = arr.Length - 1 - i;

                int temp = arr[i];
                arr[i] = arr[protiv_el];
                arr[protiv_el] = temp;
            }
        }

        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[arr1.Length + i] = arr2[i];
            }
            return newArr;
        }

        public int[] deleteNegative(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }

            int[] newArr = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            return newArr;

        }

    }
}
