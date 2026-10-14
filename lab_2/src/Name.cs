
internal class Name
{
    private string _lastName;
    private string _firstName;
    private string _patronymic;

    public Name
        (string lastName, string firstName, string patronymic)
    {
        LastName = lastName;
        FirstName = firstName;
        Patronymic = patronymic;
    }

    public string FirstName
    {
        get { return _firstName; }
        private set
        {
            _firstName = value;
        }
    }
    public string LastName
    {
        get { return _lastName; }
        private set
        {
            _lastName = value;
        }
    }
    public string Patronymic
    {
        get { return _patronymic; }
        private set
        {
            _patronymic = value;
        }
    }

    public override string ToString()
    {
        string rez = "";
        if (LastName != null)
        {
            rez += LastName;
        }

        if (FirstName != null)
        {
            if (rez != "")
            {
                rez += " ";
            }
            rez += FirstName;
        }

        if (Patronymic != null)
        {
            if (rez != "")
            {
                rez += " ";
            }
            rez += Patronymic;
        }
        return rez;
    }
}

