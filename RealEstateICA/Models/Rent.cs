using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateICA.Models
{
    public class Rent
    {
        [Key]
        public String PropertyNo { get; set; }
    }
}