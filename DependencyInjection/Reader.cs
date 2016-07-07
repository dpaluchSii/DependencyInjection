using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Reader
    {
        public int Id { get; set; }
        private static int IdStatic = 1;
        public string Surname { get; set; }
     
        public Reader(string surname)
        {
            this.Id = IdStatic++;
            this.Surname = surname;
        }
    }
}
