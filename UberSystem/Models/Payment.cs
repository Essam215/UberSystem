using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UberSystem.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Range(20, 5000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } 

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public string Status { get; set; }

        [Required, ForeignKey("RideId")]
        public int RideId { get; set; }
        public Ride Ride { get; set; }
    }
}
