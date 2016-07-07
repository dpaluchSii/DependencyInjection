using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class DataService : IDataService
    {
        public class SimpleClass
        {

            public string stringValue { get; set; }

            public int intValue { get; set; }

        }

        private Library Library;
        public DataService(Library lib)
        {
            this.Library = lib;
        }

   
        public void ShowReaders()
        {
            foreach (var i in Library.GetListReaders())
            {
                Console.WriteLine("nazwisko: " + i.Surname);
            }
        }
        public void ShowRent()
        {
            foreach (var i in Library.GetRentCollection())
            {
                Console.WriteLine("id czytelnika: " + i.ReaderId
                    + ", id książki:  " + i.BookId);
            }
        }
        public void AddRent(Rent rent)
        {
            Library.AddRent(rent);
        }
        public void AddReader(Reader reader)
        {
            Library.AddReader(reader);
        }

        public void DeleteReader(Reader reader)
        {
            DeleteReader(reader);
        }
        public void DeleteRent(Rent rent)
        {
            DeleteRent(rent);
        }

        public void ShowBooks()
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}