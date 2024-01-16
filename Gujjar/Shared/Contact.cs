using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gujjar.Shared
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Too Long", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Out of Limits", MinimumLength = 50)]
        public string Message { get; set; }
    }
}
