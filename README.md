# Implementação de Arquitetura Limpa com ASP.NET Core 7

## Descrição

Este repositório contém um projeto de demonstração que ilustra a implementação da Clean Architecture (Arquitetura Limpa) com o padrão CQRS(command query responsibility segregation)e a biblioteca MediatR utilizando o framework ASP.NET Core 7. A Clean Architecture é uma abordagem de design de software que promove a separação de responsabilidades e facilita a manutenção, teste e evolução de sistemas complexos.

## Objetivo

O objetivo deste projeto é fornecer um exemplo claro e bem-estruturado de como aplicar os princípios da Clean Architecture em uma aplicação ASP.NET Core 7. 

## Estrutura do Projeto
```bash
CleanArchi/
├── Core
│     ├─ Application
│     │    ├── Services/
│     │    ├── Shared/
│     │    └── UseCases/
│     │
├     └─ Domain
│          ├── Entities/
│          └── Interfaces/
│
├── Infrastructure/
│   └── CleanArchit.Persistance
│              ├── Context/
│              ├── Repositories/
│              └── ServiceExtensions
│
└── Presentation/
    └── CleanArchit.API
               ├── Controllers/
               ├── Extensions/
               └── Program

 ```

## Tecnologias Utilizadas

- Visual Studio 2022
- ASP.NET Core 7
- SQL Lite + DB Browser for SQlite
- Swagger

## Instalação e Configuração

1. Clone o repositório:
    ```bash
    git clone https://github.com/Wendel09Manfrs/CleanArchitectureAspNetCore7.git
    ```

2. Navegue até o diretório do projeto na pasta CleanArchit.MVC com o Visual Studio Code:
    ```bash
    cd CleanArchitectureAspNetCore5
    ```
    Já dentro do diretório do projeto, navegue até a pasta MVC usando:
      ```bash
    cd CleanArchi.MVC
    ```

3. Restaure as dependências(opcional):
    ```bash
    dotnet restore
    ```

4. Configure a string de conexão no arquivo `appsettings.json` para apontar para o seu banco de dados SQLITE do seu ambiente.

5. Execute as migrações do Entity Framework Core para configurar o banco de dados(opcional):
    ```bash
    dotnet ef database update
    ```

6. Execute a aplicação:
    ```bash
    dotnet run
    ```

