# CrudSqlServerDapper

Projeto desenvolvido em **C# com .NET 9** para simular um **sistema de cadastro de clientes em console**, com persistência em **SQL Server** utilizando **Dapper** e validações com **FluentValidation**.

O objetivo deste projeto é praticar conceitos de CRUD, organização de código em camadas simples, validação de dados e integração com banco de dados relacional.

---

## Sobre o projeto

O **CrudSqlServerDapper** foi criado como projeto de estudo prático para reforçar conhecimentos em:

- C#
- .NET 9
- Dapper
- SQL Server
- FluentValidation
- Programação Orientada a Objetos
- Organização em pastas
- Validação de dados
- Persistência em banco de dados

A aplicação foi organizada com divisão simples e didática em:

- **Controllers** → responsável pelo fluxo da aplicação
- **Entities** → responsável pela entidade de cliente
- **Repositories** → responsável pelo acesso a dados
- **Settings** → responsável pela configuração da conexão
- **Validations** → responsável pela validação dos dados

---

## Funcionalidades atuais

- Exibição de menu principal no console
- Cadastro de cliente
- Leitura de dados informados pelo usuário
- Validação de nome, e-mail e data de nascimento
- Inserção de cliente no banco de dados com Dapper
- Estrutura preparada para evolução do CRUD

---

## Estrutura do projeto

```bash
CrudSqlServerDapper/
├── Controllers/
│   └── ClientController.cs
├── Entities/
│   └── Client.cs
├── Repositories/
│   └── ClienteRepository.cs
├── Settings/
│   └── AppSettings.cs
├── Validations/
│   └── ClientValidator.cs
├── Program.cs
└── CrudSqlServerDapper.csproj
