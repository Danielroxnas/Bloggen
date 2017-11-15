using Blogg.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blogg
{
    public class BloggPostService
    {
        public BloggPostService(BloggingContext context)
        {
            _context = context;
        }

        public readonly BloggingContext _context;

        public IEnumerable<Models.Post> GetAllBloggPosts()
        {
            return new Repository.BloggRepository(_context).GetAll();

        }

        public Models.Post GetBloggPost(string id)
        {
            return new Repository.BloggRepository(_context).Get(id);

        }

        public void Save(Models.Post model)
        {
            new Repository.BloggRepository(_context).Add(model);
        }

    }
}