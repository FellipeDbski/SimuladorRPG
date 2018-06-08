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
        public string Nome { get; } 

        public TipoArma Tipo { get; }

        public string Descriao { get; set; }

        public byte[] Foto { get; set; }

        public long Tamanho { get; set; }

        public int Dano { get; }

        public double Peso { get; }
    }
}
