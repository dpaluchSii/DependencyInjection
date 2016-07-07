using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Rent
    {
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        private static int IdRent = 1;
        public int Id { get; set; }
        public Rent(int readerId, int bookId)
        {
            this.ReaderId = readerId;
            this.BookId = bookId;
            this.Id = IdRent++;
        }
    }
}
