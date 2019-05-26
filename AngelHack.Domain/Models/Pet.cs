namespace AngelHack.Domain.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Descricao { get; set; }
        public string NomeTutor { get; set; }
        public bool Vacinado { get; set; }
        public bool Castrado { get; set; }
        public bool Match { get; set; }
        public string Imagem { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public Pet(string nome, int idade, string descricao, string nomeTutor, bool vacinado, bool castrado, bool match, string imagem, string bairro, string cidade, string estado)
        {
            Nome = nome;
            Idade = idade;
            Descricao = descricao;
            NomeTutor = nomeTutor;
            Vacinado = vacinado;
            Castrado = castrado;
            Match = match;
            Imagem = imagem;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Pet()
        {

        }

    }
}
