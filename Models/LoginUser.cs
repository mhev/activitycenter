using System;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string LoginEmail {get;set;}
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string LoginPassword {get;set;}
    }
}