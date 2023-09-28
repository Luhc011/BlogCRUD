﻿using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("------------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            //Validate(name);

            Create(new Tag { Name = name, Slug = slug });

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Validate(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Nome é obrigatório");
            }
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
