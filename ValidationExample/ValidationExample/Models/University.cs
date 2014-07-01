using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationExample.Models
{
    public class University
    {
        public int Id { get; set; }
        [Required (ErrorMessage="This must be a University Name")]
        [Display(Name="University Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(5)]
        public string  Location { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}