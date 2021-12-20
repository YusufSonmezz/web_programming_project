using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProje.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Başlık boş bırakılmamalı")]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama boş bırakılmamalı")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Resim")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Içerik boş bırakılmamalı")]
        [Display(Name = "İçerik")]
        public string Content { get; set; }

        [Required]
        public DateTime DateOfAdding { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
