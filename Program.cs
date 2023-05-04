// Необходимо реализовать обобщенный класс, который позволяет хранить в массиве объекты любого типа.
// В данном классе определить методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу.

using System.Collections.Generic;

namespace Обобщения
{
    class Massiv<T> 
    { 
        List<T> values = new List<T>();
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Массив: \t[" + String.Join(", ", values.ToArray()) + "]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Add(T value) => values.Add(value);
        public void Remove(T value) => values.Remove(value);
        public T GetValue(int index)
        {
            try
            {
                return values[index]; 
            }
            catch
            {
                Console.WriteLine($"Элемента по индексу '{index}' не существует в массиве.");
                Console.Write($"Введите новый индекс: ");
                int indx = int.Parse( Console.ReadLine() );
                return GetValue(indx);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // для строк
            Massiv<string> m = new Massiv<string>();
            Console.WriteLine("\t\t\t\t - Массив строк - ");
            Console.WriteLine("Введите массив. Для остановки ввода введите '.' ");
            string a = "";
            while (a != ".")
            {
                a = Console.ReadLine();
                if (a != ".") { m.Add(a); }
            }
            m.Print();
            Console.Write("Введите элемент, который хотите удалить: ");
            string element = Console.ReadLine();
            m.Remove(element);
            m.Print();
            Console.Write("Введите индекс элемента, который хотите получить: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Элемент: {m.GetValue(index)}");

            // для чисел
            Massiv<double> n = new Massiv<double>();
            Console.WriteLine("\t\t\t\t - Массив чисел - ");
            Console.WriteLine("Введите массив. Для остановки ввода введите '.' ");
            a = "";
            while (a != ".")
            {
                a = Console.ReadLine();
                if (a != ".") { n.Add(Convert.ToDouble(a)); }
            }
            n.Print();
            Console.Write("Введите элемент, который хотите удалить: ");
            double el = double.Parse(Console.ReadLine());
            n.Remove(el);
            n.Print();
            Console.Write("Введите индекс элемента, который хотите получить: ");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Элемент: {n.GetValue(index)}");
            Console.ReadKey();
        }
    }
}