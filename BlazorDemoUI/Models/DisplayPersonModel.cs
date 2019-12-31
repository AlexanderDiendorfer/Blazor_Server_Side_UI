using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long.")]
        [MinLength(2, ErrorMessage = "First Name is too short")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long.")]
        [MinLength(2, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
