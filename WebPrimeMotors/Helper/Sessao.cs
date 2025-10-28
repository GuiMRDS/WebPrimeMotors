using WebPrimeMotors.Models;
using Newtonsoft.Json;

namespace WebPrimeMotors.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpsContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpsContext = httpContext;            
        }

        public UsuarioModel BuscarSessaoDoUsuario()
        {
            string sessoaUsuario = _httpsContext.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessoaUsuario)) return null;

            return JsonConvert.DeserializeObject<UsuarioModel>(sessoaUsuario);
        }

        public void CriarSessaoDoUsuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);

            _httpsContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoDoUsuario()
        {
            _httpsContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
