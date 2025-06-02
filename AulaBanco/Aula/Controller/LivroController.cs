using Aula.Data;
using Aula.Model;

namespace Aula.Controller
{
    public class LivroController
    {
        public static void Salvar(Livro item)
        {
            using DataContext context = new DataContext();

            context.Livros.Add(item);
            context.SaveChanges();
        }

        public static List<Livro> Listar()
        {
            using DataContext context = new DataContext();
            return context.Livros.ToList();
        }

        public static List<Livro> PesquisarPorTitulo(string titulo)
        {
            using DataContext context = new DataContext();
            return context.Livros.Where(livro => livro.Titulo.Contains(titulo)).OrderBy(livro => livro.Titulo).ToList();
        }

        public static void Excluir(Livro livro)
        {
            using DataContext context = new DataContext();
            context.Livros.Remove(livro);
            context.SaveChanges();
        }

        public static Livro Obter(Livro livro)
        {
            using DataContext context = new DataContext();
            return context.Livros.Find(livro.Id);
        }

        public static void Atualizar(Livro livro)
        {
            using DataContext context = new DataContext();
            bool existe = context.Livros.Any(p => p.Id == livro.Id);

            if (existe != null)
            {
                context.Livros.Update(livro);
                context.SaveChanges();
            }
        }
    }
}
