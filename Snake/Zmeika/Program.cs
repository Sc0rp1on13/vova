namespace Zmeika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Snake snake = new Snake();
            while(true)
            {
                snake.Gran();
                snake.kvadrat();
             }
        }
        internal void Finaly()
        {
            
            Console.Clear();
            Console.Write("Конец игры");
        }
    }
}
