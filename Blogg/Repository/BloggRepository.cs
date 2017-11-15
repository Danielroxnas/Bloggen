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

        public Post Get(string id)
        {
            var blogg = new Post();
            using (var db = _context)
            {

                blogg = (from b in db.Post
                         where b.BlogId == int.Parse(id)
                           select b).First();
            }
            return blogg;
        }

        public IEnumerable<Post> GetAll()
        {
            var blogg = new List<Post>();
            blogg = _context.Post.ToList();
            return blogg;
        }

        public void Add(Post model)
        {
            using (var db = _context)
            {
                db.Post.Add(model);
                db.SaveChanges();
            }

        }

    }
}
