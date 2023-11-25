# Dicas

Projeto de estudo do EntityFramwork
Professor: balta
YT: https://www.youtube.com/watch?v=QzCSN9wN4JA
Material adicional: https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud?view=aspnetcore-8.0

## Comandos

### Criar migração

    ```dotnet ef migrations add <NOME>```

    Cria uma migração.
    Diferente do EloquentORM do Laravel, o EntityFramework consegue analisar as models para criar automaticamente as migrações. É necessário que exista uma migration (mesmo em branco) para que o EntityFramework compare as diferenças entre as entidades e assim gere as migrações que reflitam as diferenças no banco de dados

### Aplicar alterações ao banco

    ```dotnet ef database update```

    Aplica as alterações pendentes no banco de dados

### Reverter uma migração

    ```dotnet ef migrations remove```

    Remove sempre a ultima migração.
    Pode executar varias vezes em sequencia para remover migrações, passo a passo.
