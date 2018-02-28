using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите имя")]
        [RegularExpression(@"^[A-z,А-я]+$", ErrorMessage = "Имя должно состоять только из букв")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите фамилию")]
        [RegularExpression(@"^[A-z,А-я]+$", ErrorMessage = "Фамилия должна состоять только из букв")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите отчество")]
        [RegularExpression(@"^[A-z,А-я]+$", ErrorMessage = "Отчество должно состоять только из букв")]
        public string Patronymic { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBitrh { get; set; }

        public List<Book> Books { get; set; }


        public Author()
        {
            Books = new List<Book>();
            DateOfBitrh = new DateTime(1970, 1,1);
        }
    }
}