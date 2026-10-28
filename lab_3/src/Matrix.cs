
internal class Matrix
{
    private double[,] _matrix;

    public Matrix(int n, int m)
    {
        _matrix = new double[n, m];

        for (int j = 0; j < _matrix.GetLength(1); j++)
        {
            for (int i = _matrix.GetLength(0) - 1; i >= 0; i--)
            {
                _matrix[i, j] = Checked.ReadDouble
                    ($"Введите элемент [{i}, {j}]: ");
            }
        }
    }
    public Matrix(int n, bool popRandom)
    {
        Random rnd = new Random();
        _matrix = new double[n, n];

        if (popRandom)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    _matrix[i, j] = rnd.NextDouble() * (100 - (-100)) + (-100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    _matrix[i, j] = rnd.NextDouble() * (45.675 - (-4.5)) + (-4.5);
                }
            }
        }
    }

    public Matrix(int n)
    {
        _matrix = new double[n, n];
        int num = 1;

        for (int d = 0; d < n; d++)
        {
            if (d % 2 == 0)
            {
                for (int i = d; i >= 0; i--)
                {
                    int j = d - i;
                    _matrix[i, j] = num++;
                }
                
            }
            else 
            {
                for (int i = 0; i <= d; i++)
                {
                    int j = d - i;
                    _matrix[i, j] = num++;
                }
            }
        }
    }


    public Matrix(int n, int m, bool popRandom)
    {
        _matrix = new double[n, m];

        if (popRandom)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _matrix[i, j] = rnd.Next(0, 11);
                }
            }
        }
    }



    public int Rows
    {
        get { return _matrix.GetLength(0); }
    }
    public int Cols
    {
        get { return _matrix.GetLength(1); }
    }

    public double this[int i, int j]
    {
        get
        {
            return _matrix[i, j];
        }
        set
        {
            _matrix[i, j] = value;
        }
    }



    public double? GetMinDuplicate()
    {
        int rows = Rows;
        int cols = Cols;
        int allLenght = rows * cols;

        double[] arr = new double[allLenght];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[index] = _matrix[i, j];
                index++;
            }
        }

        Array.Sort(arr);

        for (int i = 0; i < allLenght - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                return arr[i];
            }
        }
        return null;
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new ArgumentException
                ("Размеры матриц не совпадают!");
        }

        Matrix rez = new Matrix(a.Rows, a.Cols, false);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                rez[i, j] = a[i, j] + b[i, j];
            }
        }
        return rez;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new ArgumentException
                ("Размеры матриц не совпадают!");
        }

        Matrix rez = new Matrix(a.Rows, a.Cols, false);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                rez[i, j] = a[i, j] - b[i, j];
            }
        }
        return rez;
    }

    public static Matrix operator *(int number, Matrix a)
    {
        Matrix rez = new Matrix(a.Rows, a.Cols, false);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                rez[i, j] = a[i, j] * number;
            }
        }
        return rez;
    }

    public static Matrix operator *(Matrix a, int number)
    {
        return  number * a;
    }


    public Matrix Transpose()
    {
        Matrix rez = new Matrix(Cols, Rows, false);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                rez[j, i] = _matrix[i, j];
            }
        }

        return rez;
    }




    public override string ToString()
    {
        string rez = "";
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                rez += _matrix[i, j] + "\t";
            }
            rez += "\n";
        }
        return rez;
    }
}

