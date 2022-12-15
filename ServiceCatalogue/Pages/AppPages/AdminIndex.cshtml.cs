using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceCatalogue.Model;

namespace ServiceCatalogue.Pages.AppPages
{
    public class AdminIndexModel : PageModel
    {

        private readonly AppDbContext _db;

        public AdminIndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<ServerAsset> ServerAsset { get; set; }

        public void OnGet()
        {
            ServerAsset = _db.ServerAsset.Include(c => c.Apps).ToList();
        }
    }
}
