﻿using NewApp.Models;
//Le Thi Mai Anh-2021050076
public class Program
{
    public static void Main(string[]args)
    {
      int n;

      Console.Write("\n" + "Nhap kich thuoc mang Student: ");
        n = Convert.ToInt32(Console.ReadLine());
        Student[] stdArr = new Student[n];
        for(int i = 0; i < stdArr.Length; i++){
            Console.WriteLine("Nhap thong tin hoc sinh thu {0}", i+1);
            Student std = new Student();
            std.NhapThongTin();
            stdArr[i] = std;
        }
        Console.WriteLine("Hien thi mang Student");
        foreach(Student std in stdArr){
            std.HienThiThongTin();
        }
        string TenSinhVien = null;
        System.Console.WriteLine($"Nhap ten sinh vien can thay doi: {TenSinhVien}");
        TenSinhVien = Console.ReadLine();
          for(int i = 0; i < stdArr.Length; i++)
        {   
            Student std = (Student) stdArr[i];
             if (std.TenSinhVien == TenSinhVien){

                std.NhapThongTin();
                break;
                 }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }
    }
    Console.WriteLine("Hien thi mang Student");
        foreach(Student std in stdArr){
            std.HienThiThongTin();
}
}
}