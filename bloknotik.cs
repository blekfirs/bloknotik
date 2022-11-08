namespace pr4
{
    internal class Program
    {
        
        static void Main(string[] args)
        
        {
            List<string> two = new List<string> { "  1. пойти домой", "  2. пойти поесть" };
            
            day1();
        }
        static void day1()
        
        {
            List<string> one = new List<string> { "  1. найти пропавшие штаны", "  2. пойти чилить" };
            Console.WriteLine("\tЗаметки 01.04.2022");
            Console.WriteLine(one[0]);
            Console.WriteLine(one[1]);
            string F = "Время создания";

            int position = 1;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo clavisha = Console.ReadKey();

            while (clavisha.Key != ConsoleKey.Enter)
                
            {
                
                if (clavisha.Key == ConsoleKey.UpArrow)
                    
                {
                    position--;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 06.06.2022");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                
                else if (clavisha.Key == ConsoleKey.DownArrow)
                    
                {
                    position++;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 07.08.2022");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();

                if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day2(); }
                else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day3(); }
            }
            
            if (position == 1)
                
            {
                Console.Clear();
                Console.WriteLine(one[0] + " ---- попить воды, побыть дома, покушать");
                Console.WriteLine();
                Console.WriteLine(F + ": 02.06.2022 - 10:33:33");
            }
            
            else if (position == 2)
                
            {
                Console.Clear();
                Console.WriteLine(one[1] + " ---- найти пропавший носок, пойти к дуругу домой, крутить спинер");
                Console.WriteLine();
                Console.WriteLine(F + ": 02.02.2022 - 22:22:22");
            }
            
            Console.ReadKey();
            Console.Clear();
            day1();

            static void day2()
            
            {

                List<string> two = new List<string> { "  1. поиграть с другом", "  2. взять ноут" };

                Console.WriteLine("\tЗаметки 10.12.2022");
                Console.WriteLine(two[0]);
                Console.WriteLine(two[1]);
                string F = "Время создания";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 07.10.2022 - 21:59:39");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 09.04.2022 - 11:20.30");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day3(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day1(); }
                }
                
                if (position == 1)
                    
                {
                    Console.Clear();
                    Console.WriteLine(two[0] + " ---- победить в турнире, получить награду, пойти спать");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 24.12.2022 - 11:11:44");
                }
                
                else if (position == 2)
                    
                {
                    Console.Clear();
                    Console.WriteLine(two[1] + " ----  радоваться жизни");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 24.12.2022 - 19:19:45");
                }
                
                Console.ReadKey();
                Console.Clear();
                day2();
                
            }
            
            static void day3()
            
            {
                List<string> three = new List<string> { "  1. посмотреть инт" };
                Console.WriteLine("\tЗаметки 14.08.2022");
                Console.WriteLine(three[0]);
                string F = "Время создания";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                    
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                        
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 14.08.2022");
                        Console.WriteLine(three[0]);

                    }
                    
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                        
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 14.08.2022");
                        Console.WriteLine(three[0]);

                    }
                    
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); Console.WriteLine("Дни закночились переход к первой записи..."); day1(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day2(); }
                    
                }
                
                Console.Clear();
                Console.WriteLine(three[0] + "  ---- скушать торт");
                Console.WriteLine();
                Console.WriteLine(F + ": 22.08.2022 - 23:59:99");

            }
        }

    }
}