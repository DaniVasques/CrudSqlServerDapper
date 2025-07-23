using CrudSqlServerDapper.Entities;
using CrudSqlServerDapper.Repositories;
using CrudSqlServerDapper.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqlServerDapper.Controllers
{
    /// <summary>
    /// Classe de controle para realizar operações de gravação, edição,
    /// exclusão e consulta de clientes para o usuário do sistema.
    /// </summary>
    public class ClientController
    {
        /// <summary>
        /// Método para executar as operações do controlador
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("\nSISTEMA DE CONTROLE DE CLIENTES:\n");

            Console.WriteLine("(1) CADASTRAR CLIENTE");
            Console.WriteLine("(2) ATUALIZAR CLIENTE");
            Console.WriteLine("(3) EXCLUIR CLIENTE");
            Console.WriteLine("(4) PESQUISAR CLIENTES");

            Console.Write("\nINFORME A OPÇÃO DESEJADA...: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": //caso a opção seja "1"
                    CreateClient(); //executando o método para cadastrar cliente
                    break;

                default: //caso não seja nenhum dos anteriores
                    Console.WriteLine("\nOPÇÃO INVÁLIDA!");
                    break;
            }
        }

        /// <summary>
        /// Método para realizar o cadastro de um cliente
        /// </summary>
        private void CreateClient()
        {
            Console.WriteLine("\nCADASTRO DE CLIENTE:\n");

            //Criando um objeto da classe de entidade
            var client = new Client();

            Console.Write("INFORME O NOME...............: ");
            client.Name = Console.ReadLine() ?? string.Empty;

            Console.Write("INFORME O EMAIL..............: ");
            client.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("INFORME A DATA DE NASCIMENTO.: ");
            client.BirthDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            //Instanciando a classe de validação do cliente
            var validator = new ClientValidator();
            //Executar as validações no objeto e capturar o resultado
            var result = validator.Validate(client);

            //Verificar os dados do cliente passaram nas regras de validação
            if (result.IsValid)
            {
                //Criando um objeto da classe de repositório
                var clientRepository = new ClientRepository();
                clientRepository.Insert(client); //gravando o cliente

                Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO!");
            }
            else
            {
                Console.WriteLine("\nOCORRERAM ERROS DE VALIDAÇÃO!");
                foreach (var item in result.Errors)
                {
                    Console.WriteLine($"\tErro: {item.ErrorMessage}");
                }
            }
        }
    }
}



