using System;
using System.IO;
using System.Linq;

namespace RandomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TextWriter writer = new StreamWriter("Random.txt");

                for (int i = 0; i <= 100000; i++)
                {
                    var guid = Guid.NewGuid();
                    var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                    var seed = int.Parse(justNumbers.Substring(0, 4));

                    var random = new Random(seed);
                    var value = random.Next(0, 100000);
                    writer.WriteLine(value.ToString());
                }
                writer.Close();

                Console.WriteLine("Random.txt ha sido guardado en: " + Directory.GetCurrentDirectory());
                Console.WriteLine("Pulse Enter para finalizar.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
