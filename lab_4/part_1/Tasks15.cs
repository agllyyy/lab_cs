internal static class Tasks15
{

    // должно возвращать список + должны быть не int  в списка а любые кроч переделать!!!!!!!!
    public static List<T> ReplaceList<T>(
    List<T> L, List<T> L1, List<T> L2)
    {
        if (L == null) return null;

        List<T> rez = new List<T>(L);

        if (L1 == null || L2 == null ||
            L1.Count == 0 || L1.Count > rez.Count)
        {
            return rez;
        }

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        for (int i = 0; i <= rez.Count - L1.Count; i++)
        {
            bool isMatch = true;

            for (int j = 0; j < L1.Count; j++)
            {
                if (!object.Equals(rez[i + j], L1[j]))
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch)
            {
                rez.RemoveRange(i, L1.Count);
                rez.InsertRange(i, L2);
                break;
            }
        }

        return rez;
    }


    //
    public static List<T> ReadList<T>(
     int count, Func<string, T> readElement)
    {
        if (count < 0)
        {
            throw new ArgumentException(
                "Количество элементов не может быть" +
                " отрицательным!");
        }

        List<T> newList = new List<T>(count);

        for (int i = 0; i < count; i++)
        {
            T element = readElement($"Введите [{i}]: ");
            newList.Add(element);
        }

        return newList;
    }

    //
    public static LinkedList<T> ReadLinkedList<T>(
    Func<string, T> readElement)
    {
        LinkedList<T> newLinkedList = new LinkedList<T>();

        uint size = Checked.ReadUint(
            "Введите кол-во эл. в связный список: ");
        Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            T element = readElement($"Введите [{i}]: ");
            newLinkedList.AddLast(element);
        }

        return newLinkedList;
    }



    public static void SortLinkedList<T>(LinkedList<T> list)
    {
        if (list == null || list.Count < 2) return;

        LinkedList<T> sortedList = new LinkedList<T>();
        Comparer<T> comparer = Comparer<T>.Default;

        while (list.Count > 0)
        {
            T value = list.First.Value;
            list.RemoveFirst();

            LinkedListNode<T> node = sortedList.First;

            while (node != null &&
                   comparer.Compare(node.Value, value) < 0)
            {
                node = node.Next;
            }

            if (node == null)
            {
                sortedList.AddLast(value);
            }
            else
            {
                sortedList.AddBefore(node, value);
            }
        }

        foreach (T value in sortedList)
        {
            list.AddLast(value);
        }
    }




    public static void StudentGame(
        HashSet<string> allGames, List<HashSet<string>> group)
    {
        if (group == null || group.Count < 1) return;

        HashSet<string> playAll = new(group[0]);
        HashSet<string> playSome = new(group[0]);

        for (int i = 1; i < group.Count; i++)
        {
            playAll.IntersectWith(group[i]); 
            playSome.UnionWith(group[i]);
        }

        HashSet<string> playNobody = new (allGames);
        playNobody.ExceptWith(playSome);


        Console.WriteLine
            ($"Играют все: " +
            $"[{string.Join(", ", playAll)}]");
        Console.WriteLine
            ($"Играют некоторые: " +
            $"[{string.Join(", ", playSome)}]");
        Console.WriteLine
            ($"Не играет ни один: " +
            $"[{string.Join(", ", playNobody)}]");
    }


    //
    public static string ReadTextFile(string filePath)
    {
        StreamReader reader = null;
        string fileContent = "";

        try
        {
            reader = new StreamReader(filePath);
            fileContent = reader.ReadToEnd();

            if (fileContent.Trim() == "")
            {
                Console.WriteLine(
                    "Ошибка: Текстовый файл пуст!");
                return null;
            }
            return fileContent;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine(
                "Ошибка: Текстовый файл не найден по пути: "
                + filePath);
            return null;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Ошибка ввода-вывода: " + 
                ex.Message);
            return null;
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
        }
    }
    //
    private static string[] ExtractWords(string rawText)
    {
        char[] separators = { ' ', ',', '.', '!', '?', '-',
                              ';', ':', '\n', '\r', '\t' };

        string[] words = rawText.Split(
            separators, StringSplitOptions.RemoveEmptyEntries);

        int i = 0;
        while (i < words.Length)
        {
            words[i] = words[i].Trim().ToLower();
            i++;
        }
        return words;
    }


    public static void PrintLetters(string text)
    {
        HashSet<char> consonants = new HashSet<char>()
        {
            'к', 'п', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'
        };

        string[] words = ExtractWords(text);
        if (words.Length == 0) return;

        HashSet<char> lettersInAllWords = new HashSet<char>(
            words[0]);

        for (int i = 1; i < words.Length; i++)
        {
            lettersInAllWords.IntersectWith(words[i]);
        }
        consonants.ExceptWith(lettersInAllWords);

        List<char> sortedRez= new List<char>(consonants);
        sortedRez.Sort();


        Console.WriteLine("Глухие согласные, которые НЕ " +
            "входят хотя бы в одно слово:");
        foreach (char letter in sortedRez)
        {
            Console.Write(letter + " ");
        }

        Console.WriteLine();
    }

    //
    public static void CreateTestFile(string filePath)
    {
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(filePath);

            writer.WriteLine("7");
            writer.WriteLine("Петрова Ольга 25 18 16");
            writer.WriteLine("Калиниченко Иван 14 19 15");
            writer.WriteLine("Иванов Алексей 25 16 25");
            writer.WriteLine("Сидоров Петр 10 12 15");
            writer.WriteLine("Смирнова Анна 15 15 13");
            writer.WriteLine("Калиниченко Ольга 25 0 25");
            writer.WriteLine("Петров Иван 25 25 0");

            Console.WriteLine($"Файл создан: {filePath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine(
                "Ошибка при записи файла: " + ex.Message);
        }
        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }
    }


    public static void PrintWinners(string text)
    {
        if (text == null) return;

        string[] lines = text.Split(
            new[] { '\r', '\n' }, 
            StringSplitOptions.RemoveEmptyEntries);

        int count = int.Parse(lines[0]);
        Dictionary<string, int> participants =
            new Dictionary<string, int>(count);


        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split();

            if (data.Length >= 5)
            {
                string fullName = $"{data[0]} {data[1]}";
                int allSum = int.Parse(data[2]) + 
                             int.Parse(data[3]) + 
                             int.Parse(data[4]);

                if (!participants.ContainsKey(fullName))
                {
                    participants.Add(fullName, allSum);
                }
            }
        }

        int maxPoints = -1;
        foreach (KeyValuePair<string, int> kvp in participants)
        {
            if (kvp.Value > maxPoints)
            {
                maxPoints = kvp.Value;
            }
        }

        foreach (KeyValuePair<string, int> kvp in participants)
        {
            if (kvp.Value == maxPoints)
            {
                Console.WriteLine($"{kvp.Key } - { maxPoints} баллов");
            }
        }
    }

}
