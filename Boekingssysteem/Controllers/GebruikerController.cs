using Boekingssysteem.Areas.Identity.Data;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Boekingssysteem.Models;
using Boekingssysteem.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace Boekingssysteem.Controllers
{
    [Authorize(Roles = "admin")]
    public class GebruikerController : Controller
    {
        private readonly BoekingssysteemContext _context;
        private UserManager<CustomUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public GebruikerController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, BoekingssysteemContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public IActionResult Index()
        {
            GebruikerListViewModel viewModel = new GebruikerListViewModel()
            {
                Gebruikers = _userManager.Users.ToList(),
                Roles = _context.Personen.ToList()
            };
            return View(viewModel);
        }

        public IActionResult Details(string id)
        {
            CustomUser gebruiker = _userManager.Users.Where(k => k.Id == id).FirstOrDefault();
            if (gebruiker != null)
            {
                GebruikerDetailsViewModel viewModel = new GebruikerDetailsViewModel()
                {
                    Id = gebruiker.Id,
                    Naam = gebruiker.Naam,
                    UserName = gebruiker.UserName,
                    Voornaam = gebruiker.Voornaam,
                    Personeelnummer = gebruiker.Personeelnummer,
                };
                return View(viewModel);
            }
            else
            {
                GebruikerListViewModel viewModel = new GebruikerListViewModel()
                {
                    Gebruikers = _userManager.Users.ToList()
                };
                return View("Index", viewModel);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGebruikerViewModel viewModel)
        {
            if (viewModel.Personeelnummer.Length != 8)
            {

            }
            if (ModelState.IsValid)
            {
                CustomUser gebruiker = new CustomUser
                {
                    Naam = viewModel.Naam,
                    Voornaam = viewModel.Voornaam,
                    Personeelnummer = viewModel.Personeelnummer,
                    UserName = viewModel.Email,
                    Email = viewModel.Email
                };

                if (gebruiker.Personeelnummer.Length != 8 && viewModel.Personeelnummer.Length != 8)
                {
                    ModelState.AddModelError("", "personeelsnummer moet minstens 8 tekens bevatten");
                }
                else
                {
                    _context.Add(new Persoon()
                    {
                        Naam = viewModel.Naam,
                        Voornaam = viewModel.Voornaam,
                        Personeelnummer = viewModel.Personeelnummer,
                        Wachtwoord = viewModel.Password,
                        Admin = false
                    });
                    await _context.SaveChangesAsync();



                    IdentityResult result = await _userManager.CreateAsync(gebruiker, viewModel.Password);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(viewModel);
        }



        public async Task<IActionResult> Delete(string id)
        {

            CustomUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                Persoon persoon = await _context.Personen.FindAsync(user.Personeelnummer);
                _context.Personen.Remove(persoon);
                await _context.SaveChangesAsync();
            }

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", _userManager.Users.ToList());
        }

        public IActionResult GrantPermissions()
        {
            GrantPermissionsViewModel viewModel = new GrantPermissionsViewModel()
            {
                Gebruikers = new SelectList(_userManager.Users.ToList(), "Id", "UserName"),
                Rollen = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GrantPermissions(GrantPermissionsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = await _userManager.FindByIdAsync(viewModel.GebruikerId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);
                string personeelnummer = _userManager.Users.Where(k => k.Id == viewModel.GebruikerId).Select(k => k.Personeelnummer).FirstOrDefault();
                Persoon persoon = await _context.Personen.FindAsync(personeelnummer);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (role.Name == "admin")
                    {
                        persoon.Admin = true;
                        result = await _userManager.RemoveFromRoleAsync(user, "user");
                    }
                    else
                    {
                        persoon.Admin = false;
                        await _context.SaveChangesAsync();
                        result = await _userManager.RemoveFromRoleAsync(user, "admin");
                    }                        
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", $"Gebruiker heeft de rol {role.Name} al");
                    }
                }
                else
                    ModelState.AddModelError("", $"Gebruiker heeft de rol {role.Name} al");
            }
            return View(viewModel);
        }

    }
}
