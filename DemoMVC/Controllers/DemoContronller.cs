using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers{
    public class DemoController : Controller{
//khai bao cac phuong thuc
public IActionResult Index(){
    return View();
}
[HttpPost]
public IActionResult Index(string FName,string PassWord)
    {
        string strResult = "Hello " + FName;
        ViewBag.ThongBao = strResult;
        return View();
    }
    

    }
}