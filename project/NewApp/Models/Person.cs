namespace NewApp.Models{
    public class Person{
         public string HoTen { get; set; }
         public string DiaChi { get; set; }
         public int Tuoi { get; set; }
         public void NhapThongTin(){
            System.Console.WriteLine("Ho ten");
            HoTen = Console.ReadLine();
             System.Console.WriteLine("Dia chi");
            DiaChi = Console.ReadLine();
             System.Console.WriteLine("Tuoi");
             try{
            Tuoi = Convert.ToInt32(Console.ReadLine());
             }
             catch (Exception e){
               Tuoi = 0;
             }
         }
         public void HienThiThongTin(){
            System.Console.WriteLine("{0}-{1}-{2} tuoi",HoTen,DiaChi,Tuoi);
         }
    }
  
}