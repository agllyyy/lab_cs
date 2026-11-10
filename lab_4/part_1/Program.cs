internal class Program
{
    static void Main(string[] args)
    {
    //    // ЗАДАНИЕ 1 

    //    List<int> List = Tasks15.ReadList();
    //    Console.WriteLine($"\nОсновной список L:\n" +
    //        $"[{string.Join(", ", List)}]\n");

    //    Console.WriteLine($"Какой фрагмент нужно заменить из L?");
    //    List<int> List1 = Tasks15.ReadList();
    //    Console.WriteLine();

    //    Console.WriteLine($"На что заменить фрагмент?");
    //    List<int> List2 = Tasks15.ReadList();
    //    Console.WriteLine();

    //    bool Rez = Tasks15.ReplaceList(List, List1, List2);

    //    Console.WriteLine("Итоговый список L:");
    //    if (Rez)
    //    {
    //        Console.WriteLine($"[{string.Join(", ", List)}]");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"[{string.Join(", ", List)}] (Фрагмент не найден, список не изменился)");
    //    }



        //// ЗАДАНИЕ 2

        //LinkedList<int> linkedList = Tasks15.ReadLinkedList();
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

        //    Console.WriteLine("Участники с max кол-ом баллов:");
        //    Tasks15.PrintWinners(fileContent);
        //}



    }
}
