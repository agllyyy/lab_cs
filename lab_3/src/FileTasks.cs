using System;
using System.IO;

internal static class FileTasks
{

        public static void WriteRandomBinary(string filePath, int count, bool isBinary)
    {
        Random rnd = new Random();

        if (isBinary) 
        {
            byte[] binFile= new byte[count * 4];

            for (int i = 0; i < count; i++)
            {
                int number = rnd.Next(-50, 51);
                byte[] numberBytes = BitConverter.GetBytes(number);

                for (int j = 0; j < 4; j++)
                {
                    binFile[i * 4 + j] = numberBytes[j];
                }
            }
            File.WriteAllBytes(filePath, binFile);
        }

        else
        {
            StreamWriter file = new StreamWriter(filePath, false);

            for (int i = 0; i < count; i++)
            {
                int number = rnd.Next(-50, 51);
                file.WriteLine(number);
            }
            file.Close();
        }
    }



    public static long? MulNegativeOdd(string filePath)
    {
        byte[] binFile = File.ReadAllBytes(filePath);

        int count = binFile.Length / 4;
        long rez = 1;
        bool isNegativeOdd = false;

        for (int i = 0; i < count; i++)
        {
            int number = BitConverter.ToInt32(binFile, i * 4);

            if (number < 0 && number % 2 != 0)
            {
                rez *= number;
                isNegativeOdd = true;
            }
        }

        if (isNegativeOdd)
        {
            return rez;
        }
        else
        {
            return null;
        }
    }


    public static long SumSquarEl(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);

        long sum = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            int number = int.Parse(lines[i]);
            sum += (long)number * number;
        }
        return sum;
    }




    public static int ReWrite
        (string filePath, string lastPath, int m)
    {
        string[] allLines = File.ReadAllLines(filePath);

        int count = 0;
        for (int i = 0; i < allLines.Length; i++)
        {
            if (allLines[i].Length == m)
            {
                count++;
            }
        }

        string[] line = new string[count];
        int index = 0;

        for (int i = 0; i < allLines.Length; i++)
        {
            if (allLines[i].Length == m)
            {
                line[index] = allLines[i];
                index++;
            }
        }
        File.WriteAllLines(lastPath, line);
        return count;
    }




    public static void WriteRandomStruct(string filePath, int rows, int cols)
    {
        Random rnd = new Random();
        string[] lines = new string[rows];

        for (int i = 0; i < rows; i++)
        {
            string[] numbers = new string[cols];
            for (int j = 0; j < cols; j++)
            {
                numbers[j] = rnd.Next(-10, 11).ToString();
            }
            lines[i] = string.Join(" ", numbers);
        }
        File.WriteAllLines(filePath, lines);
    }

    public static long MulEl(string fileWay)
    {
        string[] lines = File.ReadAllLines(fileWay);
        long mul = 1;

        for (int i = 0; i < lines.Length; i++)
        {
            string[] lineEl = lines[i].Split();

            for (int j = 0; j < lineEl.Length; j++)
            {
                int number = int.Parse(lineEl[j]);
                mul *= (long)number;
            }
        }
        return mul;
    }


}
