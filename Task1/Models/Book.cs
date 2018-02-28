using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Book
    {
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public int? Id { get; set; }        
        public string Title { get; set; }
        public string Genre { get; set; }
        public int? Pages { get; set; }
    }
}