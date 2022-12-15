using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceCatalogue.Model;

namespace ServiceCatalogue.Pages.AppPages
{
    public class AdminModel : PageModel
    {

        private readonly AppDbContext _db;

        public AdminModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ServerAsset ServerAsset { get; set; }


        [BindProperty]
        public AppRole AppRole { get; set; }

        public SelectList AppList { get; set; }

        public void OnGet()
        {
            var appsQuery = from d in _db.AppRole
                                   orderby d.Id // Sort by Id.
                                   select d;

            AppList = new SelectList(appsQuery, "Id", "Role");

        }


        public async Task<IActionResult> OnPost()
        {

            await _db.ServerAsset.AddAsync(ServerAsset);
            await _db.SaveChangesAsync();
            return RedirectToPage("AdminIndex");

        }
    }
}
