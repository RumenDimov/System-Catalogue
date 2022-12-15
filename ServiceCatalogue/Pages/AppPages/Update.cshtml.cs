using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceCatalogue.Model;

namespace ServiceCatalogue.Pages.AppPages
{
    public class UpdateModel : PageModel
    {
        private AppDbContext _db;

        public UpdateModel(AppDbContext db)
        {
            _db = db;
        }

        

        [BindProperty]

        public SystemAsset SystemAsset { get; set; }

        public SelectList ServerNameSL { get; set; }
        public void OnGet(int id)
        {
            SystemAsset = _db.SystemAsset.Include(c => c.ServerAssets).FirstOrDefault(e => e.Id == id);

            var serversQuery = from d in _db.ServerAsset
                               where d.Active == true
                               orderby d.Id // Sort by Id.
                               select d;

            ServerNameSL = new SelectList(serversQuery, "Id", "ServerName");
        }





        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var SystemFromDb = await _db.SystemAsset.FindAsync(SystemAsset.Id);
                SystemFromDb.Name = SystemAsset.Name;
                SystemFromDb.Website = SystemAsset.Website;
                SystemFromDb.Wiki = SystemAsset.Wiki;
                SystemFromDb.LastDeployed = SystemAsset.LastDeployed;
                SystemFromDb.ServerAssetsId = SystemAsset.ServerAssetsId;
                
               


                await _db.SaveChangesAsync();

                return RedirectToPage("/Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
        
    }
}
