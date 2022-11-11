namespace прак._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это пианино, хотите сыграть?");
            aboba();
        }
        static void aboba()
        {
            int[] a = new int[] { 2616, 2772, 2937, 3111, 3296, 3492, 3700, 3920, 4153, 4400, 4662, 4939 };
            int[] b = new int[] { 5233, 5544, 5873, 6223, 6593, 6985, 7400, 7840, 8306, 8800, 9323, 9878 };
            int[] c = new int[] { 10470, 11090, 11750, 12450, 13190, 1397, 14800, 15680, 16610, 17600, 18650, 19760 };
            int[] d = new int[] { 20930, 22170, 23490, 24890, 26370, 27940, 29600, 31360, 33220, 35200, 37290, 39610 };

           bool q = true;
            while (q)
            {

                {
                    Console.WriteLine("Какую октаву вы хотите выбрать??");
                    Console.WriteLine("F8: Выход из программы");

                    Console.WriteLine("F1: Первая октава ");
                    Console.WriteLine("F2: Вторая октава");
                    Console.WriteLine("F3: Третья октава");
                    Console.WriteLine("F4: Четвёртая октава");
                    Console.WriteLine("F9: Для выхода из октав ");
                }
                ConsoleKeyInfo M = Console.ReadKey();
                if (M.Key == ConsoleKey.F8)
                {
                    Console.WriteLine("Выход из программы");
                    q = false;
                }
                else if (M.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Подрубаю первую октаву");
                    Poigratnagarmoshke(a);
                }
                else if (M.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Подрубаю вторую октаву");
                    Poigratnagarmoshke(b);
                }
                else if (M.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Подрубаю третью октаву");
                    Poigratnagarmoshke(c);
                }
                else if (M.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Подрубаю четвёртую октаву");
                    Poigratnagarmoshke(d);
                }
                
                else
                {

                    Console.Clear();

                }
            } 

            static void Poigratnagarmoshke(int[] sound)
            {
                while (true)
                {
                    ConsoleKeyInfo button = Console.ReadKey(true);
                    if (button.Key == ConsoleKey.A)
                    {
                        Console.Beep((sound[0] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.W)
                    {
                        Console.Beep((sound[1] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.S)
                    {
                        Console.Beep((sound[2] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.E)
                    {
                        Console.Beep((sound[3] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.D)
                    {
                        Console.Beep((sound[4] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.R)
                    {
                        Console.Beep((sound[5] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.F)
                    {
                        Console.Beep((sound[6] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.T)
                    {
                        Console.Beep((sound[7] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.G)
                    {
                        Console.Beep((sound[8] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.Y)
                    {
                        Console.Beep((sound[9] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.H)
                    {
                        Console.Beep((sound[10] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.U)
                    {
                        Console.Beep((sound[11] / 10), 200);
                    }

                    else if (button.Key == ConsoleKey.F9)
                    {
                        Console.Clear();
                        break;
                    }

                }

            }
        }
    }
}