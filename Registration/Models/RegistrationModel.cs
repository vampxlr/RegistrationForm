using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class RegistrationModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string HearAbout { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string SkypeID { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public string Instituition { get; set; }
        [Required]
        public string FacebookURL { get; set; }
    }
}