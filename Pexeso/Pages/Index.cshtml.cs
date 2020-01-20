using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pexeso.Models;
using Pexeso.Services;

namespace Pexeso.Pages
{
    public class IndexModel : PageModel
    {
        public ApplicationDbContext _db { get; set; }
        public IService _service { get; set; }
        public IndexModel(IService service, ApplicationDbContext db)
        {
            _db = db;
            _service = service;
        }
        public void OnGet()
        {
            _db.Database.EnsureDeleted();
            _db.Database.EnsureCreated();
            _service.New_Game();
        }
    }
}
