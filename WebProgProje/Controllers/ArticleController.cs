using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgProje.Data;
using WebProgProje.Models;

namespace WebProgProje.Controllers
{
    public class ArticleController : Controller
    {
        private readonly PaperContext paperContext;
        private readonly ApplicationDbContext AppContext;

        public ArticleController(PaperContext context, ApplicationDbContext context_2)
        {
            paperContext = context;
            AppContext = context_2;
        }

        public IActionResult Index()
        {
            List<Article> articles = paperContext.Articles.ToList();

            return View(articles);
        }

        
        public IActionResult Detail(int ?id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Article article = paperContext.Articles.Find(id);

            if(article == null)
            {
                return NotFound();
            }
            else
            {
                List<Article> articles = paperContext.Articles.Include(x => x.Comments).ToList();
                var comments = (from comment in paperContext.Comments
                               where comment.ArticleId == article.ArticleId
                               select comment).ToList();

                List < Comment > commentsAsViewData = new List<Comment>();
                if(comments != null)
                {
                    foreach(var comment in comments)
                    {
                        commentsAsViewData.Add(comment);
                    }
                    ViewData["comments"] = commentsAsViewData;
                }
            }

            return View(article);
        }

        [HttpPost]
        public IActionResult Comment(string Comment, int id)
        {
            Comment comment = new Comment();
            comment.ArticleId = id;
            comment.Content = Comment;
            comment.DateOfCommenting = DateTime.Now;
            string user_name = AppContext.Users.Where(user => user.Email == User.Identity.Name).Select(user => user.UserFirstName).FirstOrDefault();
            comment.UserName = user_name + "  (" + User.Identity.Name + ")";
            paperContext.Comments.Add(comment);
            paperContext.SaveChanges();

            List<Article> articles = paperContext.Articles.ToList();

            var the_article = from article in articles
                              where article.ArticleId == id
                              select article;
            foreach(var article in the_article)
            {
                article.Comments.Add(comment);
                paperContext.SaveChanges();
            }
            return RedirectToAction("");
        }
    }
}
