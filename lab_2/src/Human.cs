internal class Human
{
    private string _name;
    private int _height;

    public Human(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public string Name
    {
        get { return _name; }
        private set
        {
            if (value != null && value != " " && value != "")
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Ошибка имени!");
                _name = "Кто-то";
            }
        }
    }
    public int Height
    {
        get { return _height; }
        private set
        {
            if (value >= 120 && value <= 220)
            {
                _height = value;
            }
            else
            {
                Console.WriteLine("Ошибка значения роста!" +
                    " Рост должен быть в диапазоне (120-220)");
                _height = 170;
            }
        }
    }

    public override string ToString()
    {
        string s = $"{Name}, рост: {_height}";
        return s;
    }
}