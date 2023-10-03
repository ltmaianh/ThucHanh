namespace NewApp.Models{
     public class Student {
         public string MaSV {get; set;} 
         public string HoTen {get; set; } 
         public string DiaChi{get; set;} 
         public int Tuoi{get; set;}
         public int NamSinhSv(int Tuoi)
         { 
            int NamSinh = 2023 - Tuoi;
            return NamSinh; 
         } 
      } 
    }