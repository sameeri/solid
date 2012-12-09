using System.Collections.Generic;
using System.Linq;
using DependencyInversionPrinciple_WithAnIocContainer.Models;

namespace DependencyInversionPrinciple_WithAnIocContainer.Services
{
    public class BlogsFromMemory : IBlogFetcher
    {
        public IQueryable<Blog> Fetch()
        {
            var blogs = new List<Blog>()
                            {
                                new Blog(){Author = "RayL", Email = "ray@t.com", Title = "Code it better", Url = "http://codebetter.com/raymondlewallen/"},
                                new Blog(){Author = "SauravP", Email = "saurav@t.com", Title = "Saurav's amazing blog", Url ="http://www.saurav.net"},
                                new Blog(){Author = "RupeshB", Email = "rupesh@t.com", Title = "Art of Technology", Url ="http://codewithme.com/myblog/"},
                                new Blog(){Author = "ChrisG", Email = "chris@t.com", Title = "MonkeysCanCodeToo", Url ="http://www.monkeys-code.net"},
                                new Blog(){Author = "KenF", Email = "kenf@t.com", Title = "Why PMs Rock!", Url = "http://kenf.net/"},
                                new Blog(){Author = "JoeH", Email = "joe@t.com", Title = "Constant Playoff Maker - How i do it", Url ="http://www.joeh.net"},
                                new Blog(){Author = "PaulH", Email = "paul@t.com", Title = "PM Zone", Url ="http://www.paulh.net"},
                                new Blog(){Author = "JordanM", Email = "jordan@t.com", Title = "Everyday PM Tasks", Url ="http://jordanm.net"},
                                new Blog(){Author = "RyanC", Email = "ryan@t.com", Title = "Web Demystified", Url ="http://www.ryanc.net"},
                            };
            return blogs.AsQueryable();
        }
    }
}