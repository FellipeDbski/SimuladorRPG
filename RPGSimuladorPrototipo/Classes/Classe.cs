using RPGSimuladorPrototipo.Jogo.Personagem.Classes.NaoAlterar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo.Personagem
{
    public class Classe
    {
        public string Nome { get; }

        public TipoArma Arma { get; }

        public TipoArmadura Armadura {get; }

        public int FormulaAtaque { get; }

        public int FormulaDefesa { get; }
    }
}




