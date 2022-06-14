using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HR_WebApp.Models
{
    public class StaffCreateViewModel
    {
        [DisplayName("Voornaam")]
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [DisplayName("Achternaam")]
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [DisplayName("Adres")]
        [MaxLength(100)]
        public string Address { get; set; }
        [DisplayName("Tewerkstelling sinds")]
        [Required]
        public DateOnly DOE { get; set; }

    }
}
