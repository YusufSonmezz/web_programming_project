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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticleApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticleApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticleApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
