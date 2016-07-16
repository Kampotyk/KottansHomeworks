using System;

namespace RepositoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Start();

            var printer = Bootstrap.container.GetInstance<Printer>();

            System.Console.WriteLine("PrintOneEntity:");
            printer.PrinOneEntity();

            System.Console.WriteLine("PrinAllEntities:");
            printer.PrinAllEntities();

            Console.ReadLine();
        }
    }
}
