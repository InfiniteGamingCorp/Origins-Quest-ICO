using System.ComponentModel.DataAnnotations;

namespace OriginsQuestICO.ViewModels
{
    public class ContactFormViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}