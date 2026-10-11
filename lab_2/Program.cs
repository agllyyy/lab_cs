internal class Program
{
    static void Main(string[] args)
    {
        // задача 1.2 и 1.3
        Human human1 = new Human("Клеопатра",152);
        Human human2 = new Human("Пушкин", 167);
        Human human3 = new Human("Владимир", 189);
        Console.WriteLine(human1);
        Console.WriteLine(human2);
        Console.WriteLine(human3);
        Console.WriteLine();

        Name n1 = new Name(null, "Клеопатра", null);
        Name n2 = new Name("Пушкиин", "Александр", "Сергеевич");
        Name n3 = new Name("Маяковский", "Владимир", null);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine();


        // задача 2.2
        HumanWithName h1 = new HumanWithName(n1, 152);
        HumanWithName h2 = new HumanWithName(n2, 167);
        HumanWithName h3 = new HumanWithName(n3, 189);
        Console.WriteLine(h1);
        Console.WriteLine(h2);
        Console.WriteLine(h3);
        Console.WriteLine();

        // задача 3.3

        // задача 4.8

        // задача 5.5


    }
}

