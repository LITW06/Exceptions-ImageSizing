using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxFileUpload.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace AjaxFileUpload.Controllers
{
    public class HomeController : Controller
    {

        private IHostingEnvironment _environment;


        public HomeController(IHostingEnvironment environment
            )
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile image)
        {
            using (var imageStream = image.OpenReadStream())
            using (Image<Rgba32> newImage = Image.Load(imageStream))
            {
                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(image.FileName)}";
                string fullPath = Path.Combine(_environment.WebRootPath, "oilpaints", fileName);
                newImage.Mutate(x => x.OilPaint());
                newImage.Save(fullPath);
                return Json(new { name = fileName });
            }


        }

    }
}
