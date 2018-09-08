using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPatternAspNetCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Publication { get; set; }
        public float Price { get; set; }
        public string Author { get; set; }
    }
}
