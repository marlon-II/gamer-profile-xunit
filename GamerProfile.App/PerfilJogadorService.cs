using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerProfile.App
{
    public class PerfilJogadorService
    {
            private const int BonusXP = 100;
    private const int NivelMinimoRanked = 15;
 
    // Retorno string: concatena nickname e código com "#"
    public string GerarTagUsuario(string nickname, string codigo)
    {
        return $"{nickname}#{codigo}";
    }
 
    // Retorno int: soma o XP das duas fases e aplica o bônus fixo de 100 pontos
    public int CalcularXPTotal(int xpFase1, int xpFase2)
    {
        return xpFase1 + xpFase2 + BonusXP;
    }
 
    // Retorno bool: true se o nível for maior ou igual a 15
    public bool EEligivelParaRanked(int nivelJogador)
    {
        return nivelJogador >= NivelMinimoRanked;
    }

    }
}