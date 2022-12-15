using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceCatalogue.Model;

namespace ServiceCatalogue.Pages.AppPages.Admin
{
    public class DeleteAdminModel : PageModel
    {

        private readonly AppDbContext _db;

        public DeleteAdminModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ServerAsset ServerAsset { get; set; }


        public void OnGet(int id)
        {
            ServerAsset = _db.ServerAsset.Include(c => c.Apps).FirstOrDefault(e => e.Id == id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var serverQuery = await _db.ServerAsset.Include(c => c.Apps).FirstOrDefaultAsync(e => e.Id == id);

            if (serverQuery != null)
            {
                _db.ServerAsset.Remove(serverQuery);
                await _db.SaveChangesAsync();
                return RedirectToPage("../AdminIndex");
            }

            return Page();
        }
    }
}
