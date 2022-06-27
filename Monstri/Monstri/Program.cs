using System;

namespace Monstri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Информация о монстриках";

            Console.WriteLine("Программа для вывода информации о монстрах");
            try
            {
                View.Console myConsole = new View.Console("monstr.bin");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}