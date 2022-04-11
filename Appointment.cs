using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Beauty_Salon_N.Models
{ 
    public enum Gender
            {
                Female, Male
            }

 public enum Service_Type
    {
        Hairstyle, Haircut, Handnails, Feetnails, Waxing, Body_Treatment, Massage, Makeup
    }

    public class Appointment

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
        public Gender Gender { get; set; }
        [Display(Name = "User Email")]
        [Required]
        public string User_Email { get; set; }
        [Display(Name = "Contacts")]
        [Required]
        public string Contacts { get; set; }
        [Display(Name = "Service Type")]
        [Required]
        public Service_Type Service_Type { get; set; }
        [Display(Name = "Date and Time")]
        [Required]
        public DateTime Date_and_Time { get; set; }



    }
}