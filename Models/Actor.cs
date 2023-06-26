using System.ComponentModel.DataAnnotations;

namespace eMovie_Ticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set;}
        [Required(ErrorMessage = "Bio is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Full Name must be between 6 and 50 words!")]
        [Display(Name = "Biography")]
        public string Bio { get; set;}

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }   
    }
}
