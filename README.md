# VideoGame
CRUD, utilizando o EntityFramework, mapeamentos, SQLite e conceitos de orientação a Objetos


O banco é gerado, junto a pasta do executável, se o banco já existir, utilizo o existente, se não existir nada, crio o banco usando o EntityFramework.
Todo a estrutura do banco, foi feita, baseada no modelo de banco passado pelo gitHub:https://github.com/bbrumm/databasestar/tree/main/sample_databases/sample_db_videogames

Utilizei mapeamentos dos campos para serem gerados no EntityFramework, utilizando os comandos de Migration e Update-Database;

Além do scaffolding, gerando automáticamente toda a estrutura do código.

Criei meu DataContext, para o contexto do meu banco de dados, conforme solicitado.

Criei a entidade VideoGames, que se refere ao "Games", "Genero" e "Plataforma".
Três entidades através do Entity Framework: Games, Genero e Plataforma.
Utilizei o Windows Forms e criei os CRUD, com as entidades.
