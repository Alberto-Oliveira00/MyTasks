# 📂 MyTasks

**MyTasks** é um projeto simples de console desenvolvido em **C# com .NET**, criado com o objetivo de **praticar conceitos de Programação Orientada a Objetos (POO)**, como encapsulamento, abstração e responsabilidade única.

Este projeto é uma aplicação simples de **gerenciamento de tarefas (To-Do List)**, que permite adicionar, listar, concluir e remover tarefas diretamente pelo terminal.

---

## 📚 Objetivo

Este projeto foi criado como parte dos meus estudos em **C# e .NET**, com foco no reforço de fundamentos de:

* Programação Orientada a Objetos (POO)
* Estruturação de classes e métodos
* Manipulação de listas e objetos
* Fluxo de menus em aplicação de console
* Práticas de boas mensagens ao usuário

---

## 🛠️ Funcionalidades

* ✅ Adicionar nova tarefa com título e descrição
* 📋 Listar todas as tarefas cadastradas
* ⏳ Listar apenas tarefas pendentes
* ✔️ Concluir uma tarefa
* ❌ Remover uma tarefa
* 📅 Exibir data de criação e, se aplicável, data de conclusão da tarefa

---

## 💻 Como executar

### Requisitos:

* [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos:

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/MyTasks.git
cd MyTasks
```

2. Compile e execute:

```bash
dotnet run
```

---

## 🧱 Estrutura do Projeto

* `Program.cs`: Menu principal e fluxo de entrada do usuário
* `Tarefa.cs`: Classe que representa uma tarefa com ID, título, descrição, status e datas
* `GerenciadorDeTarefas.cs`: Classe responsável por gerenciar a lista de tarefas e operações CRUD

---

## ✍️ Exemplo de uso

```bash
Bem vindo ao MyTasks
--------------------

Escolha uma opção para continuar:

1 - Adicionar nova tarefa
2 - Listar todas tarefas
3 - Listar tarefas pendentes
4 - Concluir uma tarefa
5 - Remover uma tarefa
6 - Sair
```

---

## 🚀 Melhorias futuras (ideias)

* Persistência de dados (JSON, banco de dados ou arquivos)
* Filtro por data
* Interface gráfica com Windows Forms ou WPF
* Exportação de tarefas concluídas
* Validações mais robustas

---

## 👨‍💼 Autor

Desenvolvido por Alberto – Projeto pessoal de prática em C#.

---
