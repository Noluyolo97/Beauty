using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Beauty_Salon_N.Models
{
    public enum Gendera
    {
        Female, Male
    }
    public class Client
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string First_Name { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string Last_Name { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public Gendera gender { get; set; }
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }
        [Display(Name = "User Email")]
        [Required]
        public string User_Email { get; set; }
        [Display(Name = "Contacts")]
        [Required]
        public string Contacts { get; set; }

    
    }
}