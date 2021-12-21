using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProje.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Adını yazarsan sana hitap etmem kolaylaşır")]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sana e-mailin aracılığıyla ulaşabilirim")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Boş içerik göndermemelisin")]
        [Display(Name = "İçerik")]
        public string Content { get; set; }

        [Display(Name = "Okundu")]
        public bool isRead { get; set; }

        [Required]
        [Display(Name = "İleti Tarihi")]
        public DateTime DateOfComment { get; set; }
    }
}
