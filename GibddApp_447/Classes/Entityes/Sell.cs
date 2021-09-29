using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddApp_447.Classes.Entityes
{
    /// <summary>
    /// Продажа
    /// </summary>
    public class Sell
    {
        [Key]
        public int SellId { get; set; }
        [Required]
        public DateTime SellDateTime { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User user { get; set; }
        public virtual List<Tovar> Tovars { get; set; }

        public Sell() {
            Tovars = new List<Tovar>();
        }
    }
}
