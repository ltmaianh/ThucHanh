using System.ComponentModel.DataAnnotations;
namespace DEMOMVC.Models
{
//Le Thi Mai Anh-2021050076
    public class Student
    {
       [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public int Age { get; set; }

    }
}

//Le Thi Mai Anh-2021050076