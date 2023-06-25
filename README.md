# .NET-API

Esta é uma API em ASP.NET Core 7 com um sistema de login que utiliza autenticação JWT (JSON Web Token). Ela também inclui rotas que exigem autenticação para acesso.

<h3>Tecnologias Utilizadas</h3>
</br>
ASP.NET Core 7: A versão mais recente do framework web da Microsoft.
SQLite: Um banco de dados leve e de fácil configuração.
Entity Framework Core: Um ORM (Object-Relational Mapping) que simplifica o acesso e manipulação de dados do banco de dados.
Bcrypt: Um algoritmo de criptografia de senhas seguro e amplamente utilizado.
JWT (JSON Web Token): Um padrão para autenticação e autorização baseado em tokens.
</br>

<h3>Configuração do Ambiente</h3>
</br>
Antes de executar a API, certifique-se de ter as seguintes dependências instaladas:
</br>
.NET 7 SDK
</br>
Instalação e Execução
</br>
Siga as etapas abaixo para configurar e executar a API em sua máquina local:
</br>
Clone este repositório para sua máquina:
</br>
git clone https://github.com/Igorsaulo/.NET-API.git
</br>
Navegue até o diretório do projeto:
</br>
cd .NET-API
</br>

Restaure as dependências do projeto:
</br>
dotnet restore
</br>
Execute a migração do banco de dado:
</br>
dotnet ef migrations add NomeDaMigracao
</br>
Execute as migrações pendentes:
</br>
dotnet ef database update
</br>
Execute a aplicação:
</br>
dotnet run
</br>
<h3>Rotas da API</h3>
</br>
Acesse:
</br>
http://localhost:port//swagger/index.html
</br>
Para ver todas as rotas e esquemas da api.
