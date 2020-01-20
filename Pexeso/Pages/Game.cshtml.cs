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
    public class GameModel : PageModel
    {
        public ApplicationDbContext _db { get; set; }
        public IService _service { get; set; }
        public GameModel(IService service, ApplicationDbContext db)
        {
            _db = db;
            _service = service;
        }
        public void OnGet()
        {
        }
        public void OnGetClick(int j)
        {
            _service.Increment();
            if (_db.Pole.Find(1).score <= 2)
            {
                _service.Click(j);
            }
            if (_db.Pole.Find(1).score == 1)
            {
                _db.Pole.Find(1).temp1 = _service.Cards[j].Id;
                _db.SaveChanges();
            }
            if (_db.Pole.Find(1).score == 2)
            {
                _db.Pole.Find(1).temp2 = _service.Cards[j].Id;
                _db.SaveChanges();
            }
        }
        public void OnGetCheckSame()
        {
            if(_db.Cards.Find(_db.Pole.Find(1).temp1).Id == _db.Cards.Find(_db.Pole.Find(1).temp2).Id_pair)
            {
                _db.Pole.Find(1).score = 0;
                _db.Pole.Find(1).temp1 = 0;
                _db.Pole.Find(1).temp2 = 0;
                _db.SaveChanges();
                _service.Check();
            }
            else
            {
                _db.Cards.Find(_db.Pole.Find(1).temp1).Revealed = false;
                _db.Cards.Find(_db.Pole.Find(1).temp2).Revealed = false;
                _db.Pole.Find(1).score = 0;
                _db.SaveChanges();
                _service.Check();
            }
        }
    }
}