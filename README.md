# 1º Passo
Para fazer a carga inicial no banco de dados é necessario rodar o seguinte comando:
>dotnet ef database update Initial --project MRV.Infrastructure -s MRV.API -c SqlDbContext --verbose

Caso ocorra algum erro informando que o projeto MRV.API não tem acesso a referencia do Microsoft.EntityFrameworkCore.Design, é só ir no arquivo do  projeto MRV.Infrastructure e mudar o valor da tag:
> <PrivateAssets'>all</PrivateAssets'> **para** <PrivateAssets'>none</PrivateAssets'>
