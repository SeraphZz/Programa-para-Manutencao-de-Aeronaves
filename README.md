# Programa de Manutenção de Aeronaves

Sistema para controle e manutenção de aeronaves, desenvolvido em C# (.NET Framework 4.7.2) com Windows Forms, MaterialSkin e integração com banco de dados MySQL.

## Funcionalidades

- Visualização e cadastro de aeronaves
- Gerenciamento de partes e tarefas de manutenção
- Interface moderna baseada em Material Design
- Integração com banco de dados MySQL

## Tecnologias Utilizadas

- .NET Framework 4.7.2
- Windows Forms
- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin)
- MySQL
- [XAMPP](https://www.apachefriends.org/pt_br/index.html) (para ambiente MySQL local)

## Pré-requisitos

- Visual Studio 2022
- XAMPP instalado e rodando (MySQL)
- .NET Framework 4.7.2
- Pacotes NuGet:
  - MaterialSkin
  - MySql.Data
  - MySqlConnector

## Configuração do Banco de Dados

1. **Instale o XAMPP**  
   Baixe e instale o [XAMPP](https://www.apachefriends.org/pt_br/index.html) para ter o MySQL localmente.

2. **Inicie o MySQL pelo XAMPP**  
   Abra o painel de controle do XAMPP e inicie o serviço MySQL.

3. **Importe o banco de dados**  
   - Abra o phpMyAdmin (acessível via XAMPP).
   - Crie um banco de dados chamado `aereo_db`.
   - Importe o arquivo SQL fornecido com o projeto (ou crie as tabelas conforme necessário).

4. **Ajuste a string de conexão se necessário**  
   No código, a string padrão é:
string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;"
Altere conforme o usuário e senha do seu MySQL.
## Como Executar

1. Clone este repositório.
2. Abra o projeto no Visual Studio 2022.
3. Restaure os pacotes NuGet.
4. Certifique-se de que o MySQL está rodando via XAMPP e o banco de dados foi importado.
5. Compile e execute o projeto (`F5`).

## Observações

- O projeto depende do banco de dados MySQL estar disponível e corretamente configurado.
- Certifique-se de que as tabelas estejam criadas conforme esperado.
- Ajuste permissões do usuário do banco de dados se necessário.

## Licença

Este projeto é distribuído sob a licença MIT.

---

Desenvolvido por Augusto Ferraz :).
