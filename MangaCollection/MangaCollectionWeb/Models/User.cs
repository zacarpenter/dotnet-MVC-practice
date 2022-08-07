using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangaCollectionWeb.Models
{
    public class User
    {
        [Key, Column(Order = 1)]
        public int userId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string firstName { get; set; }
        [Required]
        [StringLength (50, MinimumLength = 3)]
        public string lastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        public string password { get; set; }

        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("password")]
        public string confirmPassword { get; set; }

        public string FullName() { return this.firstName + " " + this.lastName; }
    }
}
