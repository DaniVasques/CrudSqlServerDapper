using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqlServerDapper.Settings
{
    /// <summary>
    /// Classe para mapear configurações
    /// globais do projeto.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Propriedade somente leitura para retornar
        /// o valor da connectionstring do banco de dados
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBClient;Integrated Security=True;";
            }
        }
    }
}



