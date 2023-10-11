﻿using System.Collections.ObjectModel;
using NewApp.Models;
﻿using System.Collections;
//Le Thi Mai Anh-2021050076
public class Program
{
    public static void Main(string[]args)
    {
        ArrayList StudentList = new ArrayList();

      int n;
       System.Console.WriteLine("So phan tu muon them vao:");
        n = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < n; i++)
{
    Student std = new Student ();
    std. NhapThongTin();
    StudentList.Add(std);
}
 foreach(Student std in StudentList){
            std.HienThiThongTin();
        }
        string TenSinhVien = null;
        System.Console.WriteLine($"Nhap ten sinh vien can thay doi: {TenSinhVien}");
        TenSinhVien = Console.ReadLine();
          for(int i = 0; i < StudentList.Count; i++)
           {   
             Student std = (Student) StudentList[i];
             if (std.TenSinhVien == TenSinhVien){
                 std.NhapThongTin();
                  break;
                 }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }
    }
    foreach(Student std in StudentList){
            std.HienThiThongTin();
        }
         System.Console.WriteLine("Nhap ten hoc sinh can xoa: ");
        TenSinhVien = Console.ReadLine();

        for(int i=0; i < StudentList.Count; i++ )
        {
            Student std = (Student) StudentList[i];
            if(std.TenSinhVien == TenSinhVien)
            {
                StudentList.RemoveAt(i);
                System.Console.WriteLine($"da xoa hoc sinh co ten la: {TenSinhVien}");
                break;
            }
        } 
        foreach(Student std in StudentList){
            std.HienThiThongTin();
        }
}
}