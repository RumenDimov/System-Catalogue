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
    public class DeleteModel : PageModel
    {

        private readonly AppDbContext _db;
        
        public DeleteModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public SystemAsset SystemAsset { get; set; }

        

        public async Task OnGet(int id)
        {
            SystemAsset = await _db.SystemAsset.Include(c => c.ServerAssets).FirstOrDefaultAsync(e => e.Id == id);

           
        }
        public async Task<IActionResult> OnPost(int id)
        {
            
            var systemFromDb = await _db.SystemAsset.Include(c => c.ServerAssets).FirstOrDefaultAsync(e => e.Id == id);
            if (systemFromDb != null)
            {
               
                _db.SystemAsset.Remove(systemFromDb);
                await _db.SaveChangesAsync();

                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
