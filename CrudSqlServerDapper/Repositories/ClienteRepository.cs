using CrudSqlServerDapper.Entities;
using CrudSqlServerDapper.Settings;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqlServerDapper.Repositories
{
    /// <summary>
    /// Repositório de dados para CRUD de clientes
    /// em um banco de dados do SqlServer
    /// </summary>
    public class ClientRepository
    {
        /// <summary>
        /// Atributo privado que contem uma referencia da classe AppSettings
        /// </summary>
        private AppSettings _appSettings = new AppSettings();

        /// <summary>
        /// Método para receber um registro de cliente
        /// e inserir os dados na tabela do banco sqlserver
        /// </summary>
        public void Insert(Client client)
        {
            //Escrevendo o comando SQL
            var query = @"
                    INSERT INTO CLIENT(ID, NAME, EMAIL, BIRTHDATE)
                    VALUES(@Id, @Name, @Email, @BirthDate)
                ";

            //Abrindo conexão com o banco de dados
            using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
                //Executando o comando SQL no banco de dados
                connection.Execute(query, client);
            }
        }
    }
}



