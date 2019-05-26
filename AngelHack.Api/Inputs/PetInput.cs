using AngelHack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngelHack.Api.Inputs
{
    public class PetInput
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Descricao { get; set; }
        public Endereco Endereco { get; set; }
        public string NomeTutor { get; set; }
        public bool Vacinado { get; set; }
        public bool Castrado { get; set; }
        public string Imagem { get; set; }
    }
}
