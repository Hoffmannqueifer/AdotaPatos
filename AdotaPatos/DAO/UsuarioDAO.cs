using AdotaPatos.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdotaPatos.DAO {
    public class UsuarioDAO : DAO {

        public void Salvar(Usuario usuario) {
            using (var sqlConnection = GetMySqlConnection()) {
                var query = @"insert into usuario (Id, Login, Cargo, Senha)values(@Id, @Login, @Cargo, @Senha)";
                sqlConnection.Execute(query, usuario);
            }
        }

        public IEnumerable<Usuario> Listar() {
            using (var sqlConnection = GetMySqlConnection()) {
                return sqlConnection.Query<Usuario>(@"select Id, Login, Cargo, Senha from usuario");
            }
        }

        public Usuario PorId(long id) {
            using (var sqlConnection = GetMySqlConnection()) {
                return sqlConnection.Query<Usuario>(@"select Id, Login, Cargo, Senha from usuario where Id = @id", new { Id = id }).First();
            }
        }

        public void Delete(long? id) {
            using (var sqlConnection = GetMySqlConnection()) {
                var query = @"delete from usuario where Id = @id";
                sqlConnection.Execute(query, new { Id = id });
            }
        }

        public void Atualizar(Usuario usuario) {
            using (var sqlConnection = GetMySqlConnection()) {
                var query = @"update usuario set Login = @Login, Cargo = @Cargo, Senha = @Senha  where Id = @Id";
                sqlConnection.Execute(query, usuario);
            }
        }
    }
}