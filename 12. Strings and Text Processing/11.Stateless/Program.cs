using System;

namespace _11.Stateless
{
    class Program
    {
        public static void Main()
        {
            var state = Console.ReadLine();

            while (state != "collapse")
            {
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, null).Trim();

                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                if (state.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(state);
                }

                state = Console.ReadLine();
            }
        }
    }
}