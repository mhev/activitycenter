using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class Party
    {
        [Key]
        public int PartyId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        public TimeSpan Time {get;set;}
        [Required]
        public DateTime Date {get;set;}
        [Required]
        public int Duration {get;set;}
        [Required]
        public string Type {get;set;}
        [Required]
        [MinLength(5, ErrorMessage = "Description must be at least 5 characters long")]
        public string Description {get;set;}
        public int PlannerId {get;set;}
        public User Planner {get;set;}
        public List<Join> AttendingUsers {get;set;}
        public void Display()
        {
            Console.WriteLine($"{Title} {Date} {Duration} {Description} ");
        }
    }
}