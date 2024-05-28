# Sistema de Cadastro de alunos

## Arquitetura e Stack
<hr />

* Foi adotado a Arquitetura MVC(Model, View, Controller)
* A implementação é feita em C#;
* A persistência dos dados é feita em SQLite usando o <a href="https://learn.microsoft.com/en-us/ef/">EntityFramework </a>
* Foi utilizado framework Asp.Net (documentação disponivel em <a href="https://dotnet.microsoft.com/pt-br/apps/aspnet">Aps.Net</a>)

## Execução
<hr>

* Comando para adicionar o banco de dados local. 
  
  -- Package Manager Console     
 
       Add-Migragrion NomeQueDesejar
       update-database
       
  -- Terminal
      
       dotnet ef migrations add NomeDaMigracao
       dotnet ef database update

      
 * Comando para Executar o projeto    
   -- Package Manager Console
       
       dotnet run
    

   -- Terminal

       dotnet watch run  





