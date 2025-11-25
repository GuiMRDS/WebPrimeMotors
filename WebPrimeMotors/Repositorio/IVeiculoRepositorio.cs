using WebPrimeMotors.Models;

namespace WebPrimeMotors.Repositorio
{
    public interface IVeiculoRepositorio
    {
        VeiculoModel ListarPorId(int id);
        List<VeiculoModel> BuscarTodos();
        VeiculoModel Adicionar(VeiculoModel veiculo);
        VeiculoModel Atualizar(VeiculoModel veiculo);
        bool Apagar(int id);
        bool Vender(int id);
    }
}
