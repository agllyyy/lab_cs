internal class Fraction
{ 
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public int Numerator
    {
        get { return _numerator; }
        private set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        private set { _denominator = value; }
    }

    // сложение
    public Fraction Sum(int num)
    {
        int newNum = _numerator + num * _denominator;
        int newDen = _denominator;

        return new Fraction(newNum, newDen);
    }

    public Fraction Sum(Fraction dr)
    {
        int newNum = _numerator * dr.Denominator +
            dr.Numerator * _denominator;
        int newDen = _denominator * dr.Denominator;

        return new Fraction(newNum, newDen);
    }

    // вычитание
    public Fraction Minus(int num)
    {
        int newNum = _numerator - num * _denominator;
        int newDen = _denominator;

        return new Fraction(newNum, newDen);
    }

    public Fraction Minus(Fraction dr)
    {
        int newNum = _numerator * dr.Denominator -
            dr.Numerator * _denominator;
        int newDen = _denominator * dr.Denominator;

        return new Fraction(newNum, newDen);
    }

    // умножение
    public Fraction Mul(int num)
    {
        int newNum = _numerator * num;
        int newDen = _denominator ;

        return new Fraction(newNum, newDen);
    }

    public Fraction Mul(Fraction dr)
    {
        int newNum = _numerator * dr.Numerator;
        int newDen = _denominator * dr.Denominator;

        return new Fraction(newNum, newDen);
    }

    // деление
    public Fraction Div(int num)
    {
        int newNum = _numerator;
        int newDen = _denominator * num;

        return new Fraction(newNum, newDen);
    }

    // деление с др дробью
    public Fraction Div(Fraction dr)
    {
        int newNum = _numerator * dr.Denominator;
        int newDen = _denominator * dr.Numerator;

        return new Fraction(newNum, newDen);
    }


    public override string ToString()
    {
        string rez = $"{Numerator}/{Denominator}";
        return rez;
    }
}
