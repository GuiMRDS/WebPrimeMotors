using Microsoft.AspNetCore.Mvc;
using WebPrimeMotors.Helper;
using WebPrimeMotors.Models;
using WebPrimeMotors.Repositorio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebPrimeMotors.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;
        private readonly ISessao _sessao;

        public VeiculoController(IVeiculoRepositorio veiculoRepositorio, ISessao sessao)
        {
            _veiculoRepositorio = veiculoRepositorio;
            _sessao = sessao;
        }


        public IActionResult Index()
        {
            List<VeiculoModel> veiculos = _veiculoRepositorio.BuscarTodos();
            
            return View(veiculos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            VeiculoModel veiculo = _veiculoRepositorio.ListarPorId(id);
            return View(veiculo);
        }
        public IActionResult ApagarConfimar(int id)
        {
            VeiculoModel veiculo = _veiculoRepositorio.ListarPorId(id);
            return View(veiculo);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _veiculoRepositorio.Apagar(id);


                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Veiculo apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, nao conseguimos apagar o veiculo com sucesso!";
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos apagar o veiculo com sucesso, detalhe do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(VeiculoModel veiculo)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    veiculo = _veiculoRepositorio.Adicionar(veiculo);
                    TempData["MensagemSucesso"] = "Veiculo adicionado com sucesso";
                    return RedirectToAction("index");
                }

                return View(veiculo);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos adiciorar o veiculo com sucesso, detalhe do erro: {erro.Message}";
                return RedirectToAction("index");

            }
        }


        [HttpPost]
        public IActionResult Alterar(VeiculoModel veiculo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _veiculoRepositorio.Atualizar(veiculo);
                    TempData["MensagemSucesso"] = "Veiculo alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", veiculo);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos alterar o veiculo , detalhe do erro: {erro.Message}";
                return RedirectToAction("index");

            }
        }
    }
}
