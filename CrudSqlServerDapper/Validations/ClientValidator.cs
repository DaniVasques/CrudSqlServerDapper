using CrudSqlServerDapper.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqlServerDapper.Validators
{
    /// <summary>
    /// Classe para validação de dados da entidade Cliente
    /// </summary>
    public class ClientValidator : AbstractValidator<Client>
    {
        //Método construtor
        public ClientValidator()
        {
            //Validação do campo 'Name'
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Por favor, preencha o nome do cliente.")
                .MinimumLength(6).WithMessage("Por favor, informe o nome do cliente com pelo menos 6 caracteres.");

            //Validação do campo 'Email'
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor, preencha o email do cliente.")
                .EmailAddress().WithMessage("Por favor, informe um endereço de email válido.");

            //Validação do campo 'Birthdate'
            RuleFor(c => c.BirthDate)
                .LessThan(DateTime.Today).WithMessage("Por favr, informe a data de nascimento menor do que a data atual.");
        }
    }
}



