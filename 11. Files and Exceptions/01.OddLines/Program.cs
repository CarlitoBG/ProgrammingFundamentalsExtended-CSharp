using System.IO;
using System.Linq;

namespace _01.OddLines
{
    class Program
    {
        public static void Main()
        {
            var text = File.ReadAllLines("Input.txt");
            
            File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));
        }
    }
}
