using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgProje.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebProgProje.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArticleApiController : ControllerBase
    {
        private readonly PaperContext paperContext;

        public ArticleApiController(PaperContext context)
        {
            paperContext = context;
        }

        // GET: api/<ArticleApiController>
        [HttpGet]
        public List<Article> Get()
        {
            return paperContext.Articles.ToList();
        }

        // GET api/<ArticleApiController>/5
        [HttpGet("{id}")]
        public Article Get(int id)
        {
            var the_article = paperContext.Articles.Where(article => article.ArticleId == id).FirstOrDefault();
            return the_article;
        }

        // POST api/<ArticleApiController>
        [HttpPost]
        public void Post([FromBody] Article article)
        {
            Article articleAdding = article;
            paperContext.Articles.Add(articleAdding);
            paperContext.SaveChanges();

        }

        // PUT api/<ArticleApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Article article)
        {
            Article theArticle = paperContext.Articles.Where(article => article.ArticleId == id).FirstOrDefault();

            theArticle.Comments = article.Comments;
            theArticle.Content = article.Content;
            theArticle.DateOfAdding = article.DateOfAdding;
            theArticle.Description = article.Description;
            theArticle.Image = article.Image;
            theArticle.Title = article.Title;

            paperContext.SaveChanges();
        }

        // DELETE api/<ArticleApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Article theArticle = paperContext.Articles.Where(article => article.ArticleId == id).FirstOrDefault();
            paperContext.Articles.Remove(theArticle);
            paperContext.SaveChanges();
        }
    }
}
