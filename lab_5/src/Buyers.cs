internal class Buyers
{
    private int _id;
    private string _name;
    private int _age;
    private string _address;


    public Buyers(int _id, string _name, int _age, string _address)
    {
        Id = _id;
        Name = _name;
        Age = _age;
        Address = _address;

    }

    // проверку в свойствах не забудь 
    public int Id
    {
        get { return _id; }
        private set => _id = value > 0
            ? value
            : throw new ArgumentException
            ("ID должен быть положительным числом.");
    }

    public string Name
    {
        get => _name;
        private set => _name = !string.IsNullOrWhiteSpace(value)
            ? value.Trim()
            : throw new ArgumentException
            ("Имя не может быть пустым!");
    }

    public int Age
    {
        get => _age;
        private set => _age = value >= 18
            ? value
            : throw new ArgumentException
            ("Возраст покупателя должен быть не меньше 18 лет.");
    }

    public string Address
    {
        get => _address;
        private set => _address = !string.IsNullOrWhiteSpace(value)
            ? value.Trim()
            : throw new ArgumentException
            ("Адрес не может быть пустым!");
 
    }


    public override string ToString() =>
    $"{Id,-5} | {Name,-26} | {Age,-4} | {Address}";



}