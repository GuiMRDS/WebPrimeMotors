# 🚗 WebPrime Motors

<div align="center">

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core_MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap_5-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)

**Sistema web corporativo de gestão de concessionária de veículos**

🌐 [**Ver Demo Online**](https://webprimemotors.somee.com/) · 📂 [**Repositório**](https://github.com/GuiMRDS/WebPrimeMotors)

</div>

---

## 📌 Sobre o Projeto

WebPrime Motors é um sistema web corporativo completo para **gerenciamento de concessionária de veículos**, desenvolvido com **ASP.NET Core MVC** e **C#**. O projeto aplica separação de responsabilidades, arquitetura em camadas e boas práticas de engenharia de software.

O sistema contempla gerenciamento completo de **usuários** e **veículos**, com controle de perfis de acesso, persistência de dados com **Entity Framework Core (Code First)** e interface responsiva com suporte a **tema claro e escuro**.

---

## ✅ Funcionalidades

### 👤 Usuários
- CRUD completo (Cadastro, Listagem, Edição e Exclusão)
- Controle de perfis: **Administrador** e **Padrão**
- Alteração de senha com validações
- Histórico de data de cadastro e última atualização

### 🚙 Veículos
- CRUD completo (Cadastro, Listagem, Edição e Exclusão)
- Registro de: Marca, Modelo, Cor, Ano e Quilometragem
- Ação específica de **venda de veículo**
- Listagem responsiva com ações rápidas (Editar, Apagar)

### 🎨 Interface e UX
- Sidebar fixa para navegação entre módulos
- Layout totalmente responsivo com **Bootstrap 5**
- **Tema claro e escuro** alternável pelo usuário (CSS Variables + JavaScript)
- Cards centralizados para formulários e confirmação de ações
- Alerts visuais de feedback para sucesso e erro nas operações

---

## 🛠️ Tecnologias Utilizadas

| Camada | Tecnologia |
|---|---|
| Backend | ASP.NET Core MVC · C# |
| ORM / Banco de Dados | Entity Framework Core (Code First) · SQL Server |
| Frontend | HTML5 · CSS3 · Bootstrap 5 · JavaScript |
| Ícones | Bootstrap Icons |
| Tema | CSS Custom Properties (`:root` + `data-theme`) |
| Versionamento | Git · GitHub |
| Deploy | Somee.com |

---

## 🗂️ Estrutura do Projeto

```
WebPrimeMotors/
│
├── Controllers/
│   ├── UsuarioController.cs
│   ├── VeiculoController.cs
│   ├── AlterarSenhaController.cs
│   └── HomeController.cs
│
├── Models/
│   ├── UsuarioModel.cs
│   ├── VeiculoModel.cs
│   └── AlterarSenhaModel.cs
│
├── Views/
│   ├── Shared/
│   │   └── _Layout.cshtml
│   ├── Usuario/
│   │   ├── Index.cshtml
│   │   ├── Criar.cshtml
│   │   ├── Editar.cshtml
│   │   └── Apagar.cshtml
│   ├── Veiculo/
│   │   ├── Index.cshtml
│   │   ├── Criar.cshtml
│   │   ├── Editar.cshtml
│   │   └── Apagar.cshtml
│   └── AlterarSenha/
│       └── Index.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── appsettings.json
├── WebPrimeMotors.sln
└── README.md
```

---

## 🚀 Como Executar Localmente

### Pré-requisitos

- [.NET SDK 6+](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recomendado) ou VS Code

### Passo a passo

**1. Clone o repositório**
```bash
git clone https://github.com/GuiMRDS/WebPrimeMotors.git
cd WebPrimeMotors
```

**2. Configure a connection string**

No arquivo `appsettings.json`, ajuste a string de conexão com o seu SQL Server:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=WebPrimeMotors;Trusted_Connection=True;"
}
```

**3. Aplique as migrations (Entity Framework)**
```bash
dotnet ef database update
```

**4. Execute o projeto**
```bash
dotnet run --project WebPrimeMotors
```

Ou abra o arquivo `WebPrimeMotors.sln` no Visual Studio e pressione `F5`.

> 🌐 O sistema também está disponível online em: **[webprimemotors.somee.com](https://webprimemotors.somee.com/)**

---

## 🏗️ Arquitetura

O projeto segue o padrão **MVC (Model-View-Controller)** com separação clara de responsabilidades:

- **Controllers** — responsáveis exclusivamente pelo fluxo da aplicação
- **Models** — entidades fortemente tipadas integradas às Views Razor
- **Views (Razor)** — camada de apresentação com componentes visuais padronizados
- **TempData / ViewData** — controle de estado e feedback entre requisições
- **Entity Framework Core (Code First)** — mapeamento objeto-relacional e gerenciamento do banco de dados

---

## 📚 O que foi Aprendido

- Desenvolvimento de aplicações web corporativas com **ASP.NET Core MVC**
- Modelagem e persistência de dados com **Entity Framework Core Code First**
- Controle de acesso por perfis de usuário
- Implementação de **tema claro/escuro** com CSS Variables e JavaScript
- Boas práticas de organização em camadas e separação de responsabilidades
- Deploy de aplicação .NET em ambiente de hospedagem compartilhada

---

## 👨‍💻 Autor

**Guilherme Marinho**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-guilherme--marinho04-blue?style=flat&logo=linkedin)](https://www.linkedin.com/in/guilherme-marinho04/)
[![GitHub](https://img.shields.io/badge/GitHub-GuiMRDS-black?style=flat&logo=github)](https://github.com/GuiMRDS)
[![Email](https://img.shields.io/badge/Email-guimars22%40gmail.com-red?style=flat&logo=gmail)](mailto:guimars22@gmail.com)

---

## 📄 Licença

Este projeto foi desenvolvido para fins de estudo e portfólio.
