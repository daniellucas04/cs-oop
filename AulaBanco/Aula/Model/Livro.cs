using System.ComponentModel.DataAnnotations;

namespace Aula.Model
{
    public class Livro
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Titulo { get; set; }
        
        public DateTime DataPublicacao { get; set; }
    }
}
