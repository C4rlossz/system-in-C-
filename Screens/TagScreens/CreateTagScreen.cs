using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("============");
            Console.WriteLine("Nova tag");
            Console.WriteLine("============");

            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            
            Console.WriteLine("Slug: ");
            var Slug = Console.ReadLine();

            Create( new Tag {
                Name = name,
                Slug = Slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                
            var repository = new Repository<Tag>(Database.Connection);
            repository.Create(tag);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}