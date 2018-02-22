using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using hackingion.Models;
using Microsoft.AspNetCore.Authorization;

namespace hackingion.Controllers
{

    public class AdminController : Controller
    {
        
            UserManager<AppUser> _userManager;

            public AdminController(UserManager<AppUser> userManager)
            {
                _userManager = userManager;
            }

            public IActionResult Index() => View(_userManager.Users.ToList());

            public IActionResult Create() => View();

   
        [HttpPost]
            public async Task<IActionResult> Create(CreateUser model)
            {
                if (ModelState.IsValid)
                {
                    AppUser user = new AppUser { UserName = model.UserName, Password = model.Password };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                return View(model);
            }

        public async Task<IActionResult> Edit(string id)
            {
                AppUser user = await _userManager.FindByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                EditUser model = new EditUser { Id = user.Id, UserName = user.UserName, Password = user.Password };
                return View(model);
            }
   
        [HttpPost]
            public async Task<IActionResult> Edit(EditUser model)
            {
                if (ModelState.IsValid)
                {
                    AppUser user = await _userManager.FindByIdAsync(model.Id);
                    if (user != null)
                    {
                        user.UserName = model.UserName;
                        user.Password = model.Password;
                        

                        var result = await _userManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError(string.Empty, error.Description);
                            }
                        }
                    }
                }
                return View(model);
            }

        [HttpPost]
            public async Task<ActionResult> Delete(string id)
            {
                AppUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(user);
                }
                return RedirectToAction("Index");
            }
        }
    }

