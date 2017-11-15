using Blogg.Models;
using System.Collections.Generic;

namespace Blogg.Repository
{
    public interface IBloggRepository
    {
        void Add(Post model);
        Post Get(string id);
        IEnumerable<Post> GetAll();
    }
}