namespace NewApp.Models{
    //Le Thi Mai Anh-2021050076
    public class Customer{
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public void NhapThongTin(){
            System.Console.WriteLine("Ma khach hang la :",MaKhachHang);
            MaKhachHang = Console.ReadLine();
            System.Console.WriteLine("Ten khach hang:",TenKhachHang);
            TenKhachHang = Console.ReadLine();
            System.Console.WriteLine("Dia chi:",DiaChi);
            DiaChi = Console.ReadLine();
        }
        public void HienThiThongTin(){
            System.Console.WriteLine("{0}-{1}-{2}",MaKhachHang,TenKhachHang,DiaChi);
        }
    }
}