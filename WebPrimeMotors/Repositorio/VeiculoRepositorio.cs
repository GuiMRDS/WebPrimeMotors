using WebPrimeMotors.Data;
using WebPrimeMotors.Models;

namespace WebPrimeMotors.Repositorio
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public VeiculoRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }

        public VeiculoModel ListarPorId(int id)
        {
            return _bancoContext.Veiculos.FirstOrDefault(x => x.Id == id);
        }

        public List<VeiculoModel> BuscarTodos()
        {
            return _bancoContext.Veiculos.ToList();
        }

        public VeiculoModel Adicionar(VeiculoModel veiculo)
        {
            // gravar no banco de dados

            _bancoContext.Veiculos.Add(veiculo);
            _bancoContext.SaveChanges();
            return veiculo;
        }

        public VeiculoModel Atualizar(VeiculoModel veiculo)
        {
            VeiculoModel veiculoDB = ListarPorId(veiculo.Id);

            if (veiculoDB == null) throw new System.Exception("Houve um erro na atualizacao do veiculo!");

            veiculoDB.Carro = veiculo.Carro;
            veiculoDB.Modelo = veiculo.Modelo;
            veiculoDB.Cor = veiculo.Cor;
            veiculoDB.Ano = veiculo.Ano;
            veiculoDB.Kilometragem = veiculo.Kilometragem;


            _bancoContext.Veiculos.Update(veiculoDB);
            _bancoContext.SaveChanges();

            return veiculoDB;
        }

        public bool Apagar(int id)
        {
            VeiculoModel veiculoDB = ListarPorId(id);

            if (veiculoDB == null) throw new System.Exception("Houve um erro na delecao do veiculo!");

            _bancoContext.Veiculos.Remove(veiculoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public bool Vender(int id)
        {
            VeiculoModel veiculoDB = ListarPorId(id);

            if (veiculoDB == null) throw new System.Exception("Houve um erro ao vender o veiculo!");

            _bancoContext.Veiculos.Remove(veiculoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
