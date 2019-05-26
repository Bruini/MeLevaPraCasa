using AngelHack.Domain.Models;
using AngelHack.Repository.Configuration;
using AngelHack.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace AngelHack.Repository.Repos
{
    public class PetRepository : IPetRepository
    {
        public async Task<Pet> Inserir(Pet pet)
        {
            using (var connection = new SqlConnection(DbConnection.SQLConnectionString))
            {
                var petId = await connection.QuerySingleAsync<int>($"DECLARE @Id int; " +
                                                             $"INSERT INTO Pet (Nome, Idade, Descricao, NomeTutor, Vacinado, Castrado, Match, Imagem, Bairro, Cidade, Estado) " +
                                                             $"VALUES (@Nome, @Idade, @Descricao, @NomeTutor, @Vacinado, @Castrado, @Match, @Imagem, @Bairro, @Cidade, @Estado); " +
                                                             $"SET @Id = SCOPE_IDENTITY(); " +
                                                             $"SELECT @Id", new
                                                             {
                                                                 Nome = pet.Nome,
                                                                 Idade = pet.Idade,
                                                                 Descricao = pet.Descricao,
                                                                 NomeTutor = pet.NomeTutor,
                                                                 Vacinado = pet.Vacinado,
                                                                 Castrado = pet.Castrado,
                                                                 Match = pet.Match,
                                                                 Imagem = pet.Imagem,
                                                                 Bairro = pet.Endereco.Bairro,
                                                                 Cidade = pet.Endereco.Cidade,
                                                                 Estado = pet.Endereco.Estado
                                                             });

                return await SelecionarPorId(petId);
            }
        }

        public async Task<Pet> SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pet>> SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Pet> Update(int id, Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
