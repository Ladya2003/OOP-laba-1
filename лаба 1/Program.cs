using System;   // подключение баховой библиотеки с помощью директивы using
using System.Text;


class Laba1
{
    public static void Main()
    {
        // tusk 1a
        //переменные примитивных типов

        bool a = true;
        byte b = 255;             // 0 до 255
        sbyte s = -128;           // -128 до 127
        char c = 's';
        decimal dec = 1.5E6m;     // decimel - десятичная структура, диапозон ±1,0 х 10^(-28) до ±7.9228 x 10^28 // output: 1500000, где m - это литерал для типа decimal
        double dd = 111111.7777;  // ±5.0 × 10^−324 to ±1.7 × 10^308
        float f = 123213.123123F; // ±1.5 x 10−45 to ±3.4 x 1038
        int i = 13;               // -2,147,483,648 to 2,147,483,647
        uint u = 4294967295;      // 0 to 4,294,967,295
        nint n = 42;              // Интегральные числовые типы
        nuint nui = 420;          // предназначен для целого числа, размер которого равен размеру указателя
        long l = 100000;          // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong r = 1000000;        // 0 to 18,446,744,073,709,551,615
        short sh = 32767;         // -32,768 to 32,767
        ushort ush = 65500;       // 0 to 65,535

        string str = "type any string = ";
        dynamic dyn = 1;
        object obj = 1;

        Console.WriteLine("TUSK #1(A)");
        Console.WriteLine("integer i = {0}", i);
        Console.WriteLine("long l = {0}", l);

        Console.WriteLine(str);
        string str2 = Console.ReadLine();
        Console.WriteLine("Yout string is {0}", str2);
        Console.WriteLine("");


        // tusk 1b
        // выполинте 5 операций явного и неявного преобразования

        // операции неявного преобразования
        byte b1 = 255;
        short s1 = b1;
        ushort s2 = b1;
        int i1 = b1;
        long l1 = b1;
        ulong l2 = b1;

        Console.WriteLine("TUSK #1(B)");
        Console.WriteLine("Результат операций НЕЯВНОГО приведения: Short = {0}, UShort = {1} Int = {2}, Long = {3}, ULong = {4}", s1, s2, i1, l1, l2);

        // операции неявного преобразования
        short s3 = 45;
        byte b2 = (byte)s3, b3 = Convert.ToByte(s3);
        ushort ush2 = (ushort)b2;
        long l3 = 1234;
        int i2 = Convert.ToInt32(l3), i3 = Convert.ToInt16(l3);

        Console.WriteLine("Результат операций ЯВНОГО приведения: Byte2 = {0}, Byte2 = {1}, UShort = {3}, Int = {4}, Int2 = {5} ", b2, b3, ush2, l3, i2, i3);
        Console.WriteLine("");

        // tusk 1С
        // Выполните упаковку и распаковку значимых типов

        Console.WriteLine("TUSK #1(C)");
        int i4 = 123;
        object o = i4;  // Данная строчка упаковывает переменную i4
        Console.WriteLine("Операция упаковки: i4 = {0}, o = {1}", i4, o);
        o = 345;
        i4 = (int)o;  // распаковка
        Console.WriteLine("Операция распаковки: i4 = {0}, o = {1}", i4, o);

        // tusk 1D
        // Продемонстрируйте работу с неявно типизированной переменной

        // i is compiled as an int
        var i5 = 5;

        // s is compiled as a string
        var s4 = "Hello";

        Console.WriteLine("");
        Console.WriteLine("TUSK #1(D)");
        Console.WriteLine("Неявно типизированные переменные: Type of var i5 = {0}, var s4 = {1}", i5.GetType(), s4.GetType());

        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        // If a query produces a sequence of anonymous types,
        // then use var in the foreach statement to access the properties.
        var upperLowerWords =
             from w in words
             select new { Upper = w.ToUpper(), Lower = w.ToLower() };

        // Execute the query
        foreach (var ul in upperLowerWords)
        {
            Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
        }


        // tusk #1E
        // Продемонстрируйте пример работы с Nullable переменной
        Console.WriteLine("");
        Console.WriteLine("TUSK #1(E)");

        // тип int? - тип, переменные/параметры которого могут принимать как значения типа int, так и значение
        // null. В данном случае мы передаем ей значение null. Но также можно передать и значение типа int:

        int? val = null;
        IsNull(val);    // null
        val = 22;
        IsNull(val);    // 22

        void IsNull(int? obj)
        {
            if (obj == null) Console.WriteLine("obj = null");
            else Console.WriteLine("obj = {0}", obj);
        }

        // Следующие виды определения переменных будут эквивалентны:

        int? number1 = 5;
        Nullable<int> number2 = 5;


        // tusk #1F
        //Определите переменную типа var и присвойте ей любое
        //значение.Затем следующей инструкцией присвойте ей значение
        //другого типа. Объясните причину ошибки

        var влад = 19;
        // влад = "арсений"; ошибка так как нельзя переменной типа Int присвоить значение типа String
        // мы используем строгую типизацию, нельзя менять типы данных "налету"


        // tusk 2A
        // Объявите строковые литералы. Сравните их
        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        Console.WriteLine("TUSK #2(A)");

        String strr1 = "Vlad";
        String strr2 = "VLAD";
        Console.WriteLine($"Строки Vlad и VLAD равны: {ReferenceEquals(strr1, strr2)}");

        // tusk 2B
        // Создайте три строки на основе String. Выполните:
        Console.WriteLine("");
        Console.WriteLine("TUSK #2(B)");

        String strr3 = "I";
        String strr4 = "Love";
        String strr5 = "Programing";

        // сцепление
        Console.WriteLine($"Сцепление: {String.Concat(strr3, strr4, strr5)}");

        // копирование
        String strr3_copy = String.Copy(strr3);
        Console.WriteLine($"Копирование: {strr3_copy}");

        // выделение подстроки
        Console.WriteLine($"Выделение подстроки: {strr5.Substring(3, 4)}");   // начало, количество

        // разделение строки на слова
        Console.WriteLine($"Разделение строки на слова:");
        String sententce = "Should admit C# is cool";
        string[] words2 = sententce.Split(' ');
        foreach (var word in words2)
        {
            Console.WriteLine($"[{word}]");
        }

        // вставка подстроки в заданную позицию
        Console.WriteLine($"Вставка подстроки: {strr3.Insert(1, "Bebra")}");

        // удаление заданной подстроки
        Console.WriteLine($"Удаление подстроки: {strr3.Remove(1)}");

        // интерполяция строк (упрощенный механизм форматирования строк)
        Console.WriteLine($"Интерполяция строк: 1-st word: {strr1}, 2-nd word: {strr2}");


        // tusk #2C
        Console.WriteLine("");
        Console.WriteLine("TUSK #2(C)");

        string stEmpty = ""; // пустая строка
        String stNull = null;


        // Продемонстрируйте использование метода string.IsNullOrEmpty

        Console.WriteLine($"stEmpty is empty: {string.IsNullOrEmpty(stEmpty)}");
        Console.WriteLine($"stNull is null: {string.IsNullOrEmpty(stNull)}");
        Console.WriteLine($"str is empty: {string.IsNullOrEmpty(str)}");

        // Продемонстрируйте что еще можно выполнить с такими строкам

        string answer1 = "123";
        while (answer1 != "")
        {
            Console.WriteLine("Введите ваше имя: ");
            answer1 = Console.ReadLine();
        }

        // Создайте строку на основе StringBuilder. 
        // StringBuilder - динамическая строка, используется чаще чем System.String когда нужно обработать больше строк
        // и больше методов над ними.

        StringBuilder strbuid = new StringBuilder("VLADVLADVLAD", 50);
        Console.WriteLine($"Исходная строка: {strbuid}");

        //Удалите определенные позиции
        strbuid.Remove(1, 1);
        Console.WriteLine($"Строка без второго символа: {strbuid}");

        //добавьте новые символы
        //в начало
        strbuid.Insert(0, "The creators name's ");
        Console.WriteLine($"Строка с новыми символами: {strbuid}");

        //и конец строки
        strbuid.Append(" AND HE IS AN ABSOLUTE HERO");
        Console.WriteLine($"Строка с новыми символами: {strbuid}");

        // TUSK #3A
        // Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 

        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        Console.WriteLine("TUSK #3(A)");

        int[,] dbArray;
        dbArray = new int[3, 3]
        {
            {1, 2 ,3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Элементы массива: ");
        int count1 = 0;
        foreach (var item in dbArray)
        {
            count1++;
            Console.Write($"{item}  ");
            if (count1 % 3 == 0)
            {
                Console.WriteLine("");
            }
        }

        // TUSK #3B
        // Создайте одномерный массив строк. Выведите на консоль его 
        // содержимое, длину массива. Поменяйте произвольный элемент
        // (пользователь определяет позицию и значение)
        Console.WriteLine("");
        Console.WriteLine("TUSK #3(B)");

        String[] myStr = new string[] {"I", "love", "C#"};
        Console.WriteLine("Введите позицию изменяемого элемента = ");
        int pos1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите его значения = ");
        string value1 = Console.ReadLine();
        
        myStr[pos1] = value1;

        foreach (var item in myStr)
        {
            Console.Write($"{item}  ");
        }
        Console.WriteLine($", длина массива = {myStr.Length}");

        // TUSK #3C
        // Создайте ступечатый (не выровненный) массив вещественных 
        // чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
        // соответственно.Значения массива введите с консоли.
        Console.WriteLine("");
        Console.WriteLine("TUSK #3(C)");

        int[][] stairsArray = new int[3][];
        stairsArray[0] = new int[2];
        stairsArray[1] = new int[3];
        stairsArray[2] = new int[4];

        Console.WriteLine("Введите элементы массива");

        for (int item = 0; item < 3; item++)
        {
            for (int y = 0; y < stairsArray[item].Length; y++)
                stairsArray[item][y] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        for (var item = 0; item < stairsArray.Length; item++)
        {
            for (int y = 0; y < stairsArray[item].Length; y++)
               Console.Write(stairsArray[item][y] + " ");
            Console.WriteLine("");
        }

        // TUSK #3D
        // Создайте неявно типизированные переменные для хранения массива и строки.
        Console.WriteLine("");
        Console.WriteLine("TUSK #3(D)");

        var undStr = new[]{ "Hello", "World", "!"  };
        for (var undItem = 0; undItem < undStr.Length; undItem++)
            Console.Write(undStr[undItem] + " ");


        // TUSK #4A
        // Кортеж — набор из нескольких значений, возможно, разного типа.
        // Кортежи состоят как минимум из двух элементов и максимум из семи.
        // Значения кортежей доступны только на чтение.

        // Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
        // TUSK #4B
        // Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)

        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        Console.WriteLine("TUSK #4(A)");

        Tuple<int, string, char, string, ulong> Method()
        {
            return Tuple.Create(1, "Vlad", 'V', "VAKULENCHIK", 13UL);
        }
        Console.WriteLine($"Полный кортеж: {Method().Item1}, {Method().Item2}, {Method().Item3}, {Method().Item4}, {Method().Item5}");
        Console.WriteLine($"Его второй элемент: {Method().Item2}");

        // TUSK #4C
        // Выполните распаковку кортежа в переменные.
        // Продемонстрируйте различные способы распаковки кортежа.
        // Продемонстрируйте использование переменной(_).

        //(string first, string middle, string last) = LookupName(id1); // deconstructing declaration

        //Console.WriteLine($"found {first} {last}.");

        // TUSK #4D
        // Сравните два кортежа

        (int, string, char, string) kortej = (19, "VLAD", 'V', "VAKULENCHIK");
        int it1 = 1;
        string it2 = "wow";
        char it3 = 'o';
        string it4 = "ohoho";
        (it1, it2, it3, it4) = kortej;
        (int firstt, _, char secondd, string lastt) = kortej;

        (int, string, char, string) kortej1 = (19, "SENYA", 'S', "PALAZHIK");
        if (kortej == kortej1)
        {
            Console.WriteLine("Кортежи равны");
        }
        else
        {
            Console.WriteLine("Кортежи не равны");
        }



        // TUSK #5A
        // Создайте локальную функцию в main и вызовите ее
        /*. Формальные параметры функции – массив
           целых и строка. Функция должна вернуть кортеж, содержащий:
           максимальный и минимальный элементы массива, сумму элементов
           массива и первую букву строки
        */
        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        Console.WriteLine("TUSK #5(A)");

        static (int, int, int, char) LocFun(int[] intArr, string str)
           {
               char firstL = str[0];
               int max = intArr.Max();
               int min = intArr.Min();
               int sum = intArr.Sum();
               (int, int, int, char) kortej = (min, max, sum, firstL);
            return kortej;
           }

        int[] numArr = { 10, 20, 30 };
        Console.WriteLine("Элементы массива: ");
        foreach (var piece in numArr)
            Console.Write(piece + " ");
        Console.WriteLine("");

        Console.WriteLine($"(min, max, sum, firstL) = {LocFun(numArr, "VLAD")}");


        // TUSK #6
        // Работа с checked, unchecked
        // Определите две локальные функции.
        /* Разместите в одной из них блок checked, в котором определите 
        переменную типа int с максимальным возможным значением 
        этого типа. Во второй функции определите блок unchecked с 
        таким же содержимым. */

        int func_checked()
        {
            checked
            {
                int q = int.MaxValue;
                try
                {
                    return q + 1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение");
                    return q;
                }
            }
        }
        int func_unchecked()
        {
            unchecked
            {
                int q = int.MaxValue;
                try
                {
                    return q + 1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение");
                    return q;
                }
            }
        }
        Console.WriteLine(func_checked());
        Console.WriteLine(func_unchecked());
    }

}

