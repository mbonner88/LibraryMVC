﻿using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        [DataType(DataType.Date)] 
        public DateTime PublicationDate { get; set; }
        [Display(Name = "ISBN")]
        public int? Isbn { get; set; }
    }
}
