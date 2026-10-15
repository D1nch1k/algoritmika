using System;

class Program
{
    static void Main()
    {
        Program2;
        //
        // int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        // Array.Clear(numbers, 1, 3);
        // foreach (int number in numbers)
        // {
        //     Console.Write(number + " ");
        // }
        // Результат: 1 0 0 0 5

        //
        // int[] numbers = new int[]{1, 2, 3, 4, 5};
        // int [] ttt = new int[]{0, 0, 0, 0, 0};
        // Array.Copy(numbers, 2, ttt, 1, 3); //копирует из массива array1 начиная с индекс Index1, количество length элементов в массив аrray2 начиная с индекса Index2.

        // foreach (int a in ttt)
        // {
        //     Console.Write(a + " "); //
        // }

////
        int[][] a1 = new int[2][];
        int[, ] a2 = new int[4, 2];
        int[,, ] a3 = new int[4, 2, 3];
        Console.WriteLine("Измерение для массива a1:"+ a1.Rank);//1
        Console.WriteLine(" Измерение для массива a2: "+ a2.Rank);//2
        Console.WriteLine(" Измерение для массива a3: "+ a3.Rank);//3

        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        // Примеры поиска
        // Array.BinarySearch требует, чтобы массив был отсортирован!
        int index1 = Array.BinarySearch(numbers, 7);

        if (index1 >= 0)
        {
            Console.WriteLine("Значение 7 найдено на индексе: " + index1);
        }
        else
        {
            // Если не найдено, метод возвращает отрицательное число (побитовое дополнение индекса вставки)
            Console.WriteLine("Значение не найдено.");
    }
}
}


class Program2
{
    static void Main()
    {
        // 1. Двумерный массив
        int[,] grid = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        grid[0, 0] = 100; // Доступ к элементу

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write(grid[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Всего элементов: " + grid.Length + ", Размерность: " + grid.Rank);

        // 2. Трехмерный массив (2 слоя, 2 строки, 3 столбца)
        int[,,] cube = new int[2, 2, 3]
        {
            { { 1, 2, 3 }, { 4, 5, 6 } }, // Слой 0
            { { 7, 8, 9 }, { 10, 11, 12 } } // Слой 1
        };

        Console.WriteLine("\nТрехмерный массив:");
        for (int k = 0; k < cube.GetLength(0); k++)      // Слои
        {
            Console.WriteLine($"Слой {k}:");
            for (int i = 0; i < cube.GetLength(1); i++)  // Строки
            {
                for (int j = 0; j < cube.GetLength(2); j++) // Столбцы
                {
                    Console.Write(cube[k, i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("Всего элементов: " + cube.Length + ", Размерность: " + cube.Rank);
    }
}