using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pexeso.Models
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Pole> Pole { get; set; }
        public DbSet<Image> Imgs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Pole>().HasData(new Pole { Id = 1, score = 0, temp1 = 0, temp2 = 0 });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 1, Id_pair = 2, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 2, Id_pair = 1, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 3, Id_pair = 4, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 4, Id_pair = 3, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 5, Id_pair = 6, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 6, Id_pair = 5, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 7, Id_pair = 8, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 8, Id_pair = 7, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 9, Id_pair = 10, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 10, Id_pair = 9, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 11, Id_pair = 12, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 12, Id_pair = 11, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 13, Id_pair = 14, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 14, Id_pair = 13, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 15, Id_pair = 16, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Card>().HasData(new Card { Id = 16, Id_pair = 15, PoleId = 1, Revealed = false });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 1, src="~/images/1.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 2, src="~/images/2.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 3, src="~/images/3.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 4, src="~/images/4.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 5, src="~/images/5.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 6, src="~/images/6.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 7, src="~/images/7.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 8, src="~/images/8.jpg"});
            modelbuilder.Entity<Image>().HasData(new Image { Id = 9, src = "~/images/1.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 10, src = "~/images/2.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 11, src = "~/images/3.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 12, src = "~/images/4.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 13, src = "~/images/5.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 14, src = "~/images/6.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 15, src = "~/images/7.jpg" });
            modelbuilder.Entity<Image>().HasData(new Image { Id = 16, src = "~/images/8.jpg" });
        }
    }
}
