using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
 
namespace armstrongkarate_.Models
{
    public class Customer
    {
        


        [Required]
        [Display(Name = "Customer must ID")]
        public int CustomerID { get; set; } 


        [Required]
        [Display(Name = "Your surname")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string SName { get; set; }



        [Required]
        [Display(Name = "Your firstname")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FName { get; set; }


    }
 }
