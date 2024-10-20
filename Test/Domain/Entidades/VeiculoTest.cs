using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var veiculo = new Veiculo();

        veiculo.Id = 1;
        veiculo.Nome = "Teste";
        veiculo.Marca = "teste";
        veiculo.Ano = 1996;

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Teste", veiculo.Nome);
        Assert.AreEqual("teste", veiculo.Marca);
        Assert.AreEqual(1996, veiculo.Ano);
    }
}