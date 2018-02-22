using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackingion.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Authorization;

namespace hackingion.Controllers
{
    public class HomeController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;
        private ModelsDb db;
        private ModelsDb _context;
        private IHostingEnvironment _appEnvironment;
        //private readonly UserManager<AppUser> _userManager;
        public HomeController(ModelsDb context, IHostingEnvironment appEnvironment, RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager /*UserManager<AppUser> userManager*/)
        {
            //_userManager = userManager;
            db = context;
            _context = context;
            _appEnvironment = appEnvironment;
        }
        public object WebSecurity { get; private set; }
        public string ErrMessage;
        public string Description { get; set; }
        //public Image ResourceImage;
        public bool ThumbnailCallback()
        {
            return false;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Events()
        {
            return View();
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult File()
        {

            return View(/*_context.Files.ToList()*/);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult File(FileViewModel fvm)
        {
            if (ModelState.IsValid)
            { 
                FileModel image = new FileModel { Name = fvm.Name, Description = fvm.Description, Breed = fvm.Breed, Age = fvm.Age, Gender = fvm.Gender, Color = fvm.Color, Email = fvm.Email, Telephone = fvm.Telephone };
            if (fvm.File != null)
            {

        byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new System.IO.BinaryReader(fvm.File.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)fvm.File.Length);
                }
                // установка массива байтов
                image.File = imageData;
            }
               

                _context.Files.Add(image);
            _context.SaveChanges();
            }
            return RedirectToAction("File");
            
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                FileModel FileId = await db.Files.FirstOrDefaultAsync(p => p.Id == id); 
                if (FileId != null)
                {
                    db.Files.Remove(FileId);
                    await db.SaveChangesAsync();
                    return RedirectToAction("File");
                }
            }
            return NotFound();
        }



    }
}
