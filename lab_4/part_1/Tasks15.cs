internal static class Tasks15
{
    public static bool ReplaceList
        (List<int> List, List<int> List1, List<int> List2)
    {
        if (List1 == null || List1.Count == 0) return false;

        int index = -1;
        int j;
        for (int i = 0; i <= List.Count - List1.Count; i++)
        {
            j = 0;
            while (j < List1.Count && List[i + j] == List1[j])
            {
                j++;
            }

            if (j == List1.Count)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            List.RemoveRange(index, List1.Count);
            List.InsertRange(index, List2);
            return true;
        }
        return false;
    }



    public static List<int> ReadList()
    {
        List<int> newList = new List<int>();

        uint size = Checked.ReadUint
            ($"Введите кол-во эл. в список: ");
        int element;
        Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            element = Checked.ReadInt($"Введите [{i}]: ");
            newList.Add(element);
        }

        return newList;
    }

    public static LinkedList<int> ReadLinkedList()
    {
        LinkedList<int> newLinkedList = new LinkedList<int>();

        uint size = Checked.ReadUint($"Введите кол-во эл. в " +
            $"связный список: ");
        Console.WriteLine();
        int element;

        for (int i = 0; i < size; i++)
        {
            element = Checked.ReadInt($"Введите [{i}]: ");
            newLinkedList.AddLast(element);
        }
        return newLinkedList;
    }




    public static void SortLinkedList(LinkedList<int> list)
    {
        if (list == null || list.Count < 2) return;

        LinkedList<int> sortedList = new LinkedList<int>();

        foreach (int value in list)
        {
            LinkedListNode<int> node = sortedList.First;

            while (node != null && node.Value < value)
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

        list.Clear();
        foreach (int value in sortedList)
        {
            list.AddLast(value);
        }
    }




    public static void StudentGame(
        HashSet<string> allGames, List<HashSet<string>> group)
    {
        if (group == null || group.Count < 1) return;

        HashSet<string> playAll = new (group[0]);
        playAll.IntersectWith(group[1]);
        playAll.IntersectWith(group[2]);


        HashSet<string> playSome = new(group[0]);
        playSome.UnionWith(group[1]);
        playSome.UnionWith(group[2]);


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
            Console.WriteLine
                ("Ошибка: Текстовый файл не найден по пути: "
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

    private static string[] ExtractWords(string rawText)
    {
        char[] separators = { ' ', ',', '.', '!', '?', '-',
                              ';', ':', '\n', '\r', '\t' };

        string[] words = rawText.Split(separators);

        int i = 0;
        while (i < words.Length)
        {
            words[i] = words[i].Trim().ToLower();
            i++;
        }
        return words;
    }

    private static HashSet<char> GetLettersOfWord(string word)
    {
        HashSet<char> wordLetters = new HashSet<char>();
        int charIndex = 0;

        while (charIndex < word.Length)
        {
            wordLetters.Add(word[charIndex]);
            charIndex++;
        }
        return wordLetters;
    }

    private static HashSet<char> FindCommonLetters(string[] words)
    {
        HashSet<char> commonLetters = null;
        int w = 0;

        while (w < words.Length)
        {
            string currentWord = words[w];

            if (currentWord.Length == 0)
            {
                w++;
                continue;
            }

            HashSet<char> wordLetters = GetLettersOfWord(currentWord);

            if (commonLetters == null)
            {
                commonLetters = new HashSet<char>(wordLetters);
            }
            else
            {
                commonLetters.IntersectWith(wordLetters);
            }
            w++;
        }
        return commonLetters;
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
                Console.WriteLine(kvp.Key);
            }
        }
    }

}
