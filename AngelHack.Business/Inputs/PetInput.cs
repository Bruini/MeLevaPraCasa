using AngelHack.Domain.Models;

namespace AngelHack.Business.Inputs
{
    public class PetInput
    {
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
    }
}
