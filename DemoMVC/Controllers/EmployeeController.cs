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
      string strResult = "Hello " + emp.FullName+" "+emp.EmployeeId;
       ViewBag.ThongBao = strResult;
      return View();
 }
} 
}