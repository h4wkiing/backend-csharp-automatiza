# Configurando Testes no .NET 7.0

# Pré-requisitos

Certifique-se de ter o SDK .NET 7.0 instalado. Você pode baixá-lo aqui.

# Etapas de Instalação

# 1. Restaurar Dependências

$bash

Copy code

dotnet restore

dotnet dev-certs https --trust

dotnet tool install --global dotnet-ef

# 2. Criar Banco de Dados MySQL

Crie um banco de dados no MySQL.

Edite sua string de conexão no arquivo appsettings.json:

# json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=automatizasistemas;user=root;password=pass;"
  }
}

# 3. Aplicar Migrações de Banco de Dados

$bash

dotnet ef database update

# 4. Executar a Aplicação

$bash

dotnet run --launch-profile https

Agora você pode acessar em https://localhost:{port}/swagger.




