namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly dan = new DateOnly(2022, 10, 15);
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                RABOTAY(dan, key);
            }
            while (key.Key == ConsoleKey.Escape);
        }

        static List<z> A()
        {
            z zam1 = new z();
            zam1.n = "Встать после двадцатого будильника";

            z zam2 = new z();
            zam2.n = "Ждать Саню из ментовки";

            z zam3 = new z();
            zam1.n = "ПАМА";

            z zam4 = new z();
            zam2.n = "поплакать";

            z zam5 = new z();
            zam1.n = "ЯЯЯЯЯЯЯЯЯЯЯЯЯЯяяяяяя";

            z zam6 = new z();
            zam2.n = "сдохнуть";


            List<z> zam = new List<z>();
            zam.Add(zam1);
            zam.Add(zam2);
            zam.Add(zam3);
            zam.Add(zam4);
            zam.Add(zam5);
            zam.Add(zam6);

            return zam;
        }
        

        static void C(DateOnly dan)
        {
            Console.WriteLine(dan);
        }
        static void M2(DateOnly dan, DateOnly dan15, DateOnly dan19)
        {
            г(dan, dan15, dan19);


            ConsoleKeyInfo key = Console.ReadKey();

            int m = 1;

            Console.Clear();

            while (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {

                Console.WriteLine(dan);

                г(dan, dan15, dan19);

                Console.SetCursorPosition(0, m);
                Console.WriteLine(">");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    m--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    m++;
                }

                if (m == 3)
                {
                    m = 1;
                }

                if (m == 0)
                {
                    m = 2;
                }

                Console.SetCursorPosition(0, m);
                Console.WriteLine(">");

                Console.Clear();
            }
            while (key.Key == ConsoleKey.Enter)
            {
                if (dan == dan15)
                {
                    Opis2(dan, dan15, dan19, m);
                    ConsoleKeyInfo key1 = Console.ReadKey();
                    if (key1.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }

                else if (dan == dan19)
                {
                    Opis2(dan, dan15, dan19, m);
                    ConsoleKeyInfo key1 = Console.ReadKey();
                    if (key1.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }

            }
        }
        static void RABOTAY(DateOnly dan, ConsoleKeyInfo key)
        {
            DateOnly dan15 = new DateOnly(2022, 10, 15);
            DateOnly dan17 = new DateOnly(2022, 10, 17);
            DateOnly dan19 = new DateOnly(2022, 10, 19);

            while (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();

                if (key.Key == ConsoleKey.RightArrow)
                {
                    dan = dan.AddDays(1);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    dan = dan.AddDays(-1);
                }

                C(dan);

                if (dan == dan15 || dan == dan19)
                {
                    M2(dan, dan15, dan19);
                }
                key = Console.ReadKey();

            }
        }
        static void г(DateOnly dan, DateOnly dan15, DateOnly dan19)
        {
            List<z> z = A();

            if (dan == dan15)
            {
                Console.Write("  1)"); Console.WriteLine(z[1].n);
                Console.Write("  2)"); Console.WriteLine(z[2].n);
            }

            if (dan == dan19)
            {
                Console.Write("  1) "); Console.WriteLine(z[3].n);
                Console.Write("  2) "); Console.WriteLine(z[4].n);
            }
        }

        static void Menu1(DateOnly dan, DateOnly dan17)
        {
            Menu1(dan, dan17);
            Console.SetCursorPosition(0, 1);
            Console.Write(">");

            ConsoleKeyInfo key = Console.ReadKey();

            int m = 1;

            Console.Clear();

            while (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {

                Console.WriteLine(dan);

                Menu1(dan, dan17);

                Console.SetCursorPosition(0, m);
                Console.WriteLine(">");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    m--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    m++;
                }

                if (m != 1)
                {
                    m = 1;
                }

                Console.SetCursorPosition(0, m);
                Console.WriteLine(">");

                Console.Clear();
            }
            while (key.Key == ConsoleKey.Enter)
            {

                Opis1(dan, dan, dan17);
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }

            }
        }

        static void VMenu1(DateOnly dan, DateOnly dan17, DateOnly dan19)
        {
            List<z> zam = A();

            if (dan == dan17)
            {
                Console.Write("   1) "); Console.WriteLine(zam[3].n);
            }

            if (dan == dan19)
            {
                Console.Write("   1) "); Console.WriteLine(zam[2].n);
            }
        }

        static List<z> OZ()
        {
            z Ozam1 = new z();
            Ozam1.sz = "Умыться";

            z Ozam2 = new z();
            Ozam2.sz = "Проклять тетку, которая его сдала";

            

            List<z> Ozametki = new List<z>();
            Ozametki.Add(Ozam1);
            Ozametki.Add(Ozam2);
            

            return Ozametki;
        }

        static void Opis1(DateOnly dan, DateOnly dan10, DateOnly dan17)
        {
            List<z> ZM = OZ();
            List<z> z = A();

            if (dan == dan10)
            {
                Console.WriteLine(z[3].n);
                Console.WriteLine("--------------------------");
                Console.WriteLine(ZM[3].sz);
                Console.WriteLine("Сделать " + dan);
            }
            else if (dan == dan17)
            {
                Console.WriteLine(z[2].n);
                Console.WriteLine("--------------------------");
                Console.WriteLine(ZM[2].sz);
                Console.WriteLine("Сделать " + dan);
            }
        }

        static void Opis2(DateOnly dan, DateOnly dan15, DateOnly dan19, int m)
        {
            List<z> ZA = OZ();
            List<z> za = A();

            if (dan == dan15)
            {
                if (m == 1)
                {
                    Console.WriteLine(za[0].n);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(ZA[0].sz);
                    Console.WriteLine("Сделать " + dan);
                }

                if (m == 2)
                {
                    Console.WriteLine(za[1].n);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(ZA[1].sz);
                    Console.WriteLine("Сделать " + dan);
                }
            }
            else if (dan == dan19)
            {
                if (m == 1)
                {
                    Console.WriteLine(za[4].n);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(ZA[4].sz);
                    Console.WriteLine("Сделать " + dan);
                }

                if (m == 2)
                {
                    Console.WriteLine(za[5].n);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(ZA[5].sz);
                    Console.WriteLine("Сделать " + dan);
                }
            }
        }
    }
}