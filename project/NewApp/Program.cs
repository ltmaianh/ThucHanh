﻿using NewApp.Models;
public class Program
{
    public static void Main(string[]args)
    {

        Employee emp = new Employee();
       Employee emp2 = new Employee();
       emp2.MaNhanVien = "2021050076"; 
       emp2.TenNhanVien = "LeThiMaiAnh";
       emp2.Tuoi = 21;
       emp2.Luong = 3000000;
       emp.HienThiThongTin();
       emp2.HienThiThongTin();
    }
}