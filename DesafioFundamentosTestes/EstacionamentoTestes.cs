using DesafioFundamentos.Services;
namespace DesafioFundamentosTestes;


public class EstacionamentoTestes
{

    private EstacionamentoImp _estac;

    public EstacionamentoTestes()
    {
        _estac = new EstacionamentoImp(2, 2);
    }

    [Fact]
    public void AdicionarVeiculo_DeveAdicionar145NaListaVeiculosERetornarTrue()
    {
        // Arrange
        string placa1 = "145";

        // Act
        _estac.AdicionarVeiculo(placa1);
        bool resultado = _estac.Veiculos.Contains(placa1);
        
        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void RemoverVeiculo_DeveRemover145NaListaVeiculosERetornarFalse()
    {
        // Arrange
        string placa1 = "145";

        // Act
        _estac.RemoverVeiculo(placa1);
        bool resultado = _estac.Veiculos.Contains(placa1);
        
        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void ListarVeiculos_DeveExibirVeiculosQuandoExistirem()
    {
        // Arrange
        string placa1 = "145";
        _estac.AdicionarVeiculo(placa1);

        // Act
        string result = _estac.ListarVeiculos();

        // Assert
        Assert.Contains("VEÍCULOS ESTACIONADOS", result);
        Assert.Contains("Quantidade total.....:", result);
        Assert.Contains("1 | " + placa1, result);
    }

    [Fact]
    public void AtualizarValoresPadroes_DeveAlterarOPrecoInicialPara10EPrecoPorHoraPara5()
    {
        // Arrange
        decimal novoPrecoInicial = 10;
        decimal novoPrecoPorHora = 5;

        // Act
        _estac.AtualizarValoresPadroes(novoPrecoInicial, novoPrecoPorHora); 

        // Assert
        Assert.Equal(novoPrecoInicial, _estac.PrecoInicialParaTeste);
        Assert.Equal(novoPrecoPorHora, _estac.PrecoPorHoraParaTeste);
    }
}