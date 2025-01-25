using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart1.Models
{

    [Table("Orderstatus")]
    public class OrderStatus
    {

        public int Id { get; set; }

        [Required]

        public int StatusId { get; set; }

        [Required,MaxLength(20)]
        public string StatusName { get; set; }



    }
}
