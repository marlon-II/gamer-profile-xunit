using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamerProfile.App;

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceTests
    {
            private readonly PerfilJogadorService _service = new();
 
    // Teste 1 (string): valida a formatação da tag do usuário
    [Fact]
    public void GerarTagUsuario_DeveRetornarNicknameCerquilhaCodigo()
    {
        string resultado = _service.GerarTagUsuario("Nickname", "0000");
 
        Assert.Equal("Nickname#0000", resultado);
    }
 
    // Teste 2 (int): valida a soma das fases e o bônus fixo de 100 pontos
    [Fact]
    public void CalcularXPTotal_DeveSomarFasesEAplicarBonus()
    {
        int valorEsperado = 600; // 200 + 300 + 100
 
        int resultado = _service.CalcularXPTotal(200, 300);
 
        Assert.Equal(valorEsperado, resultado);
    }
 
    // Teste 3 (bool): valida a elegibilidade para partidas ranqueadas
    [Fact]
    public void EEligivelParaRanked_DeveValidarNivelMinimoDe15()
    {
        // Níveis a partir de 15 são elegíveis
        Assert.True(_service.EEligivelParaRanked(15));
        Assert.True(_service.EEligivelParaRanked(20));
 
        // Níveis abaixo de 15 não são elegíveis
        Assert.False(_service.EEligivelParaRanked(14));
        Assert.False(_service.EEligivelParaRanked(1));
    }

    }
}