using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateICA.Models
{
    public class Owner
    {
        [Key]
        public String OwnerNo { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Address { get; set; }
        public int TelNo { get; set; }
    }
}