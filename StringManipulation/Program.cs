
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Type and Print";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Type something here: ");
            string x;
            x = Console.ReadLine();
            List<char> y = new List<char>();
            for (int i = 0; i < x.Length; i++)
            {
                if (!x[i].Equals(' '))
                {
                    y.Add(Char.ToLower(x[i]));
                }
                Console.WriteLine((i + 1).ToString() + ". " + x[i]);
            }

            Console.WriteLine("\n\nSorting characters.\n");
            y.Sort();
            for (int i = 0; i < y.Count; i++)
            {
                Console.Write(y[i]);
            }
            Console.WriteLine("\n\nReversing!\n");
            y.Reverse();
            for (int i = 0; i < y.Count; i++)
            {
                Console.Write(y[i]);
            }

            y.Reverse();
            Console.Write("\n\nZig Zag how many times? ");
            int reps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int r = 0; r < reps; r++)
            {
                for (int i = 0; i < y.Count; i++)
                {
                    Thread.Sleep(10);
                    for (int j = 0; j < y.Count; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(y[i]);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                y.Reverse();
                for (int i = y.Count - 1; i >= 0; i--)
                {
                    Thread.Sleep(10);
                    for (int j = 0; j < y.Count; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(y[i]);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                y.Reverse();
            }

            y.Clear();

            Console.WriteLine("\nBack to the original input!\n");
            for (int i = 0; i < x.Length; i++)
            {
                y.Add(Char.ToLower(x[i]));
            }

            Console.Write("\n\nZig Zag how many times? ");
            reps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int r = 0; r < reps; r++)
            {
                for (int i = 0; i < y.Count; i++)
                {
                    Thread.Sleep(10);
                    for (int j = 0; j < y.Count; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(y[i]);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                y.Reverse();
                for (int i = y.Count - 1; i >= 0; i--)
                {
                    Thread.Sleep(10);
                    for (int j = 0; j < y.Count; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(y[i]);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                y.Reverse();
            }

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
