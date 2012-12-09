using System.Linq;
using DependencyInversionPrinciple_Conformation.Models;

namespace DependencyInversionPrinciple_Conformation.Services
{
    public interface IBlogFetcher
    {
        IQueryable<Blog> Fetch();
    }
}