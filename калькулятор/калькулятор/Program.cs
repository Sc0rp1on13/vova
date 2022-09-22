namespace калькулятор
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int operation = 0;
            int first_number = 0;
            int second_number = 0;
            Boolean bool_num = true;

            do
            {


                Console.WriteLine("Выберите операцию для выполнения");
                Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4" +
            "  Разделить первое на второе\r\n5. Возвести в степень N число\r\n6. Найти квадратный корень от числа\r\n7." +
            " Найти процент от числа\r\n8. Найти факториал от числа\r\n9. Выйти из программы");
                Console.WriteLine("Какую операцию выполнить");
                operation =
                Convert.ToInt32(Console.ReadLine());

                if (operation == 1)
                {
                    Console.WriteLine("Введите первое число:");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    second_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (first_number + second_number));
                    Console.WriteLine("-----");
                }

                else if (operation == 2)
                {
                    Console.WriteLine("Введите первое число:");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    second_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (first_number - second_number));
                    Console.WriteLine("-----");
                }

                else if (operation == 3)
                {
                    Console.WriteLine("Введите первое число:");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    second_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (first_number * second_number));
                    Console.WriteLine("-----");


                }
                else if (operation == 4)
                {
                    Console.WriteLine("Введите первое число");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    second_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (first_number / second_number));
                    Console.WriteLine("-----");

                }
                else if (operation == 5)
                {
                    Console.WriteLine("Введите первое число");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    second_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (Math.Pow(first_number, second_number)));
                    Console.WriteLine("-----");

                }
                else if (operation == 6)
                {
                    Console.WriteLine("Введите число");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (Math.Sqrt(first_number)));
                    Console.WriteLine("-----");


                }
                else if (operation == 7)
                {
                    Console.WriteLine("Введите число");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:" + (first_number / 100));
                    Console.WriteLine("-----");

                }
                else if (operation == 8)
                {
                    Console.WriteLine("Введите число");
                    first_number =
                    Convert.ToInt32(Console.ReadLine());
                    int i = 0;
                    int number = 1;
                    while (number < first_number)
                    {
                        i++;
                        number = number * i;
                    }
                        

                   
                    Console.WriteLine("Результат:" + i);
                    Console.WriteLine("-----");
                }
                else if (operation == 9)
                {
                    Console.WriteLine("Выход из калькулятора");
                    bool_num = false;
                    Console.WriteLine("-----");


                }
                else
                {
                    Console.WriteLine("Неверно подобрана операция.");
                    Console.WriteLine("-----");

                }



            } while (bool_num);
        }
    }
}