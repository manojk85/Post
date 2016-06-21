using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wPostEntities;
using wPostLayer.APIServices;

namespace wPostRepositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IAsyncPostAPICaller apiCaller;
        const string PostRelativeUrl = "posts";

        public PostRepository()
        {
            apiCaller = new PostAPICaller();
        }

        /// <summary>
        ///This method is used to get all posts
        /// </summary>
        public List<Post> GetAllPost()
        {
            List<Post> lstPost = new List<Post>();
            string response= apiCaller.Get(PostRelativeUrl).Result;
            if (!string.IsNullOrWhiteSpace(response))
            {     
                lstPost = ServiceStackSerializer.DeSerialize<List<Post>>(response);
            }
            return lstPost.OrderBy(c => c.id).ThenBy(x => x.title).ToList();
        }
        /// <summary>
        /// This method is used to get post by id
        /// </summary>
        public Post GetPostById(string id)
        {
            string url = string.Join("/",PostRelativeUrl, id);
            Post post = new Post();
            string response= apiCaller.Get(url).Result;
            if (!string.IsNullOrWhiteSpace(response))
            {
                post = ServiceStackSerializer.DeSerialize<Post>(response);
            }
            return post;
        }
    }
}
