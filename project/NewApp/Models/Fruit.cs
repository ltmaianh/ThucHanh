//Le Thi Mai Anh-2021050076
using System.Runtime.Intrinsics.Arm;

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
            System.Console.WriteLine("Gia hoa qua:");
            try{
                Gia =Convert.ToInt16(Console.ReadLine());
            }
            catch(Exception e){
                Gia = 0;
            }
}
public void HienThiThongTin(){
    System.Console.WriteLine("{0}-{1}-{2} vnd",Ten,Vi,Gia);
}

}
}