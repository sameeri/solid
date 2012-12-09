using System.Collections.Generic;
using System.Web.Http;
using DependecyInversionPrinciple.Models;
using DependecyInversionPrinciple.Services;

namespace DependecyInversionPrinciple.Controllers
{
    public class BlogsController : ApiController
    {
        public List<Blog> Get()
        {
            var dataSource = new BlogsFetcher(); //hard dependecy
            return dataSource.Fetch();
        }
    }
}
