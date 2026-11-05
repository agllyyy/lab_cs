using System.Drawing;
using System.Xml.Linq;

internal class Money
{
    private uint _rubles;
    private byte _kopeks;

    public Money(uint rubles, byte kopeks)
    {
        Rubles = rubles;
        Kopeks = kopeks;
    }

    public uint Rubles
    {
        get { return _rubles; }
        private set { _rubles = value; }
    }

    public byte Kopeks
    {
        get { return _kopeks; }
        private set
        {
            if (value >= 100)
            {
                _rubles += (uint)(value / 100);
                _kopeks = (byte)(value % 100);
            }
            else
            {
                _kopeks = value;
            }
        }
    }

    public Money AddKopeks(uint numKopeks)
    {
        uint allKopeks = (uint)Kopeks + numKopeks;

        Rubles += allKopeks / 100;
        Kopeks = (byte)(allKopeks % 100);

        return new Money(Rubles, Kopeks);
    }



    public static Money operator ++(Money cash)
    {
        return new Money(cash.Rubles, (byte)(cash.Kopeks + 1));
    }

    public static Money operator --(Money cash)
    {
        uint allKopeks = (uint)cash.Rubles * 100 + cash.Kopeks;

        if (allKopeks == 0)
        {
            throw new InvalidOperationException
                ("Ошибка: Баланс не может стать отрицательным!");
        }

        allKopeks--;
        uint newRubles = allKopeks / 100;
        byte newKopeks = (byte)(allKopeks % 100);

        return new Money(newRubles, newKopeks);
    }




    public static Money operator +(Money cash, uint number)
    {
        return new Money(cash.Rubles + number, cash.Kopeks);
    }

    public static Money operator +(uint number, Money cash)
    {
        return new Money(cash.Rubles + number, cash.Kopeks);
    }

    public static Money operator -(Money cash, uint number)
    {
        if (number > cash.Rubles)
        {
            throw new InvalidOperationException
                ("Результат вычитания не может быть" +
                " отрицательным числом!");
        }
        return new Money(cash.Rubles - number, cash.Kopeks);
    }

    public static Money operator -(uint number, Money cash)
    {
        uint cashKopeks = cash.Rubles * 100 + cash.Kopeks;
        uint numberKopeks = number * 100;

        if (cashKopeks > numberKopeks)
        {
            throw new InvalidOperationException
                ("Результат вычитания не может быть" +
                " отрицательным числом!");
        }
        uint rez = numberKopeks - cashKopeks;

        return new Money(rez / 100, (byte)(rez % 100));
    }




    // явное
    public static explicit operator uint(Money cash)
    {
        return cash.Rubles;
    }

    // неявное
    public static implicit operator double(Money cash)
    {
        return cash.Kopeks / 100.0; ;
    }



    public override string ToString()
    {
        return $"{_rubles} руб. {_kopeks} коп.";
    }
}
