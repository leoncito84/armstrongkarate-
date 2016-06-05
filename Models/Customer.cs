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
        [Display(Name = "Your Title")]
        [StringLength(4, ErrorMessage = "Your title must least 4")]
        public string Tle { get; set; }


        [Required]
        [Display(Name = "Your surname")]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters.")]
        public string SName { get; set; } 



        [Required]
        [Display(Name = "Your firstname")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FName { get; set; }
         

  
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]


        public DateTime EnrollmentDate { get; set; }


    }
 }
