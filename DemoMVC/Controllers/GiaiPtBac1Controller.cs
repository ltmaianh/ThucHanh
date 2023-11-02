using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
//Le Thi Mai Anh-2021050076
namespace DemoMVC.Controllers{
    public class GiaiPtBac1:Controller{
       public IActionResult Index(){
         return View();
        }
        [HttpPost]
public IActionResult Index(double a,double b)  {
     if (a==0)
            {
                if (b==0)
                {
                    ViewBag.ThongBao = "Phuong Trinh Co Vo So Nghiem";
                }else{
                    ViewBag.ThongBao = "Phuong Trinh Vo Nghiem";
                }
            }else{
                double x =-b/a;
                ViewBag.ThongBao = $"Phuong trinh co nghiem la: x = {x}";
            }
    return View();
}
    }
}
