//Le Thi Mai Anh-2021050076
namespace NewApp.Models{
   public class Fruit{
        public string Ten { get; set; }
        public string Vi { get; set; }
        public int Gia { get; set; }
        public int KhoiLuong { get; set; }
        public int TinhTien(int Gia, int KhoiLuong){
            int Tien = Gia * KhoiLuong;
            return Tien;
        }
}
}