using RPGSimuladorPrototipo.Jogo.Personagem.Classes.NaoAlterar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo
{
    public class Armas
    {
        private int ID { get; }

        public string Nome { get; } 

        public TipoArma Tipo { get; }

        public int Dano { get; }

        public double Peso { get; }
    }
}
