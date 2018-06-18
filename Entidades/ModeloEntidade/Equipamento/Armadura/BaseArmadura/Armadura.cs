using RPGSimuladorPrototipo.Jogo.Personagem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimuladorPrototipo.Jogo.Equipamento
{
    public class Armadura
    {
        public int ID { get; set; }

        public string _Nome { get; private set; }

        public TipoArmadura _Tipo { get; private set; }

        public string _Descriao { get; private set; }

        public string _CaminhoImagem { get; private set; }

        public int _Defesa { get; private set; }

        public double _Peso { get; private set; }


        public void CriaArmamento(string nome, TipoArmadura tipo, string descricao)
        {
            _Nome = nome;
            _Tipo = tipo;
            _Descriao = descricao;
        }

        public void DetalhaArmamento(string path, int defesa, double peso)
        {
            _CaminhoImagem = path;
            _Defesa = defesa;
            _Peso = peso;
        }

    }
}
