internal class HumanWithName
{
    private Name _name;
    private int _height;

    public HumanWithName(Name name, int height)
    {
        Name = name;
        Height = height;
    }

    public Name Name
    {
        get { return _name; }
        private set
        {
            if (value != null)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Ошибка! Объект пуст!");
                _name = new Name(null, "Кто-то", null);
            }
        }
    }

    public int Height
    {
        get { return _height; }
        private set
        {
            if (value > 0)
            {
                _height = value;
            }
            else
            {
                Console.WriteLine("Ошибка значения роста!" +
                    " Рост не моежт быть отрицательным");
                _height = 170;
            }
        }
    }

    public override string ToString()
    {
        string s = $"{Name}, рост: {Height}";
        return s;
    }
}