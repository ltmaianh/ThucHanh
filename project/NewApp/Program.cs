﻿using NewApp.Models;
public class Program
{
    public static void Main(string[]args)
    {

        Employee emp = new Employee();
     
      string MaNhanVien = "2021050076"; 
       string TenNhanVien = "LeThiMaiAnh";
       int Tuoi = 21;
       int Luong =3000000;
       emp.ThongTin(MaNhanVien,TenNhanVien,Tuoi,Luong);
       
    }
}