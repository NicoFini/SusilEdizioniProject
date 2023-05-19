using SusilEdizioni.Core.Model;
using SusilEdizioni.DB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SusilEdizioni.DB.Mapper
{
    public class BooksEntityMapper
    {
        public static Book From(BooksEntity entity)
        {
            return new Book(entity.Id, entity?.UserID, entity.PublishedType, entity.Genre, entity.DatePublished, entity.Method, entity.HasWebSite, entity.Title, 
                entity.Subtitle, entity.Description, entity.IsActive, entity.Price, entity.Weight, entity.DiscountRate, entity.Format, 
                entity.PageNumber, entity.Arguments, entity.AuthorName, entity.AuthorSurname, entity.Role, entity.SaleRate, entity.Package, 
                entity.Cover, entity.Grammage, entity.Print);
        }
    }
}