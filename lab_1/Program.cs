namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZadaniaLab1 l = new ZadaniaLab1();

            // (ЗАДАНИЕ 1)

            // ЗАДАЧА 2
            int input1 = l.ProverkaNum("Введите число (минимум двузначное): ");

            while (Math.Abs(input1) < 10)
            {
                Console.Write("У числа менее 2х знаков. Введите число: ");
                input1 = l.ProverkaNum("");
            }

            Console.Write("Сумма последних 2х знаков = " + l.sumLastNums(input1));


            ////ЗАДАЧА 4
            //int input2 = l.ProverkaNum("Введите число: ");
            //Console.Write("Число положительное -  " + l.isPositive(input2));


            //// ЗАДАЧА 6
            //Console.Write("Введите символ: ");
            //char input3;

            //while (!char.TryParse(Console.ReadLine(), out input3))
            //{
            //    Console.Write("Вы ввели не 1 символ. Введите символ: ");
            //}

            //Console.Write("Входит в диапазон (A - Z): " + l.isUpperCase(input3));


            //// ЗАДАЧА 8
            //int input4 = l.ProverkaNum("Введите число: a = ");
            //int input5 = l.ProverkaNum("Введите число: b = ");
            //Console.Write($"Числа делятся нацело: {l.isDivisor(input4, input5)}");


            //// ЗАДАЧА 10
            //int count = 0;
            //int sum = l.ProverkaNum("Введите 1е число: ");

            //while (count < 4)
            //{
            //    int input7 = l.ProverkaNum("Введите число: ");
            //    int temp = sum;

            //    sum = l.lastNumSum(sum, input7);

            //    Console.WriteLine($"Сумма чисел из разряда едениц: {temp % 10} + {input7 % 10} = " + sum + "\n");
            //    count++;
            //}


            // (ЗАДАНИЕ 2)
            // ЗАДАЧА 2





        }
    }
}
