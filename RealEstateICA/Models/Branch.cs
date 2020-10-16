using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateICA.Models
{
    public class Branch
    {
        [Key]
        public String BranchNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public int Postcode { get; set; }
    }
}