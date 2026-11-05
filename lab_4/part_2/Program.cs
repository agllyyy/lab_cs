internal class Program
{
    static void Main(string[] args)
    {
        uint rubles = Checked.ReadUint
            ("Введите количество рублей: ");
        byte kopeks = Checked.ReadByte
            ("Введите количество копеек (0-255): ");

        Money wallet = new Money(rubles, kopeks);

        Console.WriteLine($"Изначально денег: {wallet}\n");

        uint addKopeks = Checked.ReadUint
            ("Введите кол-во копеек для добавления: ");
        Console.WriteLine
            ($"Денег после добавления: " +
            $"{wallet.AddKopeks(addKopeks)}\n");



        Console.WriteLine
            ($"Добавление 1 копейки: {++wallet}\n");
        try
        {
            Console.WriteLine
                ($"Вычитание 1 копейки: {--wallet}\n");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}\n");
        }


        double kopecks = wallet;
        Console.WriteLine
            ($"Неявное приведение в double: {kopecks}\n");
        Console.WriteLine
            ($"Явное приведение в uint: {(uint)wallet}\n");


        uint subCount1 = Checked.ReadUint
            ($"Введите кол-во рублей для вычитания из" +
            $" кошелька ({wallet}): ");
        try
        {
            Console.WriteLine($"Правосторонняя операция " +
                $"({wallet} - {subCount1}): {wallet - subCount1}\n");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}\n");
        }

        uint subCount2 = Checked.ReadUint
            ($"Введите число рублей, из которого мы вычтем " +
            $"кошелёк ({wallet}): ");
        try
        {
            Console.WriteLine($"Левосторонняя операция " +
                $"({subCount2} - {wallet}): {subCount2 - wallet}\n");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}\n");
        }

    }
}

