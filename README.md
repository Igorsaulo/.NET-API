# .NET-API

Esta é uma API em ASP.NET Core 7 com um sistema de login que utiliza autenticação JWT (JSON Web Token). Ela também inclui rotas que exigem autenticação para acesso.

Tecnologias Utilizadas
ASP.NET Core 7: A versão mais recente do framework web da Microsoft.
SQLite: Um banco de dados leve e de fácil configuração.
Entity Framework Core: Um ORM (Object-Relational Mapping) que simplifica o acesso e manipulação de dados do banco de dados.
Bcrypt: Um algoritmo de criptografia de senhas seguro e amplamente utilizado.
JWT (JSON Web Token): Um padrão para autenticação e autorização baseado em tokens.

<h3>Configuração do Ambiente</h3>
Antes de executar a API, certifique-se de ter as seguintes dependências instaladas:

.NET 7 SDK
Instalação e Execução
Siga as etapas abaixo para configurar e executar a API em sua máquina local:

Clone este repositório para sua máquina:
git clone https://github.com/Igorsaulo/.NET-API.git

Navegue até o diretório do projeto:
cd .NET-API

Restaure as dependências do projeto:
dotnet restore

Execute a migração do banco de dado:
dotnet ef migrations add NomeDaMigracao

Execute as migrações pendentes:
dotnet ef database update

Execute a aplicação:
dotnet run

<h3>Rotas da API</h3>
Acesse:
http://localhost:port//swagger/index.html
Para ver todas as rotas e esquemas da api.
