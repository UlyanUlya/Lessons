using System.ComponentModel.DataAnnotations;

namespace Lesson5.Models
{
    public class Friend
    {
        [Required]
        public int FriendId { get; set; }

        [Required(ErrorMessage = "Friend Name Empty Not Allowed.")]
        public string FriendName { get; set; }

        [StringLength(25)]
        public string Place { get; set;}
    }
}
