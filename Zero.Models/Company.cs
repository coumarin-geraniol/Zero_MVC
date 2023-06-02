using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string Name { get; set; }

        [DisplayName("Street Address")]
        public string? StreetAddress { get; set; }
        public string? State { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }
    }
}
