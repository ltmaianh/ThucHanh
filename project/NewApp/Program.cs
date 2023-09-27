using System.Security.Cryptography;
using System.Collections.Specialized;
using NewApp.Models;
public class Program
{
    public static void Main(string[]args){
        Fruit ps1 = new Fruit();
        Fruit ps2 = new Fruit();

        ps1.Ten = "Cam";
        ps1.Vi = "Chua";
        ps1.HienThiThongTin();

        ps2.NhapThongTin();
        ps2.HienThiThongTin();

    }
}
