using System.Collections.Generic;
using DependecyInversionPrinciple.Models;

namespace DependecyInversionPrinciple.Services
{
    public class BlogsFetcher
    {
        public List<Blog> Fetch()
        {
            return new List<Blog>()
                       {
                           new Blog(){Author = "Ray", Email = "ray@t.com", Title = "Code better", Url = "http://codebetter.com/raymondlewallen/"},
                           new Blog(){Author = "Saurav", Email = "saurav@t.com", Title = "Saurav's amazing blog", Url ="http://www.saurav.net"},
                           new Blog(){Author = "Rupesh", Email = "rupesh@t.com", Title = "Art of Technology", Url ="http://codewithme.com/myblog/"},
                       };
        }
    }
}