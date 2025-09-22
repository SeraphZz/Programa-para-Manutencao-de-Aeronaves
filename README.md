# Programa de Manutenção de Aeronaves

Este é um sistema de controle e manutenção de aeronaves desenvolvido em C# (.NET Framework 4.7.2) utilizando Windows Forms, MaterialSkin para interface moderna e integração com banco de dados MySQL.

## Funcionalidades

- Visualização de aeronaves cadastradas
- Interface moderna baseada em Material Design
- Integração com banco de dados MySQL
- Estrutura pronta para cadastro, edição e exclusão de registros

## Tecnologias Utilizadas

- .NET Framework 4.7.2
- Windows Forms
- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) (UI)
- MySQL Connector/NET

## Pré-requisitos

- Visual Studio 2022
- MySQL Server
- .NET Framework 4.7.2
- Pacotes NuGet:
  - MaterialSkin
  - MySql.Data
  - MySqlConnector

## Configuração do Banco de Dados

1. Crie o banco de dados `aereo_db` no MySQL.
2. Crie a tabela `aeronaves` conforme necessário para o seu domínio.
3. Atualize a string de conexão no código, se necessário:
