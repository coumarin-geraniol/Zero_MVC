using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Zero.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [MaxLength(30)]
        public string Title { get; set; }


        public string Description { get; set; }


        [MaxLength(30)]
        public string ISBN { get; set; }


        [MaxLength(80)]
        public string Author { get; set; }


        [DisplayName("List Price")]
        [Range(1, 1000, ErrorMessage = "List Price must be between 1-1000")]
        public int ListPrice { get; set; }

        [DisplayName("Price for 1-50")]
        [Range(1, 1000, ErrorMessage = "List Price must be between 1-1000")]
        public int Price { get; set; }

        [DisplayName("Price for 50+")]
        [Range(1, 1000, ErrorMessage = "List Price must be between 1-1000")]
        public int Price50 { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }



        [ValidateNever]
        public string ImageUrl { get; set; }   
    }
}
