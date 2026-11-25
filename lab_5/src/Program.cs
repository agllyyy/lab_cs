internal class Program
{
    static void Main(string[] args)
    {
        string readPath = "LR5-var2.xls";
        string savePath = "LR5-var2_updated.xlsx";

        Database db = new Database();
        db.ReadDatabase(readPath);

        while (true)
        {
            Console.WriteLine(
                "1. Просмотр базы данных (последние N записей)");
            Console.WriteLine(
                "2. Добавить новый элемент");
            Console.WriteLine(
                "3. Удалить элемент по ключу (ID)");
            Console.WriteLine("4. Выполнить 4 LINQ-запроса");
            Console.WriteLine(
                "5. Сохранить изменения в Excel-файл");
            Console.WriteLine("0. Выход");

            int choice = Checked.ReadInt("\nВыберите действие: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        "\n1 — Животные, " +
                        "2 — Покупатели, " +
                        "3 — Продажи");
                    int tableNum = Checked.NaturalReadInt(
                        "Выберите таблицу: ");

                    while (tableNum < 1 || tableNum > 3)
                    {
                        Console.WriteLine("Ошибка: такой " +
                            "таблицы нет! Введите 1, 2 или 3.");
                        tableNum = Checked.NaturalReadInt(
                            "Выберите таблицу: ");
                    }

                    int count = Checked.NaturalReadInt
                        ("Сколько записей показать: ");
                    db.ViewData(tableNum, count);
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine(
                        "\n1 — Животные, " +
                        "2 — Покупатели, " +
                        "3 — Продажи");
                    int addChoice = Checked.NaturalReadInt
                        ("Куда добавить: ");

                    if (addChoice == 1)
                    {
                        string species = Checked.ReadString
                            ("Вид животного: ");
                        string breed = Checked.ReadString
                            ("Порода (можно нажать Enter): ");
                        db.Add(species, breed);
                    }
                    else if (addChoice == 2)
                    {
                        string name = Checked.ReadString
                            ("Имя покупателя: ");
                        int age = Checked.NaturalReadInt
                            ("Возраст: ");
                        string address = Checked.ReadString
                            ("Адрес (город): ");
                        db.Add(name, age, address);
                    }
                    else if (addChoice == 3)
                    {
                        int animalId = Checked.NaturalReadInt
                            ("ID животного: ");
                        int buyerId = Checked.NaturalReadInt
                            ("ID покупателя: ");
                        string dateStr = Checked.ReadString
                            ("Дата продажи (ДД.ММ.ГГГГ): ");
                        DateTime date = DateTime.Parse(dateStr);
                        int price = Checked.ReadInt("Цена: ");
                        db.Add(animalId, buyerId, date, price);
                    }
                    else
                    {
                        Console.WriteLine
                            ("Ошибка: неверный номер таблицы.");
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine(
                        "\n1 — Животные, " +
                        "2 — Покупатели, " +
                        "3 — Продажи");
                    int delChoice = Checked.NaturalReadInt
                        ("Откуда удалить: ");
                    int id = Checked.NaturalReadInt
                        ("Введите ID для удаления: ");

                    if (delChoice == 1) db.DeleteAnimal(id);
                    else if (delChoice == 2) db.DeleteBuyer(id);
                    else if (delChoice == 3) db.DeleteSale(id);
                    else Console.WriteLine
                            ("Ошибка: неверный номер таблицы.");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine
                        ("\nПеречень черепах породы «Боксерская»:");
                    var res1 = db.Query1();
                    Console.WriteLine($"Найдено: {res1.Count}");
                    db.PrintList(res1);

                    Console.WriteLine($"\nСумма покупок " +
                        $"Сфинксов в январе 2023: " +
                        $"{db.Query2()} руб.");

                    Console.WriteLine("\nПокупки клиентов " +
                        "старше 65 лет на сумму > 8000 руб.:");
                    var res3 = db.Query3();
                    Console.WriteLine($"Найдено: {res3.Count}");
                    db.PrintList(res3);

                    Console.WriteLine($"\nПродано хомяков " +
                        $"в Москве: {db.Query4()} шт.");
                    Console.WriteLine();
                    break;

                case 5:
                    db.SaveDatabase(savePath);
                    Console.WriteLine();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine
                        ("Неизвестная команда, попробуйте снова.");
                    Console.WriteLine();
                    break;
            }
        }





    }
}
