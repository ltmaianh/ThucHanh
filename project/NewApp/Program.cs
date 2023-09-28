using System.Security.Cryptography;
using System.Collections.Specialized;
using NewApp.Models;

 
        public class Program
{
    public static void Main(string[]args)
    {  
        Student std = new Student();
         string MaSV = "2021050076";
        string HoTen = "Le Thi Mai Anh";
        string DiaChi = "Ha Noi";
        std.ThongTin(MaSV,HoTen,DiaChi);  
    }
}