using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Web;
using DependencyInversionPrinciple_WithAnIocContainer.Models;

namespace DependencyInversionPrinciple_WithAnIocContainer.Services
{
    public class BlogsFromSqlServer : IBlogFetcher
    {
        public IQueryable<Blog> Fetch()
        {
            var blogs = new List<Blog>();

            //const string connectionString = @"Data Source = 'App_Data\TBlogs.sdf'"; Not working even though copied to bin
            const string connectionString = @"Data Source = 'C:\Projects\CSharp\Principles\DependecyInversionPrinciple\DependencyInversionPrinciple WithAnIocContainer\App_Data\TBlogs.sdf'";

            var connection = new SqlCeConnection(connectionString);
            var command = new SqlCeCommand("", connection);

            connection.Open();
            command.CommandText = "SELECT * FROM Blog;";

            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var blog = new Blog
                               {
                                   Author = dataReader["Author"].ToString(),
                                   Title = dataReader["Title"].ToString(),
                                   Url = dataReader["Url"].ToString(),
                                   Email = dataReader["Email"].ToString()
                               };

                blogs.Add(blog);
            }

            return blogs.AsQueryable();
        }
    }
}