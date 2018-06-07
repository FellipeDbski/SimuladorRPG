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

        public int Forca { get; set; }

        public int Defesa { get; set; }

        public EnumLadoDominante LadoDominante { get; set; }

        public EnumStatus BracoDireito { get; set; }
    }
}
