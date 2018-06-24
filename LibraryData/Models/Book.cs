using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Models
{
     public class Book : LibraryAsset
    {
        [Required]
        public int DeweyIndex { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        public string Publisher { get; set; }

        


    }
}
