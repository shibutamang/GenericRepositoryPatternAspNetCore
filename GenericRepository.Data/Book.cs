using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publication { get; set; }
        public float Price { get; set; }
        public string AuthorName { get; set; }

        public virtual Author Author { get; set; }
    }
}
