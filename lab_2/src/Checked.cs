
internal  class Checked
{
    // проверка на bool
    public  bool ReadBool(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();

        bool x = true;
        while (true)
        {
            if (bool.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Повторите ввод:");
                input = Console.ReadLine();
            }
        }
    }

    // проверка на string

    // проверка на int (по идее должны быть статическими, но пока что так)
    // ? - польз. может ничего не ввести
    public  int ReadInt(string promt)
    {
        Console.Write(promt);
        string? input = Console.ReadLine();

        // если хотите остановить введите какое то слово/число например и тп
        // в лабах лучше не использовать бесконечные циклы
        int x = 0;
        while (true)
        {
            if (int.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.Write
                    ("Ошибка ввода! Повторите ввод:");
                input = Console.ReadLine();
            }
        }
    }

    public  int NaturalReadInt(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();

        int x = 0;
        while (true)
        {
            if (int.TryParse(input, out x) && x > 0)
            {
                return x;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Повторите ввод:");
                input = Console.ReadLine();
            }
        }
    }

    // проверка на double
    public  double ReadDouble(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();

        double x = 0;
        while (true)
        {
            if (double.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Повторите ввод:");
                input = Console.ReadLine();
            }
        }
    }

}


