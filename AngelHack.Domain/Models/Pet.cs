namespace AngelHack.Domain.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Descricao { get; set; }
        public Endereco Endereco { get; set; }
        public string NomeTutor { get; set; }
        public bool Vacinado { get; set; }
        public bool Castrado { get; set; }
        public bool Match { get; set; }
        public string Imagem { get; set; }


        public Pet(int id, string nome, int idade, string descricao, Endereco endereco, string nomeTutor, bool vacinado, bool castrado, bool match, string imagem)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Descricao = descricao;
            Endereco = endereco;
            NomeTutor = NomeTutor;
            Vacinado = vacinado;
            Castrado = castrado;
            Match = match;
            Imagem = imagem;
        }

        public Pet()
        {

        }

    }
}
