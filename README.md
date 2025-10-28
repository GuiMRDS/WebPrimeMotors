# WebPrime Motors

Sistema de gerenciamento para concessionária de veículos, desenvolvido em **ASP.NET Core MVC** com **C#**, utilizando **Entity Framework Core** e **Bootstrap** para interface responsiva.  

**Site Online:** [https://webprimemotors.com](https://webprimemotors.com)

---

## Funcionalidades

### Usuários
- Cadastro, edição e exclusão de usuários.
- Controle de perfis (Administrador e Padrão).
- Alteração de senha com validação.
- Visualização de histórico de cadastro e atualização.

### Veículos
- Cadastro, edição e exclusão de veículos.
- Informações: Carro, Modelo, Cor, Ano e Kilometragem.
- Listagem em tabela responsiva com ações rápidas (Editar, Apagar).

### Interface
- Sidebar fixa para navegação entre módulos.
- Layout responsivo usando **Bootstrap 5**.
- Tema claro e escuro alternável pelo usuário.
- Cards centralizados para formulários e confirmação de ações.
- Alerts para feedback de sucesso ou erro nas operações.

---

## Estrutura do Projeto

WebPrimeMotors/
│
├── Controllers/
│ ├── UsuarioController.cs
│ ├── VeiculoController.cs
│ ├── AlterarSenhaController.cs
│ └── HomeController.cs
│
├── Models/
│ ├── UsuarioModel.cs
│ ├── VeiculoModel.cs
│ └── AlterarSenhaModel.cs
│
├── Views/
│ ├── Shared/
│ │ └── _Layout.cshtml
│ ├── Usuario/
│ │ ├── Index.cshtml
│ │ ├── Criar.cshtml
│ │ ├── Editar.cshtml
│ │ └── Apagar.cshtml
│ ├── Veiculo/
│ │ ├── Index.cshtml
│ │ ├── Criar.cshtml
│ │ ├── Editar.cshtml
│ │ └── Apagar.cshtml
│ └── AlterarSenha/
│ └── Index.cshtml
│
├── wwwroot/
│ ├── css/
│ ├── js/
│ └── lib/
│
└── appsettings.json


---

## Tecnologias Utilizadas

- **Backend:** ASP.NET Core MVC, C#  
- **Banco de Dados:** SQL Server (via Entity Framework Core - Code First)  
- **Frontend:** HTML5, CSS3, Bootstrap 5, JavaScript  
- **Icons:** Bootstrap Icons  
- **Controle de Tema:** CSS custom properties (`:root` e `data-theme`) + JavaScript  

---

Autor

Guilherme Marinho

E-mail: guimars22@gmail.com
LinkedIn: linkedin.com/in/guilherme-marinho04
