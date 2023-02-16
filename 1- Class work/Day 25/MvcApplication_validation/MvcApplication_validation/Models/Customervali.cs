using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication_validation.Models
{
     
      [MetadataType(typeof(CustomerMetaData))]
      public partial class Customer
      {
      }

      public class CustomerMetaData
      {
          //If you want "FullName" to be displayed as "Full Name", 
          //use DisplayAttribute or DisplayName attribute.
          //DisplayName attribute is in System.ComponentModel namespace.


          public int Id { get; set; }
          [DisplayName]
          [Required]
           [Display(Name="First Name")]
           [StringLength(10, MinimumLength = 3)]
          public string FName { get; set; }

          [Required]
          [Display(Name="Gender")]
          public string Gender { get; set; }

          [DataType(DataType.Password)]
          public string Password { get; set; }

          [Required(ErrorMessage ="Mobile Number Required")]
          [RegularExpression(@"[0-9]{10}",ErrorMessage ="10 Digit Mobile Number")]
          public string MobileNo { get; set; }

           [Required(ErrorMessage = "Email is  Required")]
          [DataType(DataType.EmailAddress)]
          public string EmailId { get; set; }

           [Required (ErrorMessage ="Address is Required")]
          public string Address { get; set; }

           [Required (ErrorMessage ="Image path")]
          public string Photos { get; set; }

          [Required (ErrorMessage="Age is required" )]
          [Range(12, 99, ErrorMessage = "Age must be between 12 and 99")]
           public short Age { get; set; }

          [DataType (DataType.Url)]
           public string URL { get; set; }

        
      }
}