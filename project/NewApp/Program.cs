using System.Security.Cryptography;
using System.Collections.Specialized;
using NewApp.Models;
public class Program
{
    public static void Main(string[]args){
        Student ps1 = new Student();
        Student ps2 = new Student();

        ps1.TenSinhVien = "Le Thi Mai Anh";
        ps1.MaSinhVien = "2021050076";
        ps1.Tuoi = 21;
        ps1.KhoaHoc ="K65";
        ps1.HienThiThongTin();

        ps2.NhapThongTin();
        ps2.HienThiThongTin();

    }
}
