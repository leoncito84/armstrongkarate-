using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace armstrongkarate_.Models
{
    public class Login
    {

        public int id { get; set; }
        //No need for requierd is datatype.


        [Required]
        [DataType(DataType.Password)]

        public string password { get; set; }


    }
}





