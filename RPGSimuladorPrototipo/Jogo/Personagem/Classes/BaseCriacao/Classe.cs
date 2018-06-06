using RPGSimuladorPrototipo.Jogo.Personagem.Classes.NaoAlterar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo.Personagem
{
    abstract class Classe
    {
        private string Nome { get; }

        private TipoArma Arma { get; }

        private TipoArmadura Armadura {get; }

        private int FormulaAtaque { get; }

        private int FormulaDefesa { get; }
    }
}




