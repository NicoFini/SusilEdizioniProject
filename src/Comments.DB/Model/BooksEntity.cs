﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsilEdizioni.DB.Model
{
    [Table("Books")]
    public class BooksEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("publisher")]
        public string Publisher { get; set; }

        [Column("yearPublished")]
        public int YearPublished { get; set; }

        [Column("ISBN")]
        public string ISBN { get; set; }
    }
}