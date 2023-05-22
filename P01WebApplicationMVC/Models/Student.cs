using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace P01WebApplicationMVC.Models
{
    public class Student
    {
        [Required(ErrorMessage = "wprowadz cos")] //AllowEmptyString = false
        public string Name { get; set; } = default!;
        [Required]
        [EmailAddress]
        
        public string Email { get; set; } = default!;
        public string Country { get; set; } = default!;
        public List<SelectListItem> Countries { get;} = new List<SelectListItem>
        {
            new SelectListItem{Value = "PL", Text = "Polska"},
            new SelectListItem{Value = "DE", Text = "Niemcy"},
            new SelectListItem{Value = "UK", Text = "Wielka Brytania"},
            new SelectListItem{Value = "US", Text = "USA"}

        };

    }
}
