using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


//[MetadataType(typeof(CommentMetaData))]
namespace ValidationExample.Models
{
    public class StudentMetaData
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string Email { get; set; }
    }
}