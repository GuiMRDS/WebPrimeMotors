using Microsoft.AspNetCore.Mvc;
using WebPrimeMotors.Enum;
using WebPrimeMotors.Models;
using WebPrimeMotors.Repositorio;

namespace WebPrimeMotors.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();

            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }

        
        public IActionResult ApagarConfimar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepositorio.Apagar(id);


                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, nao conseguimos apagar o usuario com sucesso!";
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos apagar o usuario com sucesso, detalhe do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuario = _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "O usuario adicionado com sucesso";
                    return RedirectToAction("index");
                }

                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos adiciorar o usuario com sucesso, detalhe do erro: {erro.Message}";
                return RedirectToAction("index");

            }
        }

        [HttpPost]
        public IActionResult Alterar(UsuarioSemSenhaModel usuarioSemSenha)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Buscar o usuário existente do banco
                    UsuarioModel usuario = _usuarioRepositorio.ListarPorId(usuarioSemSenha.Id);

                    if (usuario == null)
                        throw new Exception("Usuário não encontrado!");

                    // Atualizar apenas os campos permitidos
                    usuario.Nome = usuarioSemSenha.Nome;
                    usuario.Login = usuarioSemSenha.Login;
                    usuario.Email = usuarioSemSenha.Email;
                    usuario.Perfil = usuarioSemSenha.Perfil;

                    // Salvar alterações
                    _usuarioRepositorio.Atualizar(usuario);

                    TempData["MensagemSucesso"] = "Usuario foi alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", usuarioSemSenha);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos atualizar o usuario , detalhe do erro: {erro.Message}";
                return RedirectToAction("index");

            }
        }


    }
}
