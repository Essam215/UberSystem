using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace UberSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Role { get; set; } 
        public List<Ride> Rides { get; set; }
        public List<Ride> Drives { get; set; }
        public Vehicle Vehicle { get; set; }
    }

}