using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Filler : IFiller
    {
        public void Fill(Library library)
        {
            Book book1 = new Book("Potop", "Sienkiewicz", "historyczne");
            Book book2 = new Book("Symfonia C++", "Gręmbosz", "informatyczne");
            Book book3 = new Book("Ojciec Chrzestny", "Puzo", "powieść");
            Reader reader1 = new Reader("Kowalski");
            Reader reader2 = new Reader("Nowak");
            Reader reader3 = new Reader("Hołys Jabub");

            Book book4 = new Book("Gra o Tron", "Martin", "fantazy");
            Book book5 = new Book("Omerta", "Puzo", "sensacja");
            Reader reader4 = new Reader("Paluch");
            Reader reader5 = new Reader("Traczyk");

            Rent r1 = new Rent(reader1.Id, book1.Id);
            Rent r2 = new Rent(reader2.Id, book2.Id);
            Rent r3 = new Rent(reader3.Id, book3.Id);
            Rent r4 = new Rent(reader4.Id, book4.Id);

            
            library.AddReader(reader1);
            library.AddReader(reader2);
            library.AddReader(reader3);
            library.AddReader(reader4);
            library.AddReader(reader5);
            library.AddRent(r1);
            library.AddRent(r2);
            library.AddRent(r3);
            library.AddRent(r4);
        }
    }
}
