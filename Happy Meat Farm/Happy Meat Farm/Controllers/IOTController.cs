using FireSharp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Happy_Meat_Farm.Controllers
{
    public class IOTController : Controller
    {
        //IFirebaseConfig Config = new IFirebaseConfig
        //{
        //    AuthSecret = "";
        //    BasePass = "";
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
