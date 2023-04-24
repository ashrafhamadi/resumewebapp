using ASP_Project.Data;
using ASP_Project.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ASP_Project.Pages
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public CV CV { get; set; }
        [BindProperty]
        public UserInfo user { get; set; }
        /*[BindProperty]
        public ProgrammingSkills programmingskills { get; set; }*/

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            user = _db.UserInfo.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (user.Email != CV.ConfirmEmail) { ModelState.AddModelError(string.Empty, "Emails dont match!"); }
            if (CV.ValidationX + CV.ValidationY != CV.ValidationZ) { ModelState.AddModelError(string.Empty, "The numbers don't add up to the sum!"); }
            if (ModelState.IsValid)
            {
                if (user.Gender == "Male")
                {
                    user.Grade = user.Grade + 5;
                }
                else
                {
                    user.Grade = user.Grade + 10;
                }
                _db.UserInfo.Update(user);
                await _db.SaveChangesAsync();

                return RedirectToPage("./BrowseCvs");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please fill all the form!");
                return Page();
            }
        }


        
    }

    


}
