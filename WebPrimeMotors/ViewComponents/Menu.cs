using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebPrimeMotors.Models;

namespace WebPrimeMotors.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
                return Content(""); // session vazia

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

            return View(usuario); // passa o Model para a view
        }
    }
}
