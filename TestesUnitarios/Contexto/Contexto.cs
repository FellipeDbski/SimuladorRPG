using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using RPGSimuladorPrototipo.Jogo.Personagem;
using RPGSimuladorPrototipo.Jogo.Personagem.Classes.BaseCriacao;
using RPGSimuladorPrototipo.Jogo.Equipamento;
using RPGSimuladorPrototipo.Jogo;

namespace DAO.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Prototipo")
        {

        }

        //CONTEXTO PERSONAGEM
        public DbSet<Personagem> Personagem { get; set; }
        public DbSet<Atributos> Atributos { get; set; }

        //CONTEXTO CLASSE
        public DbSet<Classe> Classe { get; set; }

        //CONTEXTO MILICIAS 
        public DbSet<Milicias> Milicia {get; set;}

        //CONTEXTO EQUIPAMENTO 
        public DbSet<Armadura> Armadura { get; set; }
        public DbSet<Arsenal> Arsenal { get; set; }
    }
}
