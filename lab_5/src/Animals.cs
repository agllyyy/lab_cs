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
    public string Species
    {
        get => _species;
        private set => _species = !string.IsNullOrWhiteSpace(
            value)
            ? value.Trim()
            : throw new ArgumentException(
                "Вид животного не может быть пустым!");
    }

    public string Breed
    {
        get => _breed;
        private set => _breed = string.IsNullOrWhiteSpace(value)
            ? "Без породы"
            : value.Trim();
    }


    public override string ToString() =>
    $"{Id,-5} | {Species,-12} | {Breed,-18}";


}
