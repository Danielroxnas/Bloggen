using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Blogg.Models;


namespace Blogg
{
    [Route("api/[action]")]
    public class BloggController : Controller
    {

        public BloggController(BloggingContext context)
        {
            _context = context;
        }

        private readonly BloggingContext _context;

        [HttpGet]
        [Route("{id}")]
        public string Posts(string id)
        {
            var post = new BloggPostService(_context).GetBloggPost(id);
            var json = JsonConvert.SerializeObject(post);

            return json;
        }

        [HttpGet]
        public string Posts()
        {
            var posts = new BloggPostService(_context).GetAllBloggPosts();
            var json = JsonConvert.SerializeObject(posts);

            return json;
        }

        [HttpPost]
        public void Posts_([FromBody] Post model)
        {
           new BloggPostService(_context).Save(model);

        }
    }
}
