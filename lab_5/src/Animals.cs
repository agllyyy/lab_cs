internal class Animals
{
    private int _id;
    private string _species;
    private string _breed;


    public Animals(int id, string species, string breed)
    {
        Id = id;
        Species = species;
        Breed = breed;
    }

    // проверку в свойствах не забудь 
    public int Id
    {
        get {  return _id; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException
                    ("ID должен быть положительным числом.");
            _id = value;
        }
    }

    public string Species { get; private set; }
    public string Breed { get; private set; }


    public override string ToString()
    {
        return $"[{_id}] {_species}, {_breed}";
    }

}
