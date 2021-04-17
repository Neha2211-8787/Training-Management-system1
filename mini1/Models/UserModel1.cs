using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mini1.Models
{
    public class UserModel1
    {
        [Display(Name ="User Id: ")]
        public string UserId { get; set; }


        [Required(ErrorMessage = "FirstName is required")]
        [Display(Name = "First Name: ")]
        [StringLength(20, MinimumLength = 4)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName is required")]
        [Display(Name = "Last Name: ")]
        [StringLength(20, MinimumLength = 4)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender: ")]
        public string Gender { get; set; }



        [Required(ErrorMessage = "DOB is required")]
        [DataType(DataType.Date)]
        [Display(Name = "DOB: ")]
        public string DOB { get; set; }



        //[Required(ErrorMessage = "Contact Number is required")]
        // [RegularExpression(@"^([0-9]{10})$")]
        // [DataType(DataType.PhoneNumber)]
       
        //[Display(Name = "Contact Number: ")]
        //public int Contact_Number { get; set; }



        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password: ")]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address: ")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }



    }
}