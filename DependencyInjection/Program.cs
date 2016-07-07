using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            IDataService dataService = new DataService(library);


            Console.WriteLine("Lista czytelników:");
            Console.WriteLine();
            dataService.ShowReaders();
            Console.WriteLine();
            Console.WriteLine("słownik książek:");
            Console.WriteLine();
            dataService.ShowBooks();
            Console.WriteLine();

            Console.WriteLine("Wypożyczenia:");
            Console.WriteLine();
            dataService.ShowRent();
            Console.WriteLine();
            //Console.WriteLine(library.GetRentCollection().Count);
            Console.ReadKey();
        }
    }
}
