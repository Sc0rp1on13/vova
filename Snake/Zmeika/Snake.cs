namespace Zmeika
{
    internal class Snake
    {

        int[] X = new int[50];
        int[] Y = new int[50];
        
        int foodX;
        int foodY;
        
        int parts = 2;

        ConsoleKeyInfo clavisha = new ConsoleKeyInfo();
        
        Random rnd = new Random();

        public Snake()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            
            foodX = rnd.Next(2, ((int)ClassEnum.XX - 2));
            foodY = rnd.Next(2, ((int)ClassEnum.YY - 2));
        }
        public void Gran()
        {
            
            Console.Clear();
            for (int i = 1; i <= ((int)ClassEnum.XX + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
            }
            for (int i = 1; i <= ((int)ClassEnum.XX + 2); i++)
            {
                Console.SetCursorPosition(i, ((int)ClassEnum.YY + 2));
                Console.Write("#");
            }
            for (int i = 1; i <= ((int)ClassEnum.YY + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("#");
            }
            for (int i = 1; i <= ((int)ClassEnum.YY + 1); i++)
            {
                Console.SetCursorPosition(((int)ClassEnum.XX + 2), i);
                Console.Write("#");
            }
            retr();
        }
        private void retr()
        {
            
            if (Console.KeyAvailable)  
            {
                clavisha = Console.ReadKey(true);
            }
        }
        public void WritePoint(int x, int y)
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write("0");
        }
        public void kvadrat()
        {
            
                if (X[0] != (int)ClassEnum.XX )
                {
                if (X[0] != (int)ClassEnum.XX0)
                {
                    if (Y[0] != (int)ClassEnum.YY)
                    {
                        if (Y[0] != (int)ClassEnum.YY0)
                        {
                            if (X[0] == foodX)
                        {
                            if (Y[0] == foodY)
                            {
                                parts++;
                                foodX = rnd.Next(2, ((int)ClassEnum.XX - 2));
                                foodY = rnd.Next(2, ((int)ClassEnum.YY - 2));
                            }
                        }
                        for (int i = parts; i > 1; i--)
                        {
                            X[i - 1] = X[i - 2];
                            Y[i - 1] = Y[i - 2];
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            Y[0]--;
                        }
                        else if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            Y[0]++;
                        }
                        else if (clavisha.Key == ConsoleKey.RightArrow)
                        {
                            X[0]++;
                        }
                        else if (clavisha.Key == ConsoleKey.LeftArrow)
                        {
                            X[0]--;
                        }

                        for (int i = 0; i < (parts - 1); i++)
                        {
                            WritePoint(X[i], Y[i]);
                            WritePoint(foodX, foodY);
                        }
                        Thread.Sleep(75);
                    }
                    else return;
                } 
                else return;
            }
            else return;
            }
            else return;
                
        }
        }
    }