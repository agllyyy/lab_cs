
    internal class Program
    {
        static void Main(string[] args)
        {
            ZadaniaLab1 lab = new ZadaniaLab1();

        // (ЗАДАНИЕ 1)
        // ЗАДАЧА 2
        int input1 = lab.ProverkaNum
        ("Введите число (минимум двузначное): ");

        while (Math.Abs(input1) < 10)
        {
            Console.Write
            ("У числа менее 2х знаков. Введите число: ");
            input1 = lab.ProverkaNum("");
        }
        Console.WriteLine($"Сумма последних 2х знаков = " +
            $"{lab.sumLastNums(input1)}");

        //ЗАДАЧА 4
        int input2 = lab.ProverkaNum("\nВведите число: ");
        Console.WriteLine
        ($"Число положительное - {lab.isPositive(input2)}");

        // ЗАДАЧА 6
        Console.Write("\nВведите символ: ");
        char input3;

        while (!char.TryParse(Console.ReadLine(), out input3))
        {
            Console.Write
            ("Вы ввели не 1 символ. Введите символ: ");
        }

        Console.WriteLine($"Входит в диапазон (A - Z): " +
            $"{lab.isUpperCase(input3)}");

        // ЗАДАЧА 8
        int input4 = lab.ProverkaNum("\nВведите число: a = ");
        int input5 = lab.ProverkaNum("Введите число: b = ");
        Console.WriteLine($"Числа делятся нацело: " +
            $"{lab.isDivisor(input4, input5)}");

        // ЗАДАЧА 10
        int count = 0;
        int sum = lab.ProverkaNum("\nВведите 1е число: ");

        while (count < 4)
        {
            int input7 = lab.ProverkaNum("Введите число: ");
            int temp = sum;

            sum = lab.lastNumSum(sum, input7);

            Console.WriteLine($"Сумма чисел " +
                $"из разряда едениц: {temp % 10} + {input7 % 10} =  {sum}\n");
            count++;
        }


        // (ЗАДАНИЕ 2) if - switch
        // ЗАДАЧА 2
        int input8 = lab.ProverkaNum("Введите число:\nx = ");
        int input9 = lab.ProverkaNum("Введите число:\ny = ");
        Console.WriteLine($"{input8}/ {input9} =  " +
            $"{lab.safeDiv(input8, input9)}");

        // ЗАДАЧА 4
        int input10 = lab.ProverkaNum("\nВведите число: x = ");
        int input11 = lab.ProverkaNum("Введите число: y = ");
        Console.WriteLine(lab.makeDecision(input10, input11));

        // ЗАДАЧА 6
        int input12 = lab.ProverkaNum("\nВведите число: x = ");
        int input13 = lab.ProverkaNum("Введите число: y = ");
        int input14 = lab.ProverkaNum("Введите число: z = ");
        Console.WriteLine($"Можно ли получить " +
            $"из сложения 2х чисел третье: " +
            $"{lab.sum3(input12, input13, input14)}");

        // ЗАДАЧА 8
        int input15 = lab.ProverkaNum("\nВведите возраст: ");

        while (input15 < 0)
        {
            Console.Write("Возраст не может быть" +
                " отрицательным. Введите возраст: ");
            input15 = lab.ProverkaNum("");
        }
        Console.WriteLine(lab.age(input15));

        // ЗАДАЧА 10
        Console.Write("\nВведите день недели (полностью): ");
        string input16 = Console.ReadLine();

        lab.printDays(input16);
        Console.WriteLine();


        //(ЗАДАНИЕ 3) - циклы
        // ЗАДАЧА 2
        int input17 = lab.ProverkaNum("Введите число " +
            "(для вывода от числа до 0):  ");
        Console.WriteLine($"Вывод в обратном порядке:\n" +
            $"{lab.reverseListNums(input17)}");

        // ЗАДАЧА 4
        int input19 = 0;
            int input18 = lab.ProverkaNum("\nВведите число, " +
                "кот. нужно возвести: ");

            do
            {
                input19 = lab.ProverkaNum("Введите " +
                    "НЕотрицательную степень: ");
            } while (input19 < 0);

            Console.WriteLine($"{input18}^{input19} " +
                $"= {lab.pow(input18, input19)}");

        // ЗАДАЧА 6
        int input20 = lab.ProverkaNum("\nВведите число: ");
        Console.WriteLine($"Все цифры в числе одинаковы: " +
            $"{lab.equalNum(Math.Abs(input20))}");

        // ЗАДАЧА 8
        int input21 = lab.ProverkaNum("\nВведите число " +
            "для потсроения треугольника: ");
        lab.leftTriangle(input21);

        // ЗАДАЧА 10
        Console.WriteLine();
        lab.guessGame();
        Console.WriteLine();


        //(ЗАДАНИЕ 4) - массивы
        // ЗАДАЧА 2
        int[] mas = new int[7];
        lab.RandomMas(mas, 0, 6);
        Console.WriteLine("Исходный массив: ");
        lab.PrintMas(mas);

        int input22 = lab.ProverkaNum("Введите число" +
            " из массива: ");
        Console.WriteLine($"Индекс последнего вхождения" +
            $" числа: {lab.findLast(mas, input22)}");
        Console.WriteLine();

        // ЗАДАЧА 4
        int[] mas2 = new int[7];
        lab.RandomMas(mas2, 0, 50);
        Console.WriteLine("\nИсходный массив: ");
        lab.PrintMas(mas2);
        Console.WriteLine();

        int inputX = lab.ProverkaNum("Введите эл для вставки: ");
        int inputPos = lab.ProverkaNum("Введите индекс замены: ");
        Console.WriteLine();

        mas2 = lab.add(mas2, inputX, inputPos);
        Console.WriteLine("Массив после вставки: ");
        lab.PrintMas(mas2);
        Console.WriteLine();

        // ЗАДАЧА 6
        int count_el = lab.ProverkaNum("\nВведите кол-во " +
            "эл. массива: ");

        int[] mas3 = new int[count_el];
        lab.RandomMas(mas3, 0, 50);

        Console.WriteLine("\nИсходный массив: ");
        lab.PrintMas(mas3);
        Console.WriteLine();

        Console.WriteLine("Массив наоборот:");
        lab.reverse(mas3);
        lab.PrintMas(mas3);
        Console.WriteLine();

        // ЗАДАЧА 8
        int count_el1 = lab.ProverkaNum("\nВведите" +
            " размерность 1 массива: ");
        int count_el2 = lab.ProverkaNum("\nВведите" +
            " размерность 2 массива: ");


        int[] mas4 = new int[count_el1];
        int[] mas5 = new int[count_el2];

        lab.RandomMas(mas4, 0, 10);
        Console.WriteLine("\nИсходный массив 1:");
        lab.PrintMas(mas4);

        Console.WriteLine();
        lab.RandomMas(mas5, 0, 10);
        Console.WriteLine("Исходный массив 2:");
        lab.PrintMas(mas5);

        Console.WriteLine();
        Console.WriteLine("Итоговый:");
        lab.PrintMas(lab.concat(mas4, mas5));
        Console.WriteLine();

        // ЗАДАЧА 10
        int count_el3 = lab.ProverkaNum("\nВведите" +
            " размерность массива: ");

        int[] mas6 = new int[count_el3];
        lab.RandomMas(mas6, -10, 51);

        Console.WriteLine("\nИсходный массив: ");
        lab.PrintMas(mas6);
        Console.WriteLine();

        Console.WriteLine("Массив без отрицательных эл-ов:");
        lab.PrintMas(lab.deleteNegative(mas6));
    }
    }