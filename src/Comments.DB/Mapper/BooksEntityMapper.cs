using SunsilEdizioni.Core.Model;
using SunsilEdizioni.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsilEdizioni.DB.Mapper
{
    public class BooksEntityMapper
    {
        public static Book From(BooksEntity entity)
        {
            return new Book(entity.Id, entity.Title, entity.Author, entity.Price, entity.Publisher, entity.YearPublished, entity.ISBN);
        }
    }
}
