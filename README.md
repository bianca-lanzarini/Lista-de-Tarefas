# Lista de Tarefas

Este é um projeto de **Lista de Tarefas** desenvolvido em **C#**, com **SQL Server** para o banco de dados e **React** para a interface (a ser implementada posteriormente). O sistema permite gerenciar tarefas, oferecendo funcionalidades como criação, atualização e controle do status das tarefas.

## Funcionalidades

- **Cadastro de Tarefas**: Criar tarefas com título, descrição e prazo.
- **Gerenciamento de Status**: Acompanhar o status da tarefa, com as opções "Pendente", "Em Andamento" e "Concluída".
- **Validações**: Validação de dados de entrada (como tamanho de título e descrição, e data de prazo futura).
- **Banco de Dados**: Uso de SQL Server para armazenar informações sobre as tarefas e usuários.

## Tecnologias Utilizadas

- **Backend**: C# com .NET
- **Banco de Dados**: SQL Server
- **Frontend**: React (a ser implementado posteriormente)
- **Validações de Dados**: Implementação de regras de negócios na classe de regras, como validação de título, descrição e prazo.

## Estrutura do Projeto

- **Domain**: Contém as classes de domínio (como `Tarefa` e `Usuario`).
- **Business Logic**: Contém as regras de negócio (validações de dados e manipulação de tarefas).
- **Repository**: Para persistência de dados e interações com o banco de dados (a ser implementado posteriormente).
- **API**: Para comunicação entre o backend e o frontend (a ser implementada posteriormente).