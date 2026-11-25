using ExcelDataReader;
using System.Data;
using System.Text;
using ClosedXML.Excel;

internal class Database
{
    private List<Animals> _animals;
    private List<Buyers> _buyers;
    private List<Sales> _sales;

    public Database()
    {
        _animals = new List<Animals>();
        _buyers = new List<Buyers>();
        _sales = new List<Sales>();
    }

    public int AnimalsCount => _animals.Count;

    public int BuyersCount => _buyers.Count;

    public int SalesCount => _sales.Count;


    // 1. Чтение базы данных из excel файла.
    public void ReadDatabase(string filePath)
    {
        Encoding.RegisterProvider
            (CodePagesEncodingProvider.Instance);

        _animals.Clear();
        _buyers.Clear();
        _sales.Clear();

        try
        {
            using FileStream stream = File.Open
                (filePath, FileMode.Open, FileAccess.Read);
            using IExcelDataReader reader = 
                ExcelReaderFactory.CreateReader(stream);

            DataSet result = reader.AsDataSet();

            if (result.Tables.Count == 0 || 
                result.Tables["Продажи"] == null ||
                result.Tables["Покупатели"] == null ||
                result.Tables["Животные"] == null)
            {
                Console.WriteLine("Ошибка: Excel-файл пуст/" +
                    "не содержит нужных листов!");
                return;
            }

            // Читаем "Продажи"
            DataTable salesTable = result.Tables["Продажи"];
            for (int i = 1; i < salesTable.Rows.Count; i++)
            {
                DataRow row = salesTable.Rows[i];
                DateTime saleDate = row[3] is double d
                    ? DateTime.FromOADate(d)
                    : Convert.ToDateTime(row[3]);

                _sales.Add(new Sales(
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToInt32(row[2]),
                    saleDate,
                    Convert.ToInt32(row[4])));
            }

            // Читаем "Покупатели"
            DataTable buyersTable = result.Tables["Покупатели"];
            for (int i = 1; i < buyersTable.Rows.Count; i++)
            {
                DataRow row = buyersTable.Rows[i];
                _buyers.Add(new Buyers(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    Convert.ToInt32(row[2]),
                    row[3].ToString()));
            }

            // Читаем "Животные"
            DataTable animalsTable = result.Tables["Животные"];
            for (int i = 1; i < animalsTable.Rows.Count; i++)
            {
                DataRow row = animalsTable.Rows[i];
                _animals.Add(new Animals(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString()));
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Ошибка: Excel-файл не найден" +
                " по пути: " + filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Ошибка ввода-вывода (возможно," +
                " файл открыт в Excel): " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine
                ("Ошибка при чтении данных: " + ex.Message);
        }
    }


    // 2. Просмотр базы данных (с конца)
    public void ViewData(int number, int count)
    {
        switch (number)
        {
            case 1:
                Console.WriteLine($"\nТаблица \"Животные\"" +
                    $"\nВсего записей: {_animals.Count}");
                Console.WriteLine($"{"ID",-5} | {"Вид",-12} | Порода");
                Console.WriteLine(new string('-', 36));
                foreach (var animal in _animals.TakeLast(count))
                {
                    Console.WriteLine(animal);
                }
                break;

            case 2:
                Console.WriteLine($"\nТаблица \"Покупатели\"" +
                    $"\nВсего записей: {_buyers.Count}");
                Console.WriteLine($"{"ID",-5} | {"Имя",-26} |" +
                    $" {"Возр",-4} | Адрес");
                Console.WriteLine(new string('-', 60));
                foreach (var buyer in _buyers.TakeLast(count))
                {
                    Console.WriteLine(buyer);
                }
                break;

            case 3:
                Console.WriteLine($"\nТаблица \"Продажи\"" +
                    $"\nВсего записей: {_sales.Count}");
                Console.WriteLine($"{"ID",-6} | {"Дата",-10} " +
                    $"| {"ID жив.",-8} | {"ID пок.",-8} | Цена");
                Console.WriteLine(new string('-', 52));
                foreach (Sales sale in _sales.TakeLast(count))
                {
                    Console.WriteLine(sale);
                }
                break;

            default:
                Console.WriteLine(
                    "Ошибка: выберите что-то из списка!");
                break;
        }
    }

    // 3. Удаление элементов (по ключу).
    public bool DeleteAnimal(int id)
    {
        Animals animal = _animals.FirstOrDefault(
            a => a.Id == id);
        if (animal == null)
        {
            Console.WriteLine(
                $"Животное с ID = {id} не найдено.");
            return false;
        }

        if (_sales.Any(s => s.AnimalId == id))
        {
            Console.WriteLine("Ошибка: нельзя удалить животное," +
                " так как оно связанно с продажами!");
            return false;
        }
        _animals.Remove(animal);
        Console.WriteLine($"Животное с ID = {id} удалено.");
        return true;
    }

    public bool DeleteBuyer(int id)
    {
        Buyers buyer = _buyers.FirstOrDefault(b => b.Id == id);
        if (buyer == null)
        {
            Console.WriteLine($"Покупатель с ID = {id} не найден.");
            return false;
        }

        if (_sales.Any(s => s.BuyerId == id))
        {
            Console.WriteLine("Ошибка: нельзя удалить " +
                "покупателя, так как у него есть записи " +
                "о продажах!");
            return false;
        }
        _buyers.Remove(buyer);
        Console.WriteLine(
            $"Покупатель с ID = {id} успешно удалён.");
        return true;
    }

    public bool DeleteSale(int id)
    {
        Sales sale = _sales.FirstOrDefault(s => s.Id == id);
        if (sale == null)
        {
            Console.WriteLine(
                $"Продажа с ID = {id} не найдена.");
            return false;
        }

        _sales.Remove(sale);
        Console.WriteLine(
            $"Продажа с ID = {id} успешно удалена.");
        return true;
    }


    // 4. Добавление элементов.
    // таблица живтоные
    public void Add(string species, string breed)
    {
        int newId = 1;
        if (_animals.Count > 0)
        {
            newId = _animals.Max(a => a.Id) + 1;
        }

        _animals.Add(new Animals(newId, species, breed));
        Console.WriteLine(
            $"Животное успешно добавлено с ID = {newId}.");
    }

    // таблица покупатели
    public void Add(string name, int age, string address)
    {
        int newId = 1;
        if (_buyers.Count > 0)
        {
            newId = _buyers.Max(b => b.Id) + 1;
        }

        _buyers.Add(new Buyers(newId, name, age, address));
        Console.WriteLine(
            $"Покупатель успешно добавлен с ID = {newId}.");
    }

    // таблица продаж
    public void Add(
        int animalId, int buyerId, DateTime date, int price)
    {
        bool animalExists = _animals.Any(a => a.Id == animalId);
        if (!animalExists)
        {
            throw new ArgumentException(
                $"Животного с ID = {animalId}" +
                $" не существует в базе!");
        }

        bool buyerExists = _buyers.Any(b => b.Id == buyerId);
        if (!buyerExists)
        {
            throw new ArgumentException(
                $"Покупателя с ID = {buyerId}" +
                $" не существует в базе!");
        }

        int newId = 1;
        if (_sales.Count > 0)
        {
            newId = _sales.Max(s => s.Id) + 1;
        }

        _sales.Add(new Sales(newId, animalId,
            buyerId, date, price));
        Console.WriteLine(
            $"Продажа успешно добавлена с ID = {newId}.");
    }


    // 6. Сохранение изменений в excel файле
    public void SaveDatabase(string filePath)
    {
        try
        {
            using var workbook = new XLWorkbook();

            workbook.Worksheets.Add("Продажи").Cell(1, 1)
                .InsertTable(_sales);
            workbook.Worksheets.Add("Покупатели").Cell(1, 1)
                .InsertTable(_buyers);
            workbook.Worksheets.Add("Животные").Cell(1, 1)
                .InsertTable(_animals);

            workbook.SaveAs(filePath);
            Console.WriteLine(
                "Изменения успешно сохранены в Excel!");
        }
        catch (IOException)
        {
            Console.WriteLine(
                "Ошибка: закройте файл Excel перед сохранением!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "Ошибка при сохранении: " + ex.Message);
        }
    }

    public void PrintList<T>(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    // 5. Реализация 4 запросов

    // Определить общее количество черепах
    // породы «Боксерская», представленных в базе данных
    public List<Animals> Query1()
    {
        var query = from animal in _animals
                    where animal.Species == "Черепаха" &&
                    animal.Breed == "Боксерская"
                    select animal;

        return query.ToList();
    }


    // Определите, на какую сумму купили кошек
    // породы «Сфинкс» в январе 2023 года.
    public int Query2()
    {
        var query = from sale in _sales
                    join animal in _animals
                    on sale.AnimalId equals animal.Id
                    where animal.Species == "Кошка"
                    && animal.Breed == "Сфинкс"
                    && sale.Date.Year == 2023
                    && sale.Date.Month == 1
                    select sale.Price;
        return query.Sum();
    }


    // Вывести перечень всех покупок
    //(имя покупателя, его возраст, вид и порода животного, цена)
    //совершённых покупателями старше 65 лет
    //на сумму более 8000 рублей
    public List<string> Query3()
    {
        var query = from sale in _sales
                    join buyers in _buyers
                    on sale.BuyerId equals buyers.Id

                    join animal in _animals
                    on sale.AnimalId equals animal.Id

                    where buyers.Age > 65
                    && sale.Price > 8000
                    select $"{buyers.Name,-22} | " +
                    $"{buyers.Age,-4} | {animal.Species,-10} " +
                    $"| {animal.Breed,-15} | {sale.Price} руб.";
        return query.ToList();
    }


    // Посчитать количество проданных хомяков покупателям из Москвы
    public int Query4()
    {
        var query = from sale in _sales
                    join buyers in _buyers
                    on sale.BuyerId equals buyers.Id

                    join animal in _animals
                    on sale.AnimalId equals animal.Id

                    where animal.Species == "Хомяк"
                    && buyers.Address == "Москва"
                    select sale;
        return query.Count();
    }


}
