﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart1.Models
{
    [Table("Book")]
    public class Book
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }
        [Required]

        public string? AuthorName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<CartDetail> CartDetails { get; set; }

        [NotMapped ] public string GenreName     { get; set;}



    }
}
