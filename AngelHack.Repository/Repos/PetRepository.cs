using AngelHack.Domain.Models;
using AngelHack.Repository.Configuration;
using AngelHack.Repository.Interfaces;
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
                                                                 Bairro = pet.Bairro,
                                                                 Cidade = pet.Cidade,
                                                                 Estado = pet.Estado
                                                             });

                return await SelecionarPorId(petId);
            }
        }

        public async Task<Pet> SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnection.SQLConnectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Pet>($"SELECT Id, Nome, Idade, Descricao, NomeTutor, " +
                                                                      $"Vacinado, Castrado, Match, Imagem, Bairro, Cidade, Estado " +
                                                                      $"FROM Pet WHERE Id = @Id", new
                                                                      {
                                                                          Id = id
                                                                      });
            }
        }

        public async Task<IEnumerable<Pet>> SelecionarTodosAsync()
        {
            using (var connection = new SqlConnection(DbConnection.SQLConnectionString))
            {
                return await connection.QueryAsync<Pet>($"SELECT Id, Nome, Idade, Descricao, NomeTutor, " +
                                                        $"Vacinado, Castrado, Match, Imagem, Bairro, Cidade, Estado " +
                                                        $"FROM Pet");
            }
        }

        public async Task Update(int id, Pet pet)
        {
            using (var connection = new SqlConnection(DbConnection.SQLConnectionString))
            {
                await connection.ExecuteAsync($"UPDATE Pet " +
                                                          $"SET Nome = @Nome, Idade = @Idade, Descricao = @Descricao, NomeTutor = @NomeTutor, " +
                                                          $"Vacinado = @Vacinado, Castrado = @Castrado, Match = @Match, Imagem = @Imagem, Bairro = @Bairro, " +
                                                          $"Cidade = @Cidade, Estado = @Estado " +
                                                          $"WHERE Id = @Id" , new
                                                          {
                                                              Nome = pet.Nome,
                                                              Idade = pet.Idade,
                                                              Descricao = pet.Descricao,
                                                              NomeTutor = pet.NomeTutor,
                                                              Vacinado = pet.Vacinado,
                                                              Castrado = pet.Castrado,
                                                              Match = pet.Match,
                                                              Imagem = pet.Imagem,
                                                              Bairro = pet.Bairro,
                                                              Cidade = pet.Cidade,
                                                              Estado = pet.Estado,
                                                              Id = pet.Id
                                                          });
            }
        }
    }
}
