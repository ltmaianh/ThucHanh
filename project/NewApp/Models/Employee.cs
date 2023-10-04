namespace NewApp.Models{
    public class Employee{
         public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
       
        public int TinhLuong(int Luong){
            int TLuong = Luong + 500000;
            return TLuong;

        }
    }
}