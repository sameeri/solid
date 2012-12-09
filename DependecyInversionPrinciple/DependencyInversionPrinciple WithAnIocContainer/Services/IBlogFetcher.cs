using System.Linq;
using DependencyInversionPrinciple_WithAnIocContainer.Models;

namespace DependencyInversionPrinciple_WithAnIocContainer.Services
{
    public interface IBlogFetcher
    {
        IQueryable<Blog> Fetch();
    }
}