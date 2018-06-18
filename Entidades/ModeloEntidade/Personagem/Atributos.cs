using RPGSimuladorPrototipo.Jogo.Personagem.Classes;
using RPGSimuladorPrototipo.Jogo.Personagem.PastaEnumAtributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo.Personagem
{
    public class Atributos
    {
        public int ID { get; set; }

        public int PontosDistribuir { get; set; }

        public int Forca { get; set; }

        public int Resistencia { get; set; }

        public int Destreza { get; set; }

        public int Inteligencia { get; set; }

        public int Percepcao { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public EnumLadoDominante LadoDominante { get; set; }

        public EnumStatus BracoDireito { get; set; }

        public EnumStatus BracoEsquerdo { get; set; }

        public EnumStatus Corpo { get; set; }

        public EnumStatus Cabeca { get; set; }
    }
}
