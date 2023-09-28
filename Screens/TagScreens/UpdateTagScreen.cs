using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar tag");
            Console.WriteLine("------------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine()!);

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Validate(id, name);

            Update(new Tag { Id = id, Name = name, Slug = slug });

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Validate(int id, string name)
        {
            if (id < 0)
            {
                throw new Exception("Id inválido");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Nome é obrigatório");
            }
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
