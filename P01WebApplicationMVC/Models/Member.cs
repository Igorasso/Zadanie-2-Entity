using P01WebApplicationMVC.Models.Validators;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace P01WebApplicationMVC.Models
{
    public class Member
    {
        [Required(ErrorMessage = "Podaj nazwę")]
        [MinLength(2,ErrorMessage = "za krótki tekst")]
        [MaxLength(10,ErrorMessage = "Za długi")]
        //[StringLenght(30)]
        public string Name { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
        
        
        [Url]
        public string Url { get; set; } = "";
        // [Required(AllowEmptyStrings = true)]
        [Required]
        [RegularExpression(@"^\d{2}-\d{3}$",ErrorMessage = "podaj poprawny zipcode")]
        public string ZipCode { get; set; } = "";

        //[Range(0,150, ErrorMessage = "Podaj poprawny wiek!")]
        [AgeOver(18)]
        public int Age { get; set; }


    }

}
