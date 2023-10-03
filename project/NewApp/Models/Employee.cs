namespace NewApp.Models{
    public class Employee{
         public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void NhapThongTin (){
           
        }
        public void HienThiThongTin(){
             System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
        }
        public void ThemMoiThongTin(){

        }
        public void SuaThongTin(){

        }
    }
}