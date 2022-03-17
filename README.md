## :computer: Projeto E-Commerce - Nerd Store

Projeto Open-Source feito em .NET Core

Foi baseado em um e-commerce de vendas, inicialmente feito apenas para camisetas e canecas.

## :woman_technologist: Tecnologias
- ASP.NET 3.1
- ASP.NET MVC Core
- ASP.NET Identity Core
- Entity Framework Core 3.1
- Fluent Api
- FluentValidator
- AutoMapper
- MediatR
- Teste de unidade

## :building_construction: Arquitetura
- Arquitetura completa com questões de separação de responsabilidades, SOLID e Clean Code
- Domain Driven Design (Camadas e padrão de modelo de domínio)
- Domain Events
- Domain Notification
- Domain Validations
- CQRS (Consistência Imediata)
- Event Sourcing
- Unit of Work
- Repository
- XUnit para cobertura de testes

## :zap: Running
- Ter instalado o [SDK .Net Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- SSMS (SQL SERVER) - Rodar as migrations para cada contexto
- Instalar [Envent Store](https://developers.eventstore.com/)
- Habilitar o Event Store (Após executar o passo a passo de instalação conforme a documentação) [Quick start](https://developers.eventstore.com/server/v21.2/docs/installation/#configuration-wizard)
  - Posicionar o cmd na pasta instalada, provavelmente no seu C:\ESDB ou qualquer outro diretorio, no meu caso está no D:\ESDB
  - Executar comando EventStore.ClusterNode.exe --config D:\ESDB\eventstore.conf
