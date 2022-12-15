using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceCatalogue.Model;

namespace ServiceCatalogue.Pages.AppPages.Admin
{
    public class UpdateAdminModel : PageModel
    {
        private readonly AppDbContext _db;

        public UpdateAdminModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ServerAsset ServerAsset { get; set; }

        public SelectList AppList { get; set; }
        public void OnGet(int id)
        {
            ServerAsset = _db.ServerAsset.Include(c => c.Apps).FirstOrDefault(e => e.Id == id);

            var appsQuery = from d in _db.AppRole
                            orderby d.Id // Sort by Id.
                            select d;

            AppList = new SelectList(appsQuery, "Id", "Role");
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var serverFromDb = await _db.ServerAsset.Include(c => c.Apps).FirstOrDefaultAsync(e => e.Id == id);
            serverFromDb.ServerName = ServerAsset.ServerName;
            serverFromDb.Active = ServerAsset.Active;
            serverFromDb.AppsId = ServerAsset.AppsId;

            await _db.SaveChangesAsync();

            return RedirectToPage("../AdminIndex");
        }
    }
}
