using System;

namespace SF5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Евгения", 276);

            Console.WriteLine("Имя: {0}", name);
            Console.WriteLine("Возраст: {0}", age);

            Console.WriteLine("");

            Console.Write("Введите новое имя: ");
            name = Console.ReadLine();
            Console.Write("Введите новый возраст цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Новое имя: {0}", name);
            Console.WriteLine("Возраст: {0}", age);

        }
    }
}
