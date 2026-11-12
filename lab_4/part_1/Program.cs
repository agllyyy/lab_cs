internal class Program
{
    static void Main(string[] args)
    {
        ////ЗАДАНИЕ 1

        //try
        //{
        //    int n = Checked.NaturalReadInt(
        //        "Введите кол-во элементов в основной список: ");

        //    List<string> L = Tasks15.ReadList(n, Checked.ReadString);

        //    Console.WriteLine($"\nОсновной список L:\n" +
        //        $"[{string.Join(", ", L)}]\n");

        //    Console.WriteLine("Какой фрагмент нужно заменить из L?");

        //    int n1 = Checked.NaturalReadInt(
        //        "Введите кол-во элементов в фрагменте: ");

        //    if (n1 > L.Count)
        //    {
        //        throw new ArgumentException(
        //            "Размер фрагмента больше основного списка!" +
        //            " Замена невозможна.");
        //    }

        //    List<string> L1 = Tasks15.ReadList(n1, Checked.ReadString);
        //    Console.WriteLine();

        //    Console.WriteLine("На что заменить фрагмент?");
        //    int n2 = Checked.NaturalReadInt(
        //        "Введите кол-во элементов в фрагмент для замены: ");

        //    List<string> L2 = Tasks15.ReadList(n2, Checked.ReadString);
        //    Console.WriteLine();

        //    List<string> rez = Tasks15.ReplaceList(L, L1, L2);

        //    Console.WriteLine("Итоговый список:");
        //    Console.WriteLine($"[{string.Join(", ", rez)}]");
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine("Ошибка: " + ex.Message);
        //}



        //// ЗАДАНИЕ 2

        //LinkedList<string> linkedList = 
        //    Tasks15.ReadLinkedList(Checked.ReadString);

        //Console.WriteLine($"\nИсходный связный список:\n" +
        //    $"[{string.Join(", ", linkedList)}]\n");

        //Tasks15.SortLinkedList(linkedList);

        //Console.WriteLine($"Отсортированный список:\n" +
        //    $"[{string.Join(", ", linkedList)}]");



        //// ЗАДАНИЕ 3

        //HashSet<string> allGames = new HashSet<string>
        //{ "Dota2", "CS2", "Minecraft", "Sims4", "GTA5" };

        //Console.WriteLine($"Доступный каталог игр: " +
        //    $"[{string.Join(", ", allGames)}]\n");

        //HashSet<string> student1 = new HashSet<string>
        //{ "Dota2", "CS2", "Minecraft" };
        //HashSet<string> student2 = new HashSet<string>
        //{ "Dota2", "Minecraft", "Sims4" };
        //HashSet<string> student3 = new HashSet<string>
        //{ "Dota2", "Minecraft" };

        //List<HashSet<string>> group = new List<HashSet<string>>
        //{ student1, student2, student3 };

        //Console.WriteLine("Состав группы:");
        //Console.WriteLine($"Студент 1 играет в: " +
        //    $"[{string.Join(", ", student1)}]");
        //Console.WriteLine($"Студент 2 играет в: " +
        //    $"[{string.Join(", ", student2)}]");
        //Console.WriteLine($"Студент 3 играет в: " +
        //    $"[{string.Join(", ", student3)}]\n");

        //Tasks15.StudentGame(allGames, group);




        //// ЗАДАНИЕ 4

        //string fileContent = Tasks15.ReadTextFile("input.txt");

        //if (fileContent != null)
        //{
        //    Console.WriteLine("Содержимое исходного файла:");
        //    Console.WriteLine($"\"{fileContent}\"");
        //    Console.WriteLine();

        //    Tasks15.PrintLetters(fileContent);
        //}



        ////ЗАДАНИЕ 5

        //string path = "Olimpiad.txt";

        //Tasks15.CreateTestFile(path);
        //Console.WriteLine();

        //string fileContent = Tasks15.ReadTextFile(path);

        //if (fileContent != null)
        //{
        //    Console.WriteLine("Содержимое исходного файла:");
        //    Console.WriteLine($"{fileContent}");
        //    Console.WriteLine();

        //    Console.WriteLine("Участники с max количеством баллов:");
        //    Tasks15.PrintWinners(fileContent);
        //}



    }
}
