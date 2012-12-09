using System.Collections.Generic;
using System.Linq;
using DependencyInversionPrinciple_Conformation.Models;

namespace DependencyInversionPrinciple_Conformation.Services
{
    public class BlogsFromMemory : IBlogFetcher
    {
        public IQueryable<Blog> Fetch()
        {
            var blogs = new List<Blog>()
                            {
                                new Blog(){Author = "Ray", Email = "ray@t.com", Title = "Code it better", Url = "http://codebetter.com/raymondlewallen/"},
                                new Blog(){Author = "Saurav", Email = "saurav@t.com", Title = "Saurav's amazing blog", Url ="http://www.saurav.net"},
                                new Blog(){Author = "Rupesh", Email = "rupesh@t.com", Title = "Art of Technology", Url ="http://codewithme.com/myblog/"},
                                new Blog(){Author = "Chris", Email = "chris@t.com", Title = "MonkeysCanCodeToo", Url ="http://www.monkeys-code.net"}
                            };
            return blogs.AsQueryable();
        }
    }
}