using System.Security.Cryptography;
using System.Collections.Specialized;
using NewApp.Models;
public class Program
{
    public static void Main(string[]args){
        Employee ps1 = new Employee();
        Employee ps2 = new Employee();

        ps1.TenNhanVien = "Nguyen van a";
        ps1.MaNhanVien = "a123456";
        ps1.Tuoi = 21;
        ps1.Luong =5000000;
        ps1.HienThiThongTin();

        ps2.NhapThongTin();
        ps2.HienThiThongTin();

    }
}
