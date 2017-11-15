using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogg.Models;

namespace Blogg.Repository
{
    public class BloggRepository : DbContext, IBloggRepository
    {

        public readonly BloggingContext _context;

        public BloggRepository(BloggingContext context)
        {
            _context = context;
        }

        public PostModel Get(string id)
        {
            var blogg = new PostModel();
            using (var db = _context)
            {

                blogg = (from b in db.Post
                         where b.BlogId == int.Parse(id)
                           select b).First();
            }
            return blogg;
        }

        public IEnumerable<PostModel> GetAll()
        {
            var blogg = new List<PostModel>();
            blogg = _context.Post.ToList();
            return blogg;
        }

        public void Add(PostModel model)
        {
            using (var db = _context)
            {
                db.Post.Add(model);
                db.SaveChanges();
            }

        }

    }
}
