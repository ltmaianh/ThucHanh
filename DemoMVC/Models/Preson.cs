using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models{
    //Le Thi Mai Anh-2021050076
    [Table("Presons")]
    public class Preson{
        [Key]
        public string PresonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}