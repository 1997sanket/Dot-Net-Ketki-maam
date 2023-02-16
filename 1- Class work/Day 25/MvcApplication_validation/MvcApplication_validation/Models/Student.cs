using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication_validation.Models
{
    public class Student
    {   
        public int Id { get; set; }

       [DataType(DataType.Text)]
        public string Name { get; set; }

         [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DataType(DataType.Time)]
        public DateTime birthtime { get; set; }



        [DataType(DataType.MultilineText)]
        public string address { get; set; }

        [DataType(DataType.PostalCode)]
        public int  Postalcode { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile{get; set;}

        [DataType(DataType.Currency)]
        public float Fees { get; set; }

            [DataType(DataType.Upload)]
        public string Photo { get; set; }

            [DataType(DataType.EmailAddress)]
        public string  email { get; set; }
        [Compare("email")]
    public string ConfirmEmail { get; set; }
        
        [DataType( DataType.Url)]
          public string websitename { get; set; }


         [DataType(DataType.CreditCard)]
        public string creditcard { get; set; }


        [DataType(DataType.ImageUrl)]
        public string imageurl { get; set; }

        [DataType(DataType.Html)]

        public string hobbyhtml { get; set; }
    }
}