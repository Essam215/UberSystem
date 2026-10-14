using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UberSystem.Models
{
    public class Ride
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string PickupLocation { get; set; }

        [Required]
        [StringLength(150)]
        public string DropOffLocation { get; set; }

        [Range(20, 5000)]
        public decimal Fare { get; set; }

        [Required]
        public string Status { get; set; }

        public User Driver { get; set; }
        [ForeignKey(nameof(Rider))]
        public int RiderId { get; set; }

        [ForeignKey(nameof(Driver))]
        public int DriverId { get; set; }

        public User Rider { get; set; }
        public Payment Payment { get; set; }
        public Rating Rating { get; set; }
    }
}
