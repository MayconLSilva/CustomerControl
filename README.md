# Customer Control

API Para cadastro de cliente e seus respectivos e-mails e contatos. Construido para fins de testes e práticas de algumas técnologias.
## Técnologias utilizadas:
* Net.7.0
* PostgreSQL
* pgAdmin 4
* Docker

## Pré-requisitos
Certifique-se de ter as seguintes ferramentas e/ou técnologias instaladas em sua máquina:
* [Docker Desktop](https://desktop.docker.com/win/main/amd64/Docker%20Desktop%20Installer.exe?_gl=1*msh36l*_ga*MTQ0Mzc3NjU2Ny4xNjI1MzMzMjE5*_ga_XJWPQMJYHQ*MTY4NzM2NTc2Ni43LjEuMTY4NzM2NTc2Ni42MC4wLjA.)
* [.NET 7 SDK](https://download.visualstudio.microsoft.com/download/pr/2ab1aa68-3e14-401a-b106-833d66fa992b/060457e640f4095acf4723c4593314b6/dotnet-sdk-7.0.304-win-x64.exe)

## NuGets necessários
* Microsoft.AspNetCore.OpenApi
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.Tools
* Npgsql.EntityFrameworkCore.PostgreSQL
* NuGet.CommandLine
* Swashbuckle.AspNetCore

## Como executar o projeto localmente
1. Clone este repositório para sua máquina local:
> https://github.com/MayconLSilva/CustomerControl.git
2. Navegue até o diretório do projeto:
> cd seu-repositorio
3. Execute o projeto usando o comando dotnet:
> dotnet run
4. Abra seu navegador e acesse a URL para visualizar a aplicação.
> https://localhost:suaPorta

![image](https://github.com/MayconLSilva/CustomerControl/assets/24304710/40c4cfeb-ccc3-4b4c-a632-d5f30c8a98e4)
5. No arquivo appsettings.json do seu projeto, comente a linha de conexão do container e configure a linha de conexão para o seu banco de dados.
OBS: É necessário ter o PostgreSQL instalado seja ele container ou banco de dados padrão instalado em sua máquina.
![image](https://github.com/MayconLSilva/CustomerControl/assets/24304710/89c029ca-e1d9-448d-97ae-6827227ef8af)
6. Migration
> dotnet-ef

> dotnet tool install --global dotnet-ef | se estiver intalado desinstale e instale novamente: dotnet tool uninstall --global dotnet-ef

> dotnet ef migrations add Initial 

> dotnet ef database update

## Como executar o projeto tudo via container
1. Deixe a linha de conexão do container descomentada e comente a conexão local.
![image](https://github.com/MayconLSilva/CustomerControl/assets/24304710/73e23a4d-5a21-477c-b659-49d523f2d335)
2. No seu Visual Studio no menu: "Ferramentas > Linha de Comando > Prompt de Comando do Desenvolvedor" digite os seguintes comandos.
> docker compose build

> docker compose up apicustomercontrol
3. Após execuçao do seu container, abra seu navegador e digite o seguinte endereço:
> http://localhost:16543/browser/

> Utilize o E-mail: admin@admin.com e Senha: admin123
4. Após acessar o pgAdmin verifique se banco e tabelas estão criadas, caso contrário:
> Criar Banco

> Criar tabela customer

> Criar tabela customer e-mail

5. Abra seu navegador e digite o seguinte endereço:
> http://localhost:8080/swagger/index.html

![image](https://github.com/MayconLSilva/CustomerControl/assets/24304710/598d0587-133b-41eb-b245-0e3285a7075c)
