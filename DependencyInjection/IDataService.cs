using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IDataService
    {
        void ShowReaders();
        void ShowBooks();
        void ShowRent();
        void ShowAll();
        void AddRent(Rent rent);
        void AddReader(Reader reader);
        void DeleteReader(Reader reader);
        void DeleteRent(Rent rent);
    }
}
