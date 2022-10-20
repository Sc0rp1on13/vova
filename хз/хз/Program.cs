
namespace вроденормкальлулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;
            char operation;
            bool c = true;



            do
            {
                
                Console.WriteLine("Введите оператор, с помощью знаков(для выхода напишите '.')");
                operation = Convert.ToChar(Console.ReadLine());
               
                
                

                if (operation == '+')
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());

                    result = a + b;
                    Console.WriteLine("Сумма чисел равна: " + result);
                }
                else if (operation == '-')
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Разность чисел равна: " + result);
                }
                else if (operation == '*')
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Произведение чисел равна: " + result);
                }

                else if (operation == '/')
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine("Разность чисел равна: " + result);
                }
                else if (operation == '^')
                {
                    Console.WriteLine("Введите основатель");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите показатель");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = (Math.Pow(a, b));
                    Console.WriteLine("Возведение в степень равна:" + result);
                }
                else if (operation == '√')
                {
                    Console.WriteLine("Введите число");
                    a = Convert.ToDouble(Console.ReadLine());
                    result = (Math.Sqrt(a));
                    Console.WriteLine("Возведение в квадратный корень:" + result);
                }
                else if (operation == '%')
                {
                    Console.WriteLine("Введите число");
                    a = Convert.ToDouble(Console.ReadLine());
                    result = (a / 100);
                    Console.WriteLine("Число в процентах равно:" + result);
                }

                else if (operation == '.')
                    
                {
                    Console.WriteLine("Выход");
                    c = false;
                    Console.WriteLine();
                }

                else if (operation == '!')
                {
                    Console.WriteLine("Введите число");
                a = Convert.ToDouble(Console.ReadLine());
                    int n = Convert.ToInt32(a); 
                    
                    int factorial = 1; 

                    for (int i = 2; i <= n; i++) 
                    {
                        factorial = factorial * i;
                    }

                    Console.WriteLine("Факториал числа равен:" + factorial);
                }
                    
                    
                    
                
              
                else
                {
                    Console.WriteLine("Неверная операция");
                    Console.WriteLine("-----");
                }

            } while (c);

         












        }
    }
}