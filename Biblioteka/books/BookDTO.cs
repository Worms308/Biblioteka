using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.books
{
    class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }
        public System.DateTime Year { get; set; }
        public string Publishing_house { get; set; }
        public string Category { get; set; }
        public string Authors { get; set; }
    }
}
