//Le Thi Mai Anh
namespace NewApp.Models{
    public class Nho:Fruit{
        public string Loai { get; set; }
          public void NhapThongTin()
        {
            base.NhapThongTin();
            System.Console.WriteLine("Loai nho  =");
            Loai = Console.ReadLine();  
        }

        public void HienThiThongTin()
        {
           base.HienThiThongTin();
           System.Console.WriteLine("Loai = {0}", Loai); 
        }

    }
}