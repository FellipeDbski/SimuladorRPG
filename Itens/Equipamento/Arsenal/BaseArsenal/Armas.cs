using Itens.Equipamento.Arsenal;
using Itens.Equipamento.Arsenal.BaseArsenal;
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
        public int ID { get; set; }

        public string _Nome { get; private set; }

        public EnumCategoria _TipoCategoria { get; private set; }

        public EnumModelo _TipoModelo { get; private set; }

        public string _Descriao { get; private set; }

        public string _CaminhoImagem { get; private set; }

        public int _Dano { get; private set; }

        public double _Peso { get; private set; }


        public void CriaArmamento(string nome, EnumCategoria tipoCat, EnumModelo tipoMod, string descricao)
        {
            _Nome = nome;
            _TipoCategoria = tipoCat;
            _TipoModelo = tipoMod;
            _Descriao = descricao;
        }

        public void DetalhaArmamento(string path, int dano, double peso)
        {
            _CaminhoImagem = path;
            _Dano = dano;
            _Peso = peso;
        }
    }
}
