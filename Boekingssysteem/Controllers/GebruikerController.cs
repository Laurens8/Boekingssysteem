using Boekingssysteem.Areas.Identity.Data;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace Boekingssysteem.Controllers
{
    //[Authorize(Roles = "admin")]
    public class GebruikerController : Controller
    {       
            private UserManager<CustomUser> _userManager;
            private RoleManager<IdentityRole> _roleManager;

            public GebruikerController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
            {
                _userManager = userManager;
                _roleManager = roleManager;
            }

            public IActionResult Index()
            {
                GebruikerListViewModel viewModel = new GebruikerListViewModel()
                {
                    Gebruikers = _userManager.Users.ToList()
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

                    IdentityResult result = await _userManager.CreateAsync(gebruiker, viewModel.Password);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                return View(viewModel);
            }



            public async Task<IActionResult> Delete(string id)
            {
                CustomUser user = await _userManager.FindByIdAsync(id);
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
                    if (user != null && role != null)
                    {
                        IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                        if (result.Succeeded)
                            return RedirectToAction("Index");
                        else
                        {
                            foreach (IdentityError error in result.Errors)
                                ModelState.AddModelError("", error.Description);
                        }
                    }
                    else
                        ModelState.AddModelError("", "User or role Not Found");
                }
                return View(viewModel);
            }

        }
    }
