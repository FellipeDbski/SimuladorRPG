using RPGSimuladorPrototipo.Jogo.Equipamento.NaoAlterar;
using RPGSimuladorPrototipo.Jogo.Personagem.Classes.BaseCriacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo.Personagem
{
    public class Personagem
    {
        private int ID { get; set; }

        public string Nome { get; set; }

        public Armas Arma_D { get; private set; }

        public int ArmaID_MDireita { get; private set; }

        public Armas Arma_E { get; private set; }

        public int ArmaID_MEsquerda { get; private set; }

        public Armadura Armadura { get; private set; }

        public int ArmaduraID_Set { get; private set; }

        public Milicias Milicias { get; set; }

        public int Milicias_Membro { get; set; }

        public Classe Classe { get; set; }

        public int Classe_ID { get; set; }

        public Atributos Atributos { get; set; }

        public int Atributos_ID { get; set; }




        public void EquiparArma(Armas arma)
        {
            
        }
    }
}
