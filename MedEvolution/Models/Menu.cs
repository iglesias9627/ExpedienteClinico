using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Menu
    {
        Menu()
        {
            SubMenus = new HashSet<Menu>();
        }

        [Key]
        private int codigoMenu { get; set; }

        private int? Men_codigoMenu { get; set; }

        [Required]
        [StringLength(15)]
        private string nombreMenu { get; set; }

        public virtual ICollection<Menu> SubMenus { get; set; }
    }
}