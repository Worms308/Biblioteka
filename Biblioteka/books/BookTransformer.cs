﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.books
{
    static class BookTransformer
    {
        public static BookDTO createDto(Book book)
        {
            BookDTO dto = new BookDTO();
            dto.Id = book.Id;
            dto.Title = book.Title;
            dto.Isbn = book.Isbn;
            dto.Description = book.Description;
            dto.Publishing_house = book.Publishing_house;
            dto.Year = book.Year;
            dto.Category = book.Category.Name;

            foreach (Author_book it in book.Author_book)
            {
                dto.Authors += it.Author.Name + " " + it.Author.Surname + ", ";
            }
/*            dto.Authors.Remove(dto.Authors.Length - 3, 2);
*/            
            return dto;
        }
    }
}