using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pexeso.Models;

namespace Pexeso.Services
{
    public class Service : IService
    {
        public Service(ApplicationDbContext db) 
        {
            _db = db;
            Imgs = _db.Imgs.ToList();
            New_Game();
        }
        Random rng = new Random();
        private ApplicationDbContext _db { get; set; }
        public List<Card> Cards { get; set; }
        public List<Image> Imgs { get; set; }
        public void New_Game()
        {
            Cards = _db.Cards.ToList();
        }
        public void Increment()
        {
            _db.Pole.Find(1).score += 1;
            _db.SaveChanges();
        }
        public void Shuffle() 
        {
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
        public void Restart() 
        {
            foreach( Card c in Cards)
            {
                c.Revealed = false;
            }
        }
        public void Click(int j)
        {
            int temp = Cards[j].Id;
            _db.Cards.Find(temp).Revealed = true;
            _db.SaveChanges();
        }
        public bool Check() 
        {
            foreach(Card c in Cards)
            {
                if(c.Revealed == false)
                {
                   
                   return false;
                }
            }
            _db.Pole.Find(1).score = 3;
            _db.SaveChanges();
            return true;
        }
    }
}
