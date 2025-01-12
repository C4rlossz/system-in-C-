using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("============");
            Console.WriteLine("Atualizando uma Tag");
            Console.WriteLine("============");
            Console.WriteLine("Id: ");

            var id = Console.ReadLine();

            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            
            Console.WriteLine("Slug: ");
            var Slug = Console.ReadLine();

            Update( new Tag {

                Id = int.Parse(id),
                Name = name,
                Slug = Slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();

        }

        public static void Update(Tag tag)
        {
            try
            {
                
            var repository = new Repository<Tag>(Database.Connection);
            repository.Update(tag);
            Console.WriteLine("Tag Atualizada com sucesso!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi Atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }

    }
}