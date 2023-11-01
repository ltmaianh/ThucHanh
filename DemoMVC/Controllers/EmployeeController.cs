using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
//Le Thi Mai Anh-2021050076
namespace DemoMVC.Controllers{
 public class EmployeeController:Controller{
      public IActionResult Index(){
         return View();
        }
 [HttpPost]
public IActionResult Index(Employee emp)
            {

                int TinhLuong = (emp.LuongCB) *  (emp.HeSoLuong) +emp.PhuCap;
                string str1 = "FullName: " + " "+ emp.FullName + " " + "Luong: " + TinhLuong + "VND";
                ViewBag.KetQuaTinhLuong = str1;
                return View();
 }
} 
}