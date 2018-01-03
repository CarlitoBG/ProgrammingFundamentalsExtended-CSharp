using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        public static void Main()
        {
            var fileOne = File.ReadAllLines("FileOne.txt");
            var fileTwo = File.ReadAllLines("FileTwo.txt");

            for (int i = 0; i < fileOne.Length; i++)
            {
                File.AppendAllText("output.txt", fileOne[i] + "\r\n" + fileTwo[i] + "\r\n");
            }
        }
    }
}
