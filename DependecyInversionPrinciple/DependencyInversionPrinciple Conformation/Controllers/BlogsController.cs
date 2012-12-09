using System;
using System.Linq;
using System.Web.Http;
using DependencyInversionPrinciple_Conformation.Models;
using DependencyInversionPrinciple_Conformation.Services;

namespace DependencyInversionPrinciple_Conformation.Controllers
{

    public class BlogsController : ApiController
    {

        private readonly IBlogFetcher _blogs;

        //Poor man's IoC
        public BlogsController() : this(new BlogsFromMemory())
        {
           
        }

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
