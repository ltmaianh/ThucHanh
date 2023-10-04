﻿using NewApp.Models;
public class Program
{
    public static void Main(string[]args)
    {

        Employee emp = new Employee();
     
      string MaNhanVien = "2021050076"; 
       string TenNhanVien = "LeThiMaiAnh";
       int Tuoi = 21;
       int a = 3000000;
     System.Console.WriteLine("{0}-{1}-{2}-{3}",MaNhanVien,TenNhanVien,Tuoi,emp.TinhLuong(a));
    }
}