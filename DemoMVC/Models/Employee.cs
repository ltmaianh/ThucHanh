using System.ComponentModel.DataAnnotations;
//Le Thi Mai Anh-2021050076
namespace DemoMVC.Models
{
    public class Employee:Person
    {
        public string EmployeeId { get; set; } 
        public int Age { get; set; }
    //Le Thi Mai Anh-201050076
    }
}