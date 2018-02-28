using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Infrastructure
{  
    public static class HtmlHelperExtentions
    {
        public static MvcHtmlString DisplayAuthorsBooks(this HtmlHelper html, List<Book> books)
        {
            if (books == null)
            {
                throw new ArgumentNullException("Books list is null");
            }
            TagBuilder container = new TagBuilder("div");
            container.GenerateId("books_container");
            for (int i = 0; i < books.Count; i++) {
                container.InnerHtml += GetDivForBook(books[i], i);
            }
            return new MvcHtmlString(container.ToString());
        }
        private static string GetDivForBook(Book book, int i)
        {
            String bookDiv = $@"<div class=""book"">
                    <input data-val=""true"" data-val-number=""Значением поля AuthorId должно быть число."" data-val-required=""Требуется поле AuthorId."" id=""Books_{i}__AuthorId"" name=""Books[{i}].AuthorId"" type=""hidden"" value=""{book.AuthorId}"" />
                    <input data-num=""{i}"" data-val=""true"" data-val-number=""Значением поля Id должно быть число."" id=""Books_{i}__Id"" name=""Books[{i}].Id"" type=""hidden"" value=""{book.Id}"" />
                    <div>
                        <label class = ""book_label"">Название</label>
                        <span class = ""field_input"">{book.Title}</span>
                        <input id=""Books_{i}__Title"" name=""Books[{i}].Title"" type=""hidden"" value=""{book.Title}"" />
                    </div>
                    <div>
                        <label class = ""book_label"">Жанр</label>
                        <span class = ""field_input"">{book.Genre}</span>
                        <input id=""Books_{i}__Genre"" name=""Books[{i}].Genre"" type=""hidden"" value=""{book.Genre}"" />
                    </div>
                    <div>
                        <label class = ""book_label"">Количество страниц</label>
                        <span class = ""field_input"">{book.Pages}</span>
                        <input data-val=""true"" data-val-number=""Значением поля Pages должно быть число."" id=""Books_{i}__Pages"" name=""Books[{i}].Pages"" type=""hidden"" value=""{book.Pages}"" />
                    </div>
                </div>";
            return bookDiv;
        }
    }
}