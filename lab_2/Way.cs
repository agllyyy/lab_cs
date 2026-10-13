using System.Xml.Linq;

internal class Way
{
    private Cities _city;
    private int _price;

    public Way(Cities city, int price)
    {
        City = city;
        Price = price;
    }

    public Cities City
    {
        get { return _city; }
        private set
        {
            if (value != null)
            {
                _city = value;
            }
            else
            {
                Console.WriteLine("Ошибка! Объект пуст!");
            }
        }
    }

    public int Price
    {
        get { return _price; }
        private set
        {
            if (value > 0)
            {
                _price = value;
            }
            else
            {
                Console.WriteLine($"Ошибка! Стоимости - {value} нет на рис.2!");
                _price = 1;
            }
        }
    }

    public override string ToString()
    {
        string s = $"{City.NameCity}:{Price}";
        return s;
    }

}

