using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddApp_447.Classes.Entityes
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(64)]
        public string FirstName { get; set;}
        [Required, MaxLength(64)]
        public string LastName { get; set; }
        [MaxLength(64)]
        public string SerName { get; set; }
        [Required, MaxLength(32), Index(IsUnique = true)]
        public string Login { get; set; }
        [Required, MaxLength(32)]
        public string Pass { get; set; }
        public virtual List<Sell> Sells { get; set; }
        public User() {
            Sells = new List<Sell>();
        }

    }
}
