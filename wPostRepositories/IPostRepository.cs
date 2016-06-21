using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wPostEntities;

namespace wPostRepositories
{
    public interface IPostRepository
    {
        List<Post> GetAllPost();
        Post GetPostById(string id);
    }
}
