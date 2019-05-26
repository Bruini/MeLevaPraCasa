namespace AngelHack.Domain.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Descricao { get; set; }
        public Endereco Endereco { get; set; }
        public bool Vacinado { get; set; }
        public bool Castrado { get; set; }
        public string Imagem { get; set; }

    }
}
