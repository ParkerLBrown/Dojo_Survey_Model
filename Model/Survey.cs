using System;
using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_Model.Models
{
    public class Survey
    {
        [Required (ErrorMessage = "This is required!")]
        [MinLength(3)]
        public string Name {get; set;}

        [Required]
        public string Location {get;set;}

        [Required]
        public string Language{get;set;}

        [MaxLength(20)]
        public string Comment{get;set;}
    }
}