using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProje.Models
{
    public class UserInfo : IdentityUser
    {
        [Required]
        [MinLength(3, ErrorMessage ="Minimum 3 karakter girilmelidir")]
        [Display(Name = "Ad")]
        public string UserFirstName { get; set; }

        [MinLength(3, ErrorMessage = "Minimum 3 karakter girilmelidir")]
        [Display(Name = "Soyad")]
        public string UserLastName { get; set; }
    }
}
