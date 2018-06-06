using RPGSimuladorPrototipo.Jogo.Personagem.Classes.NaoAlterar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo.Equipamento.NaoAlterar
{
    public class Armadura
    {
        private int ID { get; }

        public string Nome { get; }

        public TipoArmadura Tipo { get; }

        public int Defesa { get; }

        public double Peso { get; }
    }
}
