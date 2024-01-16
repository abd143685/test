using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gujjar.Shared
{
    public class Bills
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float subtotal { get; set; }
        [Required]
        public float tax { get; set; }
        [Required]
        public float total { get; set; }
    }
}
