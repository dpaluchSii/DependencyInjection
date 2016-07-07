using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Library
    {
        private IFiller Filler;
        private List<Reader> ListReaders = new List<Reader>();
        private Dictionary<int, Book> DictionaryBook = new Dictionary<int, Book>();
        private ObservableCollection<Rent> RentCollection = new ObservableCollection<Rent>();

        public Library() { }
        public Library(IFiller filler)
        {
            this.Filler = filler;
            this.Filler.Fill(this);
        }

        public List<Reader> GetListReaders() { return ListReaders; } // nowa kolekcja
       // public Dictionary<int, Book> GetDictionaryBook() { return DictionaryBook; }
        public ObservableCollection<Rent> GetRentCollection() { return RentCollection; }

       
        public bool AddReader(Reader reader)
        {
            if (!ListReaders.Contains(reader))
            {
                ListReaders.Add(reader);
                return true;
            }
            else return false;

        }
        public bool DeleteReader(Reader reader)
        {
            bool success = false;
            if (ListReaders.Contains(reader))
            {
                ListReaders.Remove(reader);
                success = true;
            }
            return success;
        }
        public bool AddRent(Rent rent)
        {
            bool success;
            if (DictionaryBook.ContainsKey(rent.BookId) // czy jest ksiazka o tym indeksie?
                && (ListReaders.Where(readerExist => readerExist.Id == rent.ReaderId) != null) //czy jest czytelnik o tym indeksie?
                && (RentCollection.Where(rentAlreadyExist => rentAlreadyExist.BookId == rent.BookId)).Count<Rent>() == 0) // czy istnieje już taki wpis ?/czy ksiazka jest juz wypozyczona
            {
                this.RentCollection.Add(rent);
                success = true;
            }
            else success = false;
            return success;
        }
        public bool AddRentWithoutCheck(Rent rent)
        {
            bool success;
            if (DictionaryBook.ContainsKey(rent.BookId) // czy jest ksiazka o tym indeksie?
                && (ListReaders.Where(readerExist => readerExist.Id == rent.ReaderId) != null) //czy jest czytelnik o tym indeksie?
               )
            {
                this.RentCollection.Add(rent);
                success = true;
            }
            else success = false;
            return success;
        }
        public bool DeleteRent(Rent rent)//
        {
            bool success = false;
            if (RentCollection.Contains(rent))
            {
                RentCollection.Remove(rent);
                success = true;
            }
            return success;
        }

        public Reader GetReader(int idReader)
        {
            return ListReaders.ElementAt(idReader);
        }

        

        public Rent GetRent(int idRent)
        {
            IEnumerable<Rent> ie = RentCollection.Where(r => r.Id == idRent);
            Rent rent = ie.First();
            return rent;
        }
    }
}
