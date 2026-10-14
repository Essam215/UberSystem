using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UberSystem.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Range(1, 5)]
        public int Score { get; set; }
        [MaxLength(250)]
        public string Comment { get; set; }
        [ForeignKey("RideId")]
        public int RideId { get; set; }
        public Ride Ride { get; set; }
    }
}
