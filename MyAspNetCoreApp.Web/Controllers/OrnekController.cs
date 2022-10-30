using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.name = "ASP.NET CORE";
            //ViewData["age"] = 30;
            //ViewData["names"] = new List<string>() {"serife", "serife", "serife" };
            //ViewBag.person = new { Id=1, Name="serife", Age=22 };
            //TempData["surname"] = "toy";


            var productList = new List<Product>()
            {
                new(){ Id=1, Name="Kalem"},
                new(){ Id=2, Name="Silgi"},
                new(){ Id=3, Name="Defter"}
            };
            return View(productList);
        }

        public IActionResult Index3()
        {
            return View();

        }
        public IActionResult Index2()
        {
            return RedirectToAction("Index");
            
            //return View();
        }

        public IActionResult ParametreView( int id )
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new {id =id}); //ilk yazılan id JsonResultParametre'nin idsi
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id});
        }

        public IActionResult ContentResult()//url kısmına name olarak bu kısmı ekliyoruz
        {
            return Content("string dönme işlemi : content result");
        }

        public IActionResult JsonResult()//json diğerlerinden farklı olarak view de görüntüleme olmazsa hata alır
        {
            return Json( new {Id=1 , price =100, name ="kalem1"}); 
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
