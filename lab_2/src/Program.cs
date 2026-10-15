using System.Threading.Channels;

internal class Program
{
    static void Main(string[] args)
    {
        Checked ch = new Checked();

        //// задача 1.2 и 1.3
        //Console.Write("Введите имя: ");
        //string? name1 = Console.ReadLine();
        //int hight1 = ch.ReadInt("Введите рост: ");
        //Human human1 = new Human(name1, hight1);
        //Console.WriteLine();

        //Console.Write("Введите имя: ");
        //string? name2 = Console.ReadLine();
        //int hight2 = ch.ReadInt("Введите рост: ");
        //Human human2 = new Human(name2, hight2);
        //Console.WriteLine();

        //Console.Write("Введите имя: ");
        //string? name3 = Console.ReadLine();
        //int hight3 = ch.ReadInt("Введите рост: ");
        //Human human3 = new Human(name3, hight3);
        //Console.WriteLine();

        //Console.WriteLine(human1);
        //Console.WriteLine(human2);
        //Console.WriteLine(human3);
        //Console.WriteLine();
        //Console.WriteLine();


        //Console.Write("Введите имя: ");
        //string? imya1 = Console.ReadLine();        
        //int rost1 = ch.ReadInt("Введите рост: ");
        //Console.WriteLine();


        //Console.Write("Введите фамилию: ");
        //string? fam2 = Console.ReadLine();
        //Console.Write("Введите имя: ");
        //string? imya2 = Console.ReadLine();
        //Console.Write("Введите отчество: ");
        //string? otch2 = Console.ReadLine();
        //int rost2 = ch.ReadInt("Введите рост: ");
        //Console.WriteLine();

        //Console.Write("Введите фамилию: ");
        //string? fam3 = Console.ReadLine();
        //Console.Write("Введите имя: ");
        //string? imya3 = Console.ReadLine();
        //int rost3 = ch.ReadInt("Введите рост: ");
        //Console.WriteLine();

        //Name n1 = new Name(null, imya1, null);
        //Name n2 = new Name(fam2, imya2, otch2);
        //Name n3 = new Name(fam3, imya3, null);

        //Console.WriteLine();

        //Console.WriteLine(n1);
        //Console.WriteLine(n2);
        //Console.WriteLine(n3);
        //Console.WriteLine();


        //// задача 2.2
        //HumanWithName h1 = new HumanWithName(n1, rost1);
        //HumanWithName h2 = new HumanWithName(n2, rost2);
        //HumanWithName h3 = new HumanWithName(n3, rost3);
        //Console.WriteLine(h1);
        //Console.WriteLine(h2);
        //Console.WriteLine(h3);
        //Console.WriteLine();
        //Console.WriteLine();


        // задача 3.3

        Cities A = new Cities("A", 3);
        Cities B = new Cities("B", 2);
        Cities C = new Cities("C", 2);
        Cities D = new Cities("D", 3);
        Cities E = new Cities("E", 1);
        Cities F = new Cities("F", 2);

        A.AddWay(new Way(B, 5));
        A.AddWay(new Way(F, 1));
        A.AddWay(new Way(D, 6));

        B.AddWay(new Way(A, 5));
        B.AddWay(new Way(C, 3));

        C.AddWay(new Way(B, 3));
        C.AddWay(new Way(D, 4));

        D.AddWay(new Way(C, 4));
        D.AddWay(new Way(E, 2));
        D.AddWay(new Way(A, 6));

        E.AddWay(new Way(F, 2));

        F.AddWay(new Way(B, 1));
        F.AddWay(new Way(E, 2));


        //// задача 4.8
        //Cities B = new Cities("B");
        //Cities C = new Cities("C");
        //Cities D = new Cities("D");
        //Cities E = new Cities("E");
        //Cities F = new Cities("F");


        //Cities A = new Cities("A", new Way[]
        //{
        //    new Way(B, 5),
        //    new Way(F, 1),
        //    new Way(D, 6)
        //});

        //B.AddWay(new Way(A, 5));
        //B.AddWay(new Way(C, 3));

        //C.AddWay(new Way(B, 3));
        //C.AddWay(new Way(D, 4));

        //D.AddWay(new Way(C, 4));
        //D.AddWay(new Way(E, 2));
        //D.AddWay(new Way(A, 6));

        //E.AddWay(new Way(F, 2));

        //F.AddWay(new Way(B, 1));
        //F.AddWay(new Way(E, 2));

        //Cities[] graf = new Cities[6];
        //graf[0] = A;
        //graf[1] = B;
        //graf[2] = C;
        //graf[3] = D;
        //graf[4] = E;
        //graf[5] = F;
        //for (int i = 0; i < graf.Length; i++)
        //{
        //    Console.WriteLine(graf[i]);
        //}


        //// задача 5.5
        //Console.WriteLine("\nВведите 1 дробь.");
        //int num1 = ch.ReadInt("Введите числитель: ");
        //int den1 = ch.ReadInt("Введите знаменатель: ");

        //Fraction dr1 = new Fraction(num1, den1);
        //Console.WriteLine(dr1);

        //Console.WriteLine("\nВведите 2 дробь.");
        //int num2 = ch.ReadInt("Введите числитель: ");
        //int den2 = ch.ReadInt("Введите знаменатель: ");

        //Fraction dr2 = new Fraction(num2, den2);
        //Console.WriteLine(dr2);

        //Console.WriteLine("\nВведите 3 дробь.");
        //int num3 = ch.ReadInt("Введите числитель: ");
        //int den3 = ch.ReadInt("Введите знаменатель: ");

        //Fraction dr3 = new Fraction(num3, den3);
        //Console.WriteLine(dr3);

        //Console.Write($"\nРешение примера: " +
        //    $"{dr1} + {dr2} / {dr3} - 5 = " +
        //    $"{dr1.Sum(dr2).Div(dr3).Minus(5)}\n");


        //// примеры решений для всех методов
        //Console.WriteLine($"\n{dr1} + {dr2} = {dr1.Sum(dr2)}");
        //Console.WriteLine($"{dr3} + 5 = {dr3.Sum(5)}\n");

        //Console.WriteLine($"{dr1} * {dr2} = {dr1.Mul(dr2)}");
        //Console.WriteLine($"{dr3} * 5 = {dr3.Mul(5)}\n");

        //Console.WriteLine($"{dr1} - {dr2} = {dr1.Minus(dr2)}");
        //Console.WriteLine($"{dr3} - 5 = {dr3.Minus(5)}\n");

        //Console.WriteLine($"({dr1}) / ({dr2}) = {dr1.Div(dr2)}");
        //Console.WriteLine($"({dr3}) / 5 = {dr3.Div(5)}\n");
    }
}

