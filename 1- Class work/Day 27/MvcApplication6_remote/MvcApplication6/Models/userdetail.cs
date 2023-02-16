using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class tbluser
    {
    }

    public class UserMetaData
    {
        [Required]
        [Remote("IsUserNameAvailable", "Home", ErrorMessage = "UserName already in use.")]
        public string UserName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}