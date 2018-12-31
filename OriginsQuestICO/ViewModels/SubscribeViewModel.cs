using System.ComponentModel.DataAnnotations;

namespace OriginsQuestICO.ViewModels
{
    public class SubscribeViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}