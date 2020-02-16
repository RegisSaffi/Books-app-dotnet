using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Books_218011357.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "International Standard book number"),Required,MaxLength(13)]
        public string ISBN { get; set; }
        
        [Display(Name = "Book title"),Required,MaxLength(200)]
        public string Title { get; set; }
    }
}