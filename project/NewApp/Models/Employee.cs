// Le Thi Mai Anh- 2021050076
namespace NewApp.Models{
    public class Employee{
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
            public void NhapThongTin (){
            System.Console.WriteLine("Ma Nhan Vien:");
            MaNhanVien=Console.ReadLine();
            System.Console.WriteLine("Ten nhan vien:");
            TenNhanVien=Console.ReadLine();
            System.Console.WriteLine("Tuoi nhan vien");
            
            try{
                 Tuoi=Convert.ToInt32(Console.ReadLine());
                
            }
            catch(Exception e){
                Tuoi = 0;

        }
        }
        public void HienThiThongTin(){
             System.Console.WriteLine("{0} - {1} - {2} tuoi", MaNhanVien, TenNhanVien, Tuoi);
        }

            }
}