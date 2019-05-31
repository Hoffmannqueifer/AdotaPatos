﻿using AdotaPatos.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdotaPatos.DAO
{
    public class AnimalDAO : DAO
    {
        public void Salvar(Animal animal)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"insert into animal (AnimalId, NomeAnimal, TipoAnimal, NomeVoluntario, LarTemporario, DataResgate, Sexo, Raca, Idade, TipoCastrado, ImagemAntes, ImagemDepois, Descricao)values(@AnimalId, @NomeAnimal, @TipoAnimal, @NomeVoluntario, @LarTemporario, @DataResgate, @Sexo, @Raca, @Idade, @TipoCastrado, @ImagemAntes, @ImagemDepois, @Descricao)";
                sqlConnection.Execute(query, animal);
            }
        }

        public IEnumerable<Animal> Listar()
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                return sqlConnection.Query<Animal>(@"select TipoAnimal, NomeAnimal, NomeVoluntario, DataResgate from animal");
            }
        }

        public Animal PorId(long AnimalId)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                return sqlConnection.Query<Animal>(@"select AnimalId, NomeAnimal, TipoAnimal, NomeVoluntario, LarTemporario, DataResgate, Sexo, Raca, Idade, TipoCastrado, ImagemAntes, ImagemDepois, Descricao from animal where Id = @AnimalId", new { Id = AnimalId }).First();
            }
        }

        public void Delete(long? AniimalId)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"delete from animal where Id = @AniimalId";
                sqlConnection.Execute(query, new { Id = AniimalId });
            }
        }

        public void Atualizar( Animal animal)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"update voluntario set AnimalId = @AnimalId, NomeAnimal = @NomeAnimal, TipoAnimal = @TipoAnimal, NomeVoluntario = @NomeVoluntario, LarTemporario = @LarTemporario, DataResgate = @DataResgate, Sexo = @sexo, Raca = @Raca, Idade = @Idade, TipoCastrado = @TipoCastrado, ImagemAntes = @ImagemAntes, ImagemDepois =  @ImagemDepois, Descricao = @Descricao  where Id = @AnimalId";
                sqlConnection.Execute(query, animal);
            }
        }
    }
}