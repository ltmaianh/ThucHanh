﻿using NewApp.Models;
//Le Thi Mai Anh-2021050076
public class Program
{
    public static void Main(string[]args)
    {
      int n;

      Console.Write("\n" + "Nhap kich thuoc mang Customer: ");
        n = Convert.ToInt32(Console.ReadLine());
        Customer[] cusArr = new Customer[n];
        for(int i = 0; i < cusArr.Length; i++){
            Console.WriteLine("Nhap thong tin khach hang thu {0}", i+1);
            Customer cus = new Customer();
            cus.NhapThongTin();
            cusArr[i] = cus;
        }
        Console.WriteLine("Hien thi mang Customer");
        foreach(Customer cus in cusArr){
            cus.HienThiThongTin();
        }
        string TenKhachHang = null;
        System.Console.WriteLine($"Nhap ten khach hang can thay doi: {TenKhachHang}");
        TenKhachHang = Console.ReadLine();
          for(int i = 0; i < cusArr.Length; i++)
        {   
            Customer cus = (Customer) cusArr[i];
             if (cus.TenKhachHang == TenKhachHang){

                cus.NhapThongTin();
                break;
                 }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }
    }
    Console.WriteLine("Hien thi mang Customer");
        foreach(Customer cus in cusArr){
            cus.HienThiThongTin();
}
}
}