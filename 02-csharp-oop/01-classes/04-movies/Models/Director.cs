using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public partial class Director
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Country? Country { get; set; }
        public DateTime? DateOfBith { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}