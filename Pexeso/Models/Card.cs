using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pexeso.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Id_pair { get; set; }

        [ForeignKey("PoleId")]
        public Pole Pole { get; set; }
        [Required]
        public int PoleId { get; set; }
        public bool Revealed { get; set; }
    }
}
