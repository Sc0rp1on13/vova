namespace пр._2
{
    internal class Program
    {
        static void Main(string[] args)
        { int operation = 0;
            int number = 0;
          


            Boolean aboba = true;
            do
            {

            Console.WriteLine("Добро пожаловать в меню. Выберите одну из 3 игр в которую хотели бы сыграть.\r\n1. Угадай число\r\n2. Таблица умножения\r\n3. Вывод делителей числа.\r\n4. Выход из программы.");
             operation =
                Convert.ToInt32(Console.ReadLine());

                if (operation == 1)
                {
                    number =
                    Convert.ToInt32(Console.ReadLine());
                    Random rnd = new Random();
                    int value = rnd.Next(0, 100);
                    if (value == number)
                        Console.WriteLine("Правильно");
                    else Console.WriteLine("Попробуйте ещё раз");

                }
                if (operation == 2)
                {

                    var a = new int[10, 10];
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        a[i, j] = i * j;
                    }
                }
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        Console.Write("{0, 3}", a[i, j]);
                    }
                    Console.WriteLine();
                }
                }
                if (operation == 3)
                {
                    Console.WriteLine("Введите число ");
                    int i = int.Parse(Console.ReadLine());
                    for (int a = 1; a <= i; a++)
                    {
                        if (i % a == 0) Console.Write("{0} ", a);
                    }
                }
                if (operation == 4)
                {
                    aboba = false;
                    Console.WriteLine();
                }

            } while(aboba); 

        }

       
    }
}