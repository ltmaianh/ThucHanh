namespace NewApp.Models{
    public class Employee{
         public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public Employee()
    {
         string MaNhanVien = "2021050076"; 
       string TenNhanVien = "LeThiMaiAnh";
       int Tuoi = 21;
       int Luong = 3000000;
    }
        public void HienThiThongTin(){
             System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
        }
    }
}