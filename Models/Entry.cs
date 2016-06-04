using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;using System.Data.Entity.ModelConfiguration.Conventions;

namespace armstrongkarate_.Models
{
    public class Entry
    {

        [Required]
        [Display(Name = "Customer must ID")]
        public int CustomerID { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Your Surname please")]
        [StringLength(50, ErrorMessage = "Name must be under 50 characters.")]

        public string SName { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Your First Name please")]
        [StringLength(50, ErrorMessage = "Name must be under 50 characters.")]
        public string FName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address (For Admin only)")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$", ErrorMessage = "Email does not appear to be valid format.")]
        [StringLength(256, ErrorMessage = "Email Address Length too long.")]
        public virtual string Email { get; set; }


        [Required]
        [DataType(DataType.Html)]
        [Display(Name = "Get your comment")]
        [StringLength(255, ErrorMessage = "Comment must be under 255 characters.")]
        public string Comment { get; set; }

        public virtual  DateTime Date { get; set; }
    }
}