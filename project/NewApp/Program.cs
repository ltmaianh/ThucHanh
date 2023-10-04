﻿using NewApp.Models;
public class Program
{
    public static void Main(string[]args)
    {

        Fruit frt= new Fruit();
        string Ten = "Tao";
        string Vi ="Ngot";
        int Gia =20000;
        int KhoiLuong= 3;
        System.Console.WriteLine("{0}-{1}-{2}",Ten,Vi,frt.TinhTien(Gia,KhoiLuong));
    }
}