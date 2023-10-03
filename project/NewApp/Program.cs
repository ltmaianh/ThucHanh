﻿using NewApp.Models;
public class Program
{
    public static void Main(string[]args)
    {

        Student std = new Student();

        string MaSV = "2021050076";
        string HoTen = "Le Thi Mai Anh";
        string DiaChi = "Ha Noi";
       
        int a = 21;

        System.Console.WriteLine("{0} - {1} - {2} -{3}",MaSV,HoTen,DiaChi,std.NamSinhSv(a));


    }
}