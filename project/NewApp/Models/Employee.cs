// Le Thi Mai Anh- 2021050076
namespace NewApp.Models{
    public class Employee:Person{
         public string MaNhanVien { get; set; }
       
        
         public void NhapThongTin()
        {
            base.NhapThongTin();
            System.Console.WriteLine("Ma Nhan Vien =");
            MaNhanVien = Console.ReadLine();  
        }

        public void HienThiThongTin()
        {
           base.HienThiThongTin();
           System.Console.WriteLine("Ma nhan vien: {0}", MaNhanVien); 
        }
    }
}