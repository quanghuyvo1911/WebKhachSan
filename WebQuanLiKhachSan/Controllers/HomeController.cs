using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebQuanLiKhachSan.Models;

namespace WebQuanLiKhachSan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/")]
        //[Route("/")]
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("/chi-tiet-phong")]
        public IActionResult Detail(string RoomType)
        {
            int img = 0;
            if (RoomType == "Phòng Đơn") img = 1;
            if (RoomType == "Phòng Đôi") img = 2;
            if (RoomType == "Phòng 2 Giường Ngủ") img = 3;
            if (RoomType == "Phòng Hạng Sang") img = 4;
            ViewBag.RoomType = RoomType;
            ViewBag.Img = img;
            return View();
        }



    }
}
