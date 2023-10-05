namespace NewApp.Models{
    public class Student{
      //Le Thi Mai Anh-2021050076
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public int Tuoi { get; set; }
        public string KhoaHoc{get;set;}
        public void NhapThongTin (){
            System.Console.WriteLine("Ma sinh Vien:");
            MaSinhVien=Console.ReadLine();
            System.Console.WriteLine("Ten sinh vien:");
            TenSinhVien=Console.ReadLine();
            System.Console.WriteLine("Khoa hoc:");
            KhoaHoc=Console.ReadLine();
            System.Console.WriteLine("Tuoi sinh vien");
            try{
               Tuoi=Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e){
               Tuoi = 0;
            }
    }
    public void HienThiThongTin(){
        System.Console.WriteLine("{0}-{1}-{2} tuoi-{3}",MaSinhVien, TenSinhVien, Tuoi,KhoaHoc);
    }
}
}