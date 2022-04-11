using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Beauty_Salon_N.Models
{
    public class Service
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Service Name")]
        [Required]
        public string Service_Name { get; set; }
       
        [Display(Name = "Discription")]
        [Required]
        public string Discription { get; set; }
        
        [Display(Name = "Service Type and Price")]
        [Required]
        public string Service_Type_and_Price { get; set; }
        
    }
}