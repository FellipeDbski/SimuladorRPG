using RPGSimuladorPrototipo.Jogo;
using RPGSimuladorPrototipo.Jogo.Equipamento;
using RPGSimuladorPrototipo.Jogo.Personagem;
using RPGSimuladorPrototipo.Jogo.Personagem.Classes.BaseCriacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ModeloEntidade.Inimigos
{
    public class Inimigos
    {
        public int ID { get; set; }

        public string _Nome { get; set; }

        public Arsenal Arma_D { get; private set; }

        public int _ArmaID_MDireita { get; private set; }

        public Arsenal Arma_E { get; private set; }

        public int _ArmaID_MEsquerda { get; private set; }

        public Armadura Armadura { get; private set; }

        public int _ArmaduraID_Set { get; private set; }

        public Milicias Milicias { get; set; }

        public int _Milicias_Membro { get; set; }

        public Classe Classe { get; set; }

        public int _Classe_ID { get; set; }

        public Atributos Atributos { get; set; }

        public int _Atributos_ID { get; set; }


        public void EquiparArma(Arsenal arma)
        {
            if (arma._TipoCategoria.Equals(0))
            {
                _ArmaID_MDireita = arma.ID;
            }
            else
            {
                _ArmaID_MDireita = arma.ID;
                _ArmaID_MEsquerda = arma.ID;
            }
        }

        public void EquiparArmadura(Armadura armadura)
        {
            _ArmaduraID_Set = armadura.ID;
        }

    }
}
