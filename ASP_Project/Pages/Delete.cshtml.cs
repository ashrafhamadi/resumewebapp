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
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public CV CV { get; set; }
        [BindProperty]
        public UserInfo user { get; set; }
        /*[BindProperty]
        public ProgrammingSkills programmingskills { get; set; }*/

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            user = _db.UserInfo.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var userFromDb = _db.UserInfo.Find(user.Id);
            if(userFromDb!= null)
            {
                _db.UserInfo.Remove(userFromDb);
                await _db.SaveChangesAsync();
                return RedirectToPage("./BrowseCvs");
            }
            return Page();
        }


        
    }

    


}
