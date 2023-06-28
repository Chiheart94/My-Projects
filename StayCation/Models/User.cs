using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StayCation.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }


        [Required]
        public string? Email { get; set; }


        [Required]
        public string? PassWord { get; set; }
    }
}
