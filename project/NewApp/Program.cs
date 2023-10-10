﻿using NewApp.Models;
public class Program
{
    public static void Main(string[]args)
    {
      int n;

      Console.Write("\n" + "Nhap kich thuoc mang Employee: ");
        n = Convert.ToInt32(Console.ReadLine());
        Employee[] empArr = new Employee[n];
        for(int i = 0; i < empArr.Length; i++){
            Console.WriteLine("Nhap thong tin nhan vien thu {0}", i+1);
            Employee emp = new Employee();
            emp.NhapThongTin();
            empArr[i] = emp;
        }
        Console.WriteLine("Hien thi mang Employee");
        foreach(Employee emp in empArr){
            emp.HienThiThongTin();
        }
        string TenNhanVien = null;
        System.Console.WriteLine($"Nhap ten nhan vien can thay doi: {TenNhanVien}");
        TenNhanVien = Console.ReadLine();
          for(int i = 0; i < empArr.Length; i++)
        {   
            Employee emp = (Employee) empArr[i];
             if ( emp.TenNhanVien == TenNhanVien){

                emp.NhapThongTin();
                break;
                 }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }
    }
    Console.WriteLine("Hien thi mang Employee");
        foreach(Employee emp in empArr){
            emp.HienThiThongTin();
}
}
}