using System;
using Blog.Models;
using Blog.Repositories;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;



namespace Blog
{

    class Program
    {

        private const string CONNECTION_STING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STING);
            connection.Open();

            ReadUsers(connection);
            CreateUsers(connection);
            //ReadRoles(connection);
            //ReadTags(connection);


            connection.Close();
        }
        
        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach (var item in items)
            {

            Console.WriteLine(item.Name);
            foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }


        public static void CreateUsers(SqlConnection connection)
        {
            var user = new User()
            {
                Email = "email@carlos.io",
                Bio = "bio",
                Image = "Imagem",
                Name = "Name",
                PasswordHash = "Hash",
                Slug = "slug"
            };
            var repository = new Repository<User>(connection);
        }


        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);

        }
        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);

        }

    }
}