using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class AuthorsDbInitializer:CreateDatabaseIfNotExists<AuthorsContext>
    {
        protected override void Seed(AuthorsContext context)
        {
            var author = new Author()
            {
                Id = 1,
                Name = "Михаил",
                Surname = "Булгаков",
                Patronymic = "Афанасьевич",
                DateOfBitrh = new DateTime(year: 1891, month: 5, day: 15).Date
            };
            context.Authors.Add(author);
            context.Books.Add(new Book()
            {
                Id = 1,
                Author = author,
                AuthorId = author.Id,
                Title = "Мастер и Маргарита",
                Genre = "Роман",
                Pages = 567
            });
            context.Books.Add(new Book()
            {
                Id = 2,
                Author = author,
                AuthorId = author.Id,
                Title = "Белая гвардия",
                Genre = "Исторический роман",
                Pages = 245
            });

            base.Seed(context);
        }
    }
}