using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
 





namespace armstrongkarate_.Models
{
    public class product
    {

        public int ProductID { get; set; }
        //No add for required and display of ID


        [Required]
        [Display(Name = "Product Name")]
        public string pName { get; set; }

        [Required]
        [Display(Name = "Descrition Name")]
        public string Descrition { get; set; }

        [Required]
        [Display(Name = "Quantity Name")]
        public string Quantity { get; set; }

        [Required]
        [Display(Name = "Price")]
        public string price { get; set; }



    }
}
