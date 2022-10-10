# DIO - Trilha .NET - API e Entity Framework
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de API e Entity Framework, da trilha .NET da DIO.

## Solução
### Como rodar?
1. Você precisa inicialmente clonar esse repositório em sua máquina
2. Você precisa ter o Docker instalado em sua máquina, pois é com ele que iremos criar o banco. Com o Docker já em execução, abra o CMD e insira o seguinte comando: 'docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest' (sem aspas simples). Após executar esse comando, o CMD irá mostrar algumas coisas na tela, e isso pode levar um tempo (mas nada demais).
3. Após isso, abra o Visual Studio ou Rider e você já pode executar normalmente o projeto. Ele imediatamente se conectará ao banco de dados e realizará automaticamente a criação do banco e da tabela de tarefas. Recomendo executar em modo Debug, para que seja mostrado o Swagger.

