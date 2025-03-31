namespace Aula02 {
    class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno(22222222);
            Aluno aluno2 = new Aluno("daniel", new DateOnly(2004, 01, 10), 3333333);

            Livro livro = new Livro(123123);
            Livro livro2 = new Livro("Livro do ano", 2020, 44444444);

            if (livro.Retirar())
                Console.WriteLine($"O livro {livro.Titulo} foi retirado!");
            else
                Console.WriteLine($"Não foi possível retirar o livro {livro.Titulo}.");

            if (livro2.Devolver())
                Console.WriteLine($"O livro {livro2.Titulo} foi devolvido!");
            else
                Console.WriteLine($"Não foi possível devolver o livro {livro2.Titulo}.");
        }

        class Aluno
        {
            public int Prontuario { get; private set; }
            public string Nome { get; private set; }
            public DateOnly DataNascimento { get; private set; }

            public Aluno(int prontuario)
            {
                this.Prontuario = prontuario;
            }

            public Aluno(string nome, DateOnly dataNascimento, int prontuario)
            {
                this.Nome = nome;
                
                if (dataNascimento >= new DateOnly(1930, 12, 31))
                    this.DataNascimento = dataNascimento;
                
                this.Prontuario = prontuario; 
            }
        }

        class Livro
        {
            private bool locado = false;
            private bool disponivel = true;

            public int ISBN { get; set; }
            public string Titulo { get; set; }
            public int Ano {  get; set; }

            public Livro(int isbn)
            {
                this.ISBN = isbn;
            }

            public Livro(string titulo, int ano, int isbn)
            {
                this.Titulo = titulo;
                
                if (ano <= 2024)
                    this.Ano = ano;
                
                this.ISBN = isbn;
            }

            public bool Retirar()
            {
                if (this.disponivel)
                {
                    this.disponivel = false;
                    this.locado = true;
                    return true;
                }
                return false;
            }

            public bool Devolver()
            {
                if (this.locado)
                {
                    this.locado = false;
                    this.disponivel = true;
                    return true;
                }
                return false;
            }
        }
    }
}