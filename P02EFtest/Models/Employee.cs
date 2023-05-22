using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02EFtest.Models
{
    [Table("Pracownicy")]
    //[Index("Email",IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        //[PrimaryKey] - jeśli pole nazwya się Id, to nie trzeba przypisywać primary key, w EF jest traktowane defaultowo. 
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj imie i nazwisko")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(200)]
        
        public string? Address { get; set; }
        [StringLength(12)]
        public string? PhoneNumber { get; set; }



    }
}
