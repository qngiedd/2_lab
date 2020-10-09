using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;
            byte bit1 = 100;
            sbyte bit2 = 56;
            sbyte negative = -107;
            short bit3 = 1;
            ushort bit4 = 655;
            int a = 20;
            int a1 = 4;
            uint b = 307U;
            long c = 10L;
            ulong d = 0xFF;
            float e = 3.14F;
            double f = 5.62;
            decimal g = 144.2M;
            char h = 'H';
            string niceDay = "Nice Day";
            object helloWorld = "Hello, World!";

            Console.Write(alive.GetType());
            Console.WriteLine($": {alive}");

            Console.Write(bit1.GetType());
            Console.WriteLine($": {bit1}");

            Console.Write(bit2.GetType());
            Console.WriteLine($": {bit2}");

            Console.Write(bit3.GetType());
            Console.WriteLine($": {bit3}");

            Console.Write(bit4.GetType());
            Console.WriteLine($": {bit4}");

            Console.Write(a.GetType());
            Console.WriteLine($": {a}");

            Console.Write(b.GetType());
            Console.WriteLine($": {b}");

            Console.Write(c.GetType());
            Console.WriteLine($": {c}");

            Console.Write(d.GetType());
            Console.WriteLine($": {d}");

            Console.Write(e.GetType());
            Console.WriteLine($": {e}");

            Console.Write(f.GetType());
            Console.WriteLine($": {f}");

            Console.Write(g.GetType());
            Console.WriteLine($": {g}");

            Console.Write(h.GetType());
            Console.WriteLine($": {h}");

            Console.Write(niceDay.GetType());
            Console.WriteLine($": {niceDay}");

            Console.Write(helloWorld.GetType());
            Console.WriteLine($": {helloWorld}");

            //Неявные преобразования
            ushort implicit1 = bit1; //byte into ushort
            Console.Write(implicit1.GetType());
            Console.WriteLine($": {implicit1}");

            short implicit2 = bit2; //sbyte into short 
            Console.Write(implicit2.GetType());
            Console.WriteLine($": {implicit2}");

            short implicit3 = negative; //sbyte negative into short
            Console.Write(implicit3.GetType());
            Console.WriteLine($": {implicit3}");

            long implicit4 = a; //int into long
            Console.Write(implicit4.GetType());
            Console.WriteLine($": {implicit4}");

            float implicit5 = a; //int into float
            Console.Write(implicit5.GetType());
            Console.WriteLine($": {implicit5}");

            //Явные преобразования
            byte explicit1 = (byte)(a + a1); //int into byte
            Console.Write(explicit1.GetType());
            Console.WriteLine($": {explicit1}");

            decimal explicit2 = (decimal)(f); //double into decimal
            Console.Write(explicit2.GetType());
            Console.WriteLine($": {explicit2}");

            long explicit3 = (long)(a - a1); //int into long
            Console.Write(explicit3.GetType());
            Console.WriteLine($": {explicit3}");

            double explicit4 = (double)(e); //float into double
            Console.Write(explicit4.GetType());
            Console.WriteLine($": {explicit4}");

            float explicit5 = (float)(d); //ulong into float
            Console.Write(explicit5.GetType());
            Console.WriteLine($": {explicit5}");

            //Упаковка и распаковка значимых типов
            Object o = a; //упаковка а; о ссылается на упакованный объект
            byte m = (byte)(int)o; //распаковка и приведение

            //Неявно типизированная переменная
            var name = "Angelina Draguts";
            Console.Write(name.GetType());
            Console.WriteLine($" (var) {name}");

            //Nullable переменная
            Nullable<int> x = 5;
            Console.WriteLine($"Nullable переменная x: {x}");

            //Строковые литералы, сравнение
            string First = "How are you?";
            string Second = "I am fine.";
            Console.WriteLine($"Comparing two strings 'How are you?' and 'I am fine': {First == Second}");

            string Third = "I am happy.";
            string Fourth = "I am happy.";
            Console.WriteLine($"Comparing two strings 'I am happy' and 'I am happy': {Third == Fourth}");

            //Конкатенация строк
            Console.WriteLine($"Let's add second and third line to the first one: {First+Second+Third}");
            //Копирование строки
            string Fifth = String.Copy(First);
            Console.WriteLine(Fifth);
            //Выделение подстроки
            string name1 = "Попробуем выделить подстроку";
            Console.WriteLine(name1);
            string name2 = name1.Substring(8, 14);
            Console.WriteLine(name2);
            //Разделение строки на слова
            string text = "Разделим эту прекрасную строчку на слова?";
            Console.WriteLine(text);
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            //Вставка подстроки в заданную позицию
            string Position = "I love you";
            Position = Position.Insert(5, Second);
            Console.WriteLine(Position);
            //Удаление заданной подстроки
            string DeleteStr = "My cat is ginger";
            DeleteStr = DeleteStr.Remove(0, 3);
            Console.WriteLine(DeleteStr);

            //Пустая и null строки
            string empty = "";
            string n = null;
            int length = empty.Length;
            Console.WriteLine(length);
            bool bFlag = String.IsNullOrEmpty(n);
            Console.WriteLine(bFlag);

            //Строка на основе StringBuilder
            StringBuilder sb = new StringBuilder("Драгуть Ангелина Сергеевна", 50);
            Console.WriteLine(sb);
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            sb.Insert(0, "Студентка "); //добавление в начало
            sb.Append(new char[] { 'Ф','И','Т'}); //добавление в конец
            sb.Remove(0, 3); //удаление подстроки
            Console.WriteLine(sb);

            //Создание двумерного массива
            int[,] mas1 = { { 10, 4, 5 }, { 7, 1, 0 } };
            int rows = mas1.GetUpperBound(0) + 1;
            int columns = mas1.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas1[i, j]} \t");
                }
                Console.WriteLine();
            }
            //Создание одномерного массива, изменение произвольного элемента
            string[] mas2 = {"Гарри", "Рон", "Гермиона", "Малфой", "Хагрид", "Северус" };
            foreach (object objec in mas2)
                Console.WriteLine($"{objec} ");
            Console.WriteLine();
            int masLength = mas2.Length;
            Console.WriteLine("Размер массива: " + masLength);
            Console.WriteLine("\nВведите индекс элемента массива, который хотите изменить: ");
            int in1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите новое значение: ");
            string in2 = Console.ReadLine();
            mas2[in1] = in2;
            Console.WriteLine("Измененный массивчик: ");
            foreach (object nk in mas2)
                Console.WriteLine(nk);

            //Создание ступеньчатого массива
            int[][] myArr = new int[3][] { new int[2], new int[3], new int[4] };
            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    Console.Write($"myArr[{i}][{j}] = ");
                    myArr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(string.Join(" ", myArr[i]));
            }

            //Неявно типизированные переменные для хранения массива и строки
            var mas3 = new object[0];
            var str3 = "";

            //Кортеж из пяти элементов
            var tuple = new Tuple <int,string,char,string,ulong>(5, "exams", 'i', "have", 30UL);
            Console.WriteLine(tuple); //вывод целиком
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4); //вывод выборочных элементов

            //Распаковка кортежа
            (var one, var two) = ("123", 456);
            Console.WriteLine($"{one} {two}");

            //Сравнение двух кортежей
            var firstTuple = (9, 3);
            var secondTuple = (5, 3);

            if (firstTuple == secondTuple)
                Console.WriteLine("Первый кортеж равен второму");
            else
                Console.WriteLine("Первый кортеж не равен второму");
            //Локальная функция
            int[] locArray = { 11, -5, 0, 4, 27, 1 };
            int sum = locArray.Sum(); //вычисление суммы
            string locString = " Success is the ability to go from failure to failure without losing your enthusiasm.";

            (int, int, char, int) LocalF(int[] arr, string str)
            {
                return (arr.Max(), arr.Min(), locString[1], sum);
            }

            Console.WriteLine(LocalF(locArray, locString));

            Console.ReadLine();
        }
    }
}