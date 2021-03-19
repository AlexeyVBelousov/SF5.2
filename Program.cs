using System;

namespace SF5._2
{
    class Program
    {
        static string ShowColor(string username)
        {
            Console.WriteLine("{0}, напиши свой любимый цвет на английском с маленькой буквы:", username);
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    return color;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    return color;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    return color;
                default:
                    color = "yellow";
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    return color;
            }
        }

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

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name);
            }

            Console.WriteLine("Любимые цвета:");

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
