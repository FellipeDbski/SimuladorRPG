using RPGSimuladorPrototipo.Jogo.Equipamento.NaoAlterar;
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

        string Nome { get; set; }

        public Armas ArmaID_MDireita { get; private set; }

        public Armas ArmaID_MEsquerda { get; private set; }

        public Armadura ArmaduraID_Set { get; private set; }
    }
}
