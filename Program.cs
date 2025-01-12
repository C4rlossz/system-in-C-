using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
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
            Database.Connection = new SqlConnection(CONNECTION_STING);
            Database.Connection.Open();
        
            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
             Console.Clear();
             Console.WriteLine("Meu Blog");
             Console.WriteLine("====================");
             Console.WriteLine("O que deseja fazer?");
             Console.WriteLine("====================");
             Console.WriteLine();
             Console.WriteLine("1 - Gestao de usuario");
             Console.WriteLine("2 - Gestao de perfil");
             Console.WriteLine("3 - Gestao de categoria");
             Console.WriteLine("4 - Gestao de Tag");
             Console.WriteLine("5 - Vincular perfil/usuario");
             Console.WriteLine("6 - Vincular post/tag");
             Console.WriteLine("7 - Relatorios");
             Console.WriteLine();
             Console.WriteLine();
             var option = short.Parse(Console.ReadLine()!);

             switch (option)
             {

                case 1:
                    MenuUserScreen.Load();
                    break;

                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;

             }
             
        }
    }
}