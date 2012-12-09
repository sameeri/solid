using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using DependencyInversionPrinciple_WithAnIocContainer.Controllers;
using DependencyInversionPrinciple_WithAnIocContainer.Services;

namespace DependencyInversionPrinciple_WithAnIocContainer.Containers
{
    // A simple implementation of IDependencyResolver, for example purposes.
    public class SimpleContainer : IDependencyResolver
    {
        static readonly IBlogFetcher BlogsFromMemory = new BlogsFromMemory();

        static readonly IBlogFetcher BlogsFromSqlServer = new BlogsFromSqlServer();

        public IDependencyScope BeginScope()
        {
            // This example does not support child scopes, so we simply return 'this'.
            return this;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(BlogsController))
            {
                //return new BlogsController(BlogsFromMemory);
                return new BlogsController(BlogsFromSqlServer);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {
            // When BeginScope returns 'this', the Dispose method must be a no-op.
        }
    }

    class OurContainer : IDependencyResolver
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }
    }
}