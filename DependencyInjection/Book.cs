using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Scope { get; set; }
        public int Id { get; set; }
      

        public bool IsRent { get; set; }
        private static int IdBook = 1;

        public Book(string title, string author, string scope)
        {
            this.Title = title;
            this.Author = author;
            this.Scope = scope;
            this.Id = IdBook++;
        }
    }
}
