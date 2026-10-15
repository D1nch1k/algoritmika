using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1. МАССИВЫ: ОСНОВЫ ===");
        
        // Одномерный массив
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Console.WriteLine($"Длина: {numbers.Length}, Размерность: {numbers.Rank}"); 
        // Результат: Длина: 10, Размерность: 1

        // Двумерный массив
        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine($"Двумерный: Длина {matrix.Length}, Размерность {matrix.Rank}"); 
        // Результат: Двумерный: Длина 6, Размерность 2

        // Трехмерный массив
        int[,,] cube = new int[2, 2, 2];
        Console.WriteLine($"Трехмерный: Длина {cube.Length}, Размерность {cube.Rank}"); 
        // Результат: Трехмерный: Длина 8, Размерность 3

        // Зубчатый массив (массив массивов)
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6 };
        Console.WriteLine($"Зубчатый: Длина {jagged.Length}, Размерность {jagged.Rank}"); 
        // Результат: Зубчатый: Длина 3, Размерность 1
        Console.WriteLine($"Длина первого подмассива: {jagged[0].Length}"); 
        // Результат: Длина первого подмассива: 2

        Console.WriteLine("\n=== 2. МЕТОДЫ МАССИВОВ ===");

        // BinarySearch (только для отсортированных!)
        int[] sorted = { 1, 3, 5, 7, 9 };
        int index = Array.BinarySearch(sorted, 7);
        Console.WriteLine($"BinarySearch(7): индекс {index}"); 
        // Результат: BinarySearch(7): индекс 3

        // Clear
        int[] clearArr = { 1, 2, 3, 4, 5 };
        Array.Clear(clearArr, 1, 3); // Очистить 3 элемента начиная с индекса 1
        Console.Write("Clear: ");
        foreach (var n in clearArr) Console.Write(n + " ");
        Console.WriteLine(); 
        // Результат: Clear: 1 0 0 0 5 

        // Copy
        string[] source = { "Tom", "Sam", "Bob", "Kate" };
        string[] dest = new string[2];
        Array.Copy(source, 1, dest, 0, 2); // Из source[1] 2 элемента в dest[0]
        Console.Write("Copy: ");
        foreach (var s in dest) Console.Write(s + " ");
        Console.WriteLine(); 
        // Результат: Copy: Sam Bob 

        // Exists, Find, FindAll, FindIndex, FindLastIndex
        string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
        bool hasTom = Array.Exists(people, p => p == "Tom");
        string firstKate = Array.Find(people, p => p == "Kate");
        string[] longNames = Array.FindAll(people, p => p.Length > 3);
        int firstTomIdx = Array.IndexOf(people, "Tom");
        int lastTomIdx = Array.LastIndexOf(people, "Tom");
        int firstLongIdx = Array.FindIndex(people, p => p.Length > 3);
        int lastLongIdx = Array.FindLastIndex(people, p => p.Length > 3);

        Console.WriteLine($"Exists Tom: {hasTom}, Find Kate: {firstKate}"); 
        // Результат: Exists Tom: True, Find Kate: Kate
        Console.Write("FindAll (len>3): ");
        foreach (var p in longNames) Console.Write(p + " ");
        Console.WriteLine($"\nIndexOf Tom: {firstTomIdx}, LastIndexOf Tom: {lastTomIdx}"); 
        // Результат: FindAll (len>3): Kate Alice 
        // IndexOf Tom: 0, LastIndexOf Tom: 4
        Console.WriteLine($"FindIndex (len>3): {firstLongIdx}, FindLastIndex (len>3): {lastLongIdx}"); 
        // Результат: FindIndex (len>3): 3, FindLastIndex (len>3): 5

        // Fill
        int[] fillArr = new int[5];
        Array.Fill(fillArr, 9);
        Console.Write("Fill: ");
        foreach (var n in fillArr) Console.Write(n + " ");
        Console.WriteLine(); 
        // Результат: Fill: 9 9 9 9 9 

        // Reverse
        string[] reverseArr = { "Tom", "Sam", "Bob", "Kate" };
        Array.Reverse(reverseArr);
        Console.Write("Reverse: ");
        foreach (var s in reverseArr) Console.Write(s + " ");
        Console.WriteLine(); 
        // Результат: Reverse: Kate Bob Sam Tom 

        // Resize
        int[] resizeArr = { 1, 2, 3 };
        Array.Resize(ref resizeArr, 5);
        Console.Write("Resize (до 5): ");
        foreach (var n in resizeArr) Console.Write(n + " ");
        Console.WriteLine(); 
        // Результат: Resize (до 5): 1 2 3 0 0 

        // Sort
        string[] sortArr = { "Tom", "Sam", "Bob", "Kate" };
        Array.Sort(sortArr);
        Console.Write("Sort: ");
        foreach (var s in sortArr) Console.Write(s + " ");
        Console.WriteLine(); 
        // Результат: Sort: Bob Kate Sam Tom 

        Console.WriteLine("\n=== 3. СТРОКИ: СОЗДАНИЕ И ПЕРЕБОР ===");

        string s1 = "hello";
        string s2 = new String('a', 6); // "aaaaaa"
        string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
        string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // "orl"
        Console.WriteLine($"Создание: {s1}, {s2}, {s3}, {s4}"); 
        // Результат: Создание: hello, aaaaaa, world, orl

        // Индексатор и длина
        string m = "Привет";
        Console.WriteLine($"Символ по индексу 1: {m[1]}, Длина: {m.Length}"); 
        // Результат: Символ по индексу 1: р, Длина: 6

        // Перебор
        Console.Write("Перебор for: ");
        for (int i = 0; i < m.Length; i++) Console.Write(m[i] + " ");
        Console.WriteLine(); 
        // Результат: Перебор for: П р и в е т 
        Console.Write("Перебор foreach: ");
        foreach (var ch in m) Console.Write(ch + " ");
        Console.WriteLine(); 
        // Результат: Перебор foreach: П р и в е т 

        Console.WriteLine("\n=== 4. МЕТОДЫ СТРОК ===");

        string text = "  hello world  ";
        
        // Trim, TrimStart, TrimEnd, Substring
        Console.WriteLine($"Trim: '{text.Trim()}'"); 
        // Результат: Trim: 'hello world'
        Console.WriteLine($"TrimStart: '{text.TrimStart()}'"); 
        // Результат: TrimStart: 'hello world  '
        Console.WriteLine($"TrimEnd: '{text.TrimEnd()}'"); 
        // Результат: TrimEnd: '  hello world'
        Console.WriteLine($"Substring(2): '{s1.Substring(2)}'"); 
        // Результат: Substring(2): 'llo'
        Console.WriteLine($"Substring(0,2): '{s1.Substring(0, 2)}'"); 
        // Результат: Substring(0,2): 'he'

        // Insert, Remove, Replace
        string day = "Хороший день";
        Console.WriteLine($"Insert: {day.Insert(8, "замечательный ")}"); 
        // Результат: Insert: Хороший замечательный день
        Console.WriteLine($"Remove: {day.Remove(day.Length - 3, 3)}"); 
        // Результат: Remove: Хороший д
        Console.WriteLine($"Replace: {day.Replace("хороший", "плохой")}"); 
        // Результат: Replace: Хороший день (ничего не изменилось, т.к. "Хороший" с большой буквы)

        // ToLower, ToUpper
        Console.WriteLine($"ToLower: {s1.ToLower()}, ToUpper: {s1.ToUpper()}"); 
        // Результат: ToLower: hello, ToUpper: HELLO

        // IndexOf, LastIndexOf, StartsWith, EndsWith, Contains
        string searchStr = "hello world";
        Console.WriteLine($"IndexOf('o'): {searchStr.IndexOf('o')}"); 
        // Результат: IndexOf('o'): 4
        Console.WriteLine($"LastIndexOf('o'): {searchStr.LastIndexOf('o')}"); 
        // Результат: LastIndexOf('o'): 7
        Console.WriteLine($"StartsWith('he'): {searchStr.StartsWith("he")}"); 
        // Результат: StartsWith('he'): True
        Console.WriteLine($"EndsWith('ld'): {searchStr.EndsWith("ld")}"); 
        // Результат: EndsWith('ld'): True
        Console.WriteLine($"Contains('wor'): {searchStr.Contains("wor")}"); 
        // Результат: Contains('wor'): True

        // Split
        string splitText = "И поэтому все так произошло";
        string[] words = splitText.Split(new char[] { ' ' });
        Console.Write("Split: ");
        foreach (var w in words) Console.Write(w + " ");
        Console.WriteLine(); 
        // Результат: Split: И поэтому все так произошло 

        // Concat, Join
        string concatStr = string.Concat("hello", " ", "world");
        Console.WriteLine($"Concat: {concatStr}"); 
        // Результат: Concat: hello world
        string joinStr = string.Join(" ", new string[] { "Раз", "два", "три" });
        Console.WriteLine($"Join: {joinStr}"); 
        // Результат: Join: Раз два три

        // Compare
        int cmp = string.Compare("hello", "world");
        Console.WriteLine($"Compare(hello, world): {cmp}"); 
        // Результат: Compare(hello, world): -1 (так как 'h' < 'w')

        Console.WriteLine("\n=== 5. ФОРМАТИРОВАНИЕ СТРОК ===");

        // Форматирование
        double money = 23.7;
        Console.WriteLine($"Currency: {string.Format("{0:C2}", money)}"); 
        // Результат: Currency: 23,70 ₽ (зависит от локали)
        Console.WriteLine($"Integer: {string.Format("{0:d4}", 23)}"); 
        // Результат: Integer: 0023
        Console.WriteLine($"Float: {string.Format("{0:f4}", 45.08)}"); 
        // Результат: Float: 45,0800
        Console.WriteLine($"Percent: {string.Format("{0:P1}", 0.15345m)}"); 
        // Результат: Percent: 15,3%
        Console.WriteLine($"Custom: {string.Format("{0:+# (###) ###-##-##}", 19876543210)}"); 
        // Результат: Custom: +1 (987) 654-32-10

        // Интерполяция
        string name = "Tom";
        int age = 23;
        Console.WriteLine($"Интерполяция: Имя: {name}, Возраст: {age}"); 
        // Результат: Интерполяция: Имя: Tom, Возраст: 23

        //List numbers123 = new List
    }
}