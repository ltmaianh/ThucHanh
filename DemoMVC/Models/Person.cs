using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
// le thi mai anh - 2021050076
{
    [Table("Person")]
    public class Person
    {
        [Key]
       
        public string PersonID { get; set;}
        public  string FullName { get; set;}
        public  string Address { get; set;}
        
    
    }
}