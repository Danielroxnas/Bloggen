using Blogg.Models;
using System.Collections.Generic;

namespace Blogg.Repository
{
    public interface IBloggRepository
    {
        void Add(PostModel model);
        PostModel Get(string id);
        IEnumerable<PostModel> GetAll();
    }
}