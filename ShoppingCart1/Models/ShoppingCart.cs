﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart1.Models
{

    [Table("ShoppingCart")]
    public class ShoppingCart
    {

        public int Id { get; set; }


        [Required]
        public string UserId { get; set; }
        
        public bool IsDeleted { get; set; }=false;

    }
}
