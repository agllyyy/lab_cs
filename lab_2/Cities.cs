internal class Cities
{
    private string _nameCity;
    private Way[] _ways;
    private int _countWays;

    public Cities(string nameCity, int maxWays)
    {
        NameCity = nameCity;
        _ways = new Way[maxWays];
        _countWays = 0;
    }

    // 4.8
    public Cities(string nameCity)
    {
        NameCity = nameCity;
        _ways = new Way[10];
        _countWays = 0;
    }

    // 4.8
    public Cities(string nameCity, Way[] masWays)
    {
        NameCity = nameCity;
        _ways = new Way[masWays.Length];

        for (int i = 0; i < masWays.Length; i++)
        {
            _ways[i] = masWays[i];
        }
        _countWays = masWays.Length;
    }


    public string NameCity
    {
        get { return _nameCity; }
        private set { _nameCity = value; }
    }

    public Way[] Ways
    {
        get { return _ways; }
    }

    public void AddWay(Way newWay)
    {
        if (_countWays < _ways.Length)
        {
            _ways[_countWays] = newWay;
            _countWays++;
        }
        else
        {
            Console.WriteLine($"Ошибка! В городе {_nameCity}" +
                $" нельзя добавить больше путей!");
        }
    }

    public override string ToString()
    {
        string rez = $"{NameCity}: ";
        if ( _countWays == 0)
        {
            return rez + "нет выходящих путей";
        }

        for (int i = 0; i < _countWays; i++) 
        {
            rez += _ways[i];

            if (i < _countWays - 1)
            {
                rez += ", ";
            }
        }
        return rez;
    }
}