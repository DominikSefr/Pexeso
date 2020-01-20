using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pexeso.Models
{
    public class Pole
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int score { get; set; }
        [Required]
        public int temp1 { get; set; }
        [Required]
        public int temp2 { get; set; }
        public ICollection<Card> CardList { get; set; }
    }
}
