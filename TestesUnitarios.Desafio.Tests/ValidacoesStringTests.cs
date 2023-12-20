using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {

        string texto = "Matrix";
        int resultadoEsperado = 6;

        int resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        string texto = "Esse é um texto qualquer";
        string textoProcurado = "qualquer";

        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        string texto = "Esse é um texto qualquer";
        string textoProcurado = "teste";

        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        Assert.False(resultado);
    }


    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        string texto = "Começo, meio e fim do texto procurado";
        string textoProcurado = "procurado";

        // Act
        bool resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
