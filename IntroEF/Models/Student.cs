using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroEF.Models
{
    [Table("students")]
    public class Student
    {

        public int? id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string department { get; set; }

        [Required(ErrorMessage = "Program is required")]
        public string program { get; set; }
    }
}
