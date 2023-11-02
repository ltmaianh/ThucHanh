using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
//Le Thi Mai Anh-2021050076
namespace DemoMVC.Controllers{
    public class PresonController: Controller{
        public IActionResult Index(){
    return View();
}
[HttpPost]
public IActionResult Index(Preson ps)
    {
        string strResult = "Hello " + ps.FullName +" "+ps.PresonId;
        ViewBag.ThongBao = strResult;
        return View();
    }
}
}
