//Le Thi Mai Anh-2021050076
namespace NewApp.Models{
   public class Fruit{
        public string Ten { get; set; }
        public string Vi { get; set; }
        public int Gia { get; set; }
           public void NhapThongTin (){
            System.Console.WriteLine("Ten hoa qua :");
            Ten=Console.ReadLine();
            System.Console.WriteLine("Vi Hoa qua:");
            Vi=Console.ReadLine();
}
public void HienThiThongTin(){
    System.Console.WriteLine("{0}-{1}",Ten,Vi);
}

}
}