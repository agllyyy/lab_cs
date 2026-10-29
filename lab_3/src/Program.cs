using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        //// ЗАДАНИЕ 1

        //int n1 = Checked.NaturalReadInt
        //    ("введите кол-во строк: n = ");
        //int m1 = Checked.NaturalReadInt
        //    ("введите кол-во столбцов: m = ");
        //Console.WriteLine();

        //Matrix matr1 = new Matrix(n1, m1);
        //Console.WriteLine("\nПолученная матрица:");
        //Console.WriteLine(matr1);


        //int n2 = Checked.NaturalReadInt
        //    ("введите кол-во строк/столбцов: n = ");
        //Console.WriteLine();
        //Matrix matr2 = new Matrix(n2, true);
        //Console.WriteLine("\nПолученная матрица:");
        //Console.WriteLine(matr2);

        //int n3 = Checked.NaturalReadInt
        //    ("введите кол-во строк/столбцов: n = ");
        //Console.WriteLine();
        //Matrix matr3 = new Matrix(n3);
        //Console.WriteLine("\nПолученная матрица:");
        //Console.WriteLine(matr3);




        //// ЗАДАНИЕ 2

        //double? rez = matr1.GetMinDuplicate();
        //if (rez != null)
        //{
        //    Console.WriteLine($"Минимальный из повторяющихся" +
        //        $" элементов: {rez}");
        //}
        //else
        //{
        //    Console.WriteLine
        //        ("В матрице нет повторяющихся элементов.");
        //}
        //Console.WriteLine();



        ////ЗАДАНИЕ 3

        //Console.WriteLine
        //("Введите размеры матриц для вычислений.");
        //int rows = Checked.NaturalReadInt
        //("Введите кол-во строк: ");
        //int cols = Checked.NaturalReadInt
        //    ("Введите кол-во столбцов: ");
        //Console.WriteLine();

        //Matrix A = new Matrix(rows, cols, true);
        //Console.WriteLine("\nПолученная матрица A:");
        //Console.WriteLine(A);
        //Console.WriteLine();

        //Matrix B = new Matrix(rows, cols, true);
        //Console.WriteLine("\nПолученная матрица B:");
        //Console.WriteLine(B);
        //Console.WriteLine();

        ////Matrix C = new Matrix(rows, cols, true);
        //Matrix C = new Matrix(cols, rows, true);
        //Console.WriteLine("\nПолученная матрица C:");
        //Console.WriteLine(C);
        //Console.WriteLine();

        //try
        //{
        //    Matrix rez1 = A + 2 * B - 3 * C.Transpose();
        //    Console.WriteLine
        //    ("Результат вычисления (A + 2*B - 3*C^T):");
        //    Console.WriteLine(rez1);
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine
        //    ($"Ошибка в математической логике: {ex.Message}");
        //}

        //Console.WriteLine();




        ////ЗАДАНИЕ 4

        //string way1 = "task4.bin";
        //int input1 = Checked.NaturalReadInt
        //    ("Введите кол-во элементов в файле: ");
        //long? rez2 = null;

        //try
        //{
        //    FileTasks.WriteRandomBinary
        //        (way1, input1, true);
        //    Console.Write("Содержимое бинарного файла: ");
        //    byte[] bytes = File.ReadAllBytes(way1);
        //    for (int i = 0; i < bytes.Length / 4; i++)
        //    {
        //        Console.Write(BitConverter.ToInt32(bytes, i * 4) + " ");
        //    }
        //    Console.WriteLine("\n");
        //    rez2 = FileTasks.MulNegativeOdd(way1);
        //}
        //catch (FileNotFoundException)
        //{
        //    Console.WriteLine("Ошибка: Исходный файл" +
        //        " не найден! Сначала создайте его.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Произошла непредвиденная" +
        //        $" ошибка: {ex.Message}");
        //}

        //if (rez2 != null)
        //{
        //    Console.WriteLine($"Произведение нечетных" +
        //        $" отрицательных компонент: {rez2}");
        //}
        //else
        //{
        //    Console.WriteLine("Нечетные отрицательные" +
        //        " компоненты не найдены.");
        //}




        //// ЗАДАНИЕ 6

        //string textWay = "task6.txt";
        //int input2 = Checked.NaturalReadInt
        //    ("Введите кол-во элементов в файле: ");

        //try
        //{
        //    FileTasks.WriteRandomBinary(textWay, input2, false);
        //    Console.WriteLine("Содержимое файла: ");
        //    Console.WriteLine(File.ReadAllText(textWay));
        //    Console.WriteLine();

        //    long rez3 = FileTasks.SumSquarEl(textWay);
        //    Console.WriteLine
        //        ($"Сумма квадратов элементов: {rez3}");
        //}
        //catch (FileNotFoundException)
        //{
        //    Console.WriteLine
        //        ("Ошибка: Текстовый файл не найден!");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Ошибка: {ex.Message}");
        //}




        //// ЗАДАНИЕ 8

        //string fileWay = "input_task8.txt";
        //string lastWay = "output_task8.txt";

        //try
        //{
        //    Console.WriteLine("Содержимое исходного файла: ");
        //    Console.WriteLine(File.ReadAllText(fileWay));
        //    Console.WriteLine();

        //    int input3;
        //    int countStr;
        //    do
        //    {
        //        input3 = Checked.NaturalReadInt
        //            ("Введите длину строки: ");
        //        countStr = FileTasks.ReWrite
        //            (fileWay, lastWay, input3);

        //        if (countStr == 0)
        //        {
        //            Console.WriteLine($"\nВ файле нет строк" +
        //                $" длиной {input3} символов.");
        //            Console.WriteLine("Введите другое число.\n");
        //        }

        //    } while (countStr == 0);

        //    Console.WriteLine($"\nФайл с строками длиной" +
        //        $" {input3} симв.):");
        //    Console.WriteLine(File.ReadAllText(lastWay));
        //}

        //catch (FileNotFoundException)
        //{
        //    Console.WriteLine($"Ошибка: Файл '{fileWay}'" +
        //        $" не найден в папке net10.0!");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Произошла ошибка:" +
        //        $" {ex.Message}");
        //}




        // ЗАДАНИЕ 7

        string textWay7 = "task7.txt";
        int m7 = Checked.NaturalReadInt("Введите кол-во строк: ");
        int n7 = Checked.NaturalReadInt("Введите кол-во столбцов: ");

        try
        {
            FileTasks.WriteRandomStruct(textWay7, m7, n7);
            Console.WriteLine("\nСодержимое созданного файла:");
            Console.WriteLine(File.ReadAllText(textWay7));

            long rez7 = FileTasks.MulEl(textWay7);
            Console.WriteLine($"\nПроизведение элементов: {rez7}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Ошибка: Текстовый файл не найден!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }




        // ЗАДАНИЕ 5






    }
}

