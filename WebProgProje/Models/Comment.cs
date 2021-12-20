using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProje.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "Içerik boş bırakılmamalı")]
        [Display(Name = "İçerik")]
        public string Content { get; set; }

        [Required]
        public DateTime DateOfCommenting { get; set; }

        public string UserName { get; set; }

        public int ArticleId { get; set; }

        public Article article { get; set; }
    }
}
