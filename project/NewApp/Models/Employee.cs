namespace NewApp.Models{
    public class Employee{
         public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
       
        public void ThongTin(string MaNhanVien,string TenNhanVien,int Tuoi,int Luong){
             System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
        }
    }
}