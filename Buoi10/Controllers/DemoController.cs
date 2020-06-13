using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi10.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LayDanhMuc()
        {
            var dm = new DanhMuc
            {
                TenDanhMuc = "Điện thoại",
                SanPham = new string[] { "LG", "Sony", "Samsung", "Iphone" }
            };
            return PartialView("_DanhMuc", dm);
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}