using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ServiceCatalogue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ServiceCatalogue.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        
        //public ServerAsset Server { get; set; }
        public IEnumerable<SystemAsset> SystemAssets { get; set; }

        

        public IList<ServerAsset> ServerAsset { get; set; }

       

        public async Task OnGetAsync()
        {
            /*
            var obj = from cols in _db.SystemAsset
                      from c in _db.ServerAsset
                      where cols.Id == c.ServerId
                      select new
                      {
                          name = cols.Name,
                          website = cols.Website,
                          wiki = cols.Wiki,
                          lastdeployed = cols.LastDeployed,
                          serverName = c.ServerName
                      };

             await obj.ToListAsync(); */

            SystemAssets = await _db.SystemAsset.Include(c => c.ServerAssets).ToListAsync();

            

        } 





            public async Task<IActionResult> OnGetSystemsAll()
        {
            var allData = await _db.SystemAsset.Include(c => c.ServerAssets).ToListAsync();
            return new JsonResult(allData);

            
        }


        
        

    }
}
