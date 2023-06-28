namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        //1.
        int[,] array = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
        };

        int maxIndex = int.MinValue;
        int rowIndex = -1;
        int columnIndex = -1;

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] > maxIndex)
                {
                    maxIndex = array[i, j];
                    rowIndex = i;
                    columnIndex = j;
                }
            }
        }
        Console.WriteLine("Max index: " + maxIndex);
        Console.WriteLine("Row index: " + rowIndex);
        Console.WriteLine("Column index: " + columnIndex);
        Console.WriteLine("\n");


        //2.
        int n = 11;
        string[,] array1 = new string[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array1[i, j] = ".";
            }
        }

        int middleRow = n / 2;
        for (int j = 0; j < n; j++)
        {
            array1[middleRow, j] = "*";
        }

        int middleColumn = n / 2;
        for (int i = 0; i < n; i++)
        {
            array1[i, middleColumn] = "*";
        }

        for (int i = 0; i < n; i++)
        {
            array1[i, i] = "*";
        }

        for (int i = 0; i < n; i++)
        {
            array1[i, n - 1 - i] = "*";
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        //3.
        int[,] arr = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
        };

        int m = arr.GetLength(0);

        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m - 1 - i; j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[m - 1 - j, m - 1 - i];
                arr[m - 1 - j, m - 1 - i] = temp;
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");


        //4.
        int[,] array2 = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 },
        { 10, 11, 12 }
        };

        int n1 = array2.GetLength(0);
        int m1 = array2.GetLength(1);

        int[,] rotatedArray = new int[m1, n1];

        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                rotatedArray[j, n1 - 1 - i] = array2[i, j];
            }
        }

        Console.WriteLine("Original Array:");
        DisplayArray(array2);
        Console.WriteLine("Rotated Array:");
        DisplayArray(rotatedArray);
    }

    private static void DisplayArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

