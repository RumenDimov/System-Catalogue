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
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

    

        [BindProperty]
        public SystemAsset SystemAsset { get; set; }

        [BindProperty]

        public ServerAsset ServerAsset { get; set; }


        public SelectList ServerNameSL { get; set; }

        public void OnGet()
        {   
            var serversQuery = from d in _db.ServerAsset
                               where d.Active == true
                                   orderby d.Id // Sort by Id.
                                   select d;

            ServerNameSL = new SelectList(serversQuery, "Id", "ServerName");
            
        }

        


        public async Task<IActionResult> OnPost()

        {
               
            
                await _db.SystemAsset.AddAsync(SystemAsset);

                await _db.SaveChangesAsync();

                return RedirectToPage("/Index");
            
               
                

            
            
        }
    }
}
