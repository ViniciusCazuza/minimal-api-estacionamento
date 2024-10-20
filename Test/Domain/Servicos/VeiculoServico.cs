using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.Dominio.Sevicos;
using System.Reflection;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoServicoTest
{
        private DbContexto CriarContextoDeTeste()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", "..")); 

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration = builder.Build();

        var connectionString = configuration.GetConnectionString("MySql");

        
        var options = new DbContextOptionsBuilder<DbContexto>()
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .Options;

        return new DbContexto(options);
    }

   [TestMethod]
    public void TestandoSalvarVeiculo()
    {
        // Arrange
        var context = CriarContextoDeTeste();

        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");
        
        var veiculo = new Veiculo();
        veiculo.Id = 1;
        veiculo.Nome = "test 2.0";
        veiculo.Marca = "teste";
        veiculo.Ano = 1951;

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Incluir(veiculo);

        // Assert
        Assert.AreEqual(1, veiculoServico.Todos(1).Count());
        Assert.AreEqual("test 2.0", veiculo.Nome);
        Assert.AreEqual("teste", veiculo.Marca);
        Assert.AreEqual(1951, veiculo.Ano);
    }

     [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var context = CriarContextoDeTeste();

        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");
        
        var veiculo = new Veiculo();
        veiculo.Id = 1;
        veiculo.Nome = "test 2.0";
        veiculo.Marca = "teste";
        veiculo.Ano = 1951;

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Incluir(veiculo);
        var veiculoDoBanco = veiculoServico.BuscaPorId(veiculo.Id);

        // Assert
        Assert.AreEqual(1, veiculoDoBanco.Id);
        
    }

}