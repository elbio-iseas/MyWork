using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Marathon.Models
{
    public class Participant
    {
        public Participant()
        {
            this.PhoneNumber = "8012531600";
            this.ParticipantName = "";
            this.DateOfBirth = DateTime.Parse("01/01/1980");
            this.Address = "55 State st, Salt Lake City, UT 84111";
            this.Email = "username@domain.com";
            this.Gender = true;
        }

        [Required(ErrorMessage = "Enter Participant's Name please")]
        [StringLength(80)]
        public string ParticipantName { get; set; }

        [Required(ErrorMessage = "Enter your Phone Number please")]
        [RegularExpression("^[1-9][0-9]{9}", ErrorMessage = "Enter your Phone Number please")]      
        public string PhoneNumber { get; set; }
         
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Enter your Address please")]
        [StringLength(120)]
        public string Address { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter your e-mail address please")]
        [StringLength(60)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your gender please")]
        public bool? Gender { get; set; }

    }
}