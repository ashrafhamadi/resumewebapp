using ASP_Project.Data;
using ASP_Project.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ASP_Project.Pages
{
    public class BrowseCVsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<UserInfo> CVs { get; set; }

        public BrowseCVsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            CVs = _db.UserInfo;
        }
    }
}
