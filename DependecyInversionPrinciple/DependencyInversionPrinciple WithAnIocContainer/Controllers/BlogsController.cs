using System.Linq;
using System.Web.Http;
using DependencyInversionPrinciple_WithAnIocContainer.Models;
using DependencyInversionPrinciple_WithAnIocContainer.Services;

namespace DependencyInversionPrinciple_WithAnIocContainer.Controllers
{

    public class BlogsController : ApiController
    {

        private readonly IBlogFetcher _blogs;

        public BlogsController(IBlogFetcher blogs)
        {
            _blogs = blogs;
        }

        public IQueryable<Blog> GetBlogs()
        {
            return _blogs.Fetch();
        }
    }
}
