internal class Sales
{
    private int _id;
    private int _idAnimal;
    private int _idBuyers;
    private DateTime _date;
    private int _price;

    public Sales(int _id, int _idAnimal, 
        int _idBuyers, DateTime _date, int _price)
    {
        Id = _id;
        AnimalId = _idAnimal;
        BuyerId = _idBuyers;
        Date = _date;
        Price = _price;
    }

    public int Id
    {
        get { return _id; }
        private set => _id = value > 0
            ? value
            : throw new ArgumentException
            ("ID должен быть положительным числом.");
    }

    public int AnimalId
    {
        get => _idAnimal;
        private set => _idAnimal = value > 0
            ? value
            : throw new ArgumentException
            ("ID животного должен быть положительным числом.");
    }

    public int BuyerId
    {
        get => _idBuyers;
        private set => _idBuyers = value > 0
            ? value
            : throw new ArgumentException
            ("ID покупателя должен быть положительным числом.");
    }

    public DateTime Date
    {
        get => _date;
        private set => _date = value;
    }

    public int Price
    {
        get => _price;
        private set => _price = value >= 0
            ? value
            : throw new ArgumentException
            ("Цена не может быть отрицательной.");
    }


    public override string ToString() =>
    $"{Id,-6} | {Date:dd.MM.yyyy} | {AnimalId,-8} |" +
        $" {BuyerId,-8} | {Price} руб.";


}