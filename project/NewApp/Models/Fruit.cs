//Le Thi Mai Anh-2021050076
namespace NewApp.Models{
   public class Fruit{
        public string Ten { get; set; }
        public string Vi { get; set; }
    
        
public void HienThiThongTin(string Ten,string Vi){
    System.Console.WriteLine("{0}-{1}",Ten,Vi);
}
}
}