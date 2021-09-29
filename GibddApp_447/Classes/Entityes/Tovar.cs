using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddApp_447.Classes.Entityes
{
    public class Tovar
    {
        [Key]
        public int TovarId { get; set; }
        [Required, MaxLength(64)]
        public string TovarName { get; set; }
        [Required]
        public decimal TovarPrice { get; set; }
        public virtual List<Sell> Sells { get; set; }

        public Tovar() {
            Sells = new List<Sell>();
        }
    }
}
