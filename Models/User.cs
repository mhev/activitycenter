using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 characters or longer!")]
        public string Name {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [RegularExpression("^(?=.*?[A-Za-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Must contain lowercase, upper, and special")]
        public string Password {get;set;}
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Party> PlannedPartys {get;set;}
        public List<Join> AttendingPartys {get;set;}
    }
}