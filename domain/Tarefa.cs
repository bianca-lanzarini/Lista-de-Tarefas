using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    class Tarefa
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime Prazo { get; private set; }
        public char Status { get; set; } // farei uma classe ENUM para representar os possíveis status da tarefa

        public Tarefa (string titulo, string descricao, DateTime prazo)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now.Date;
            Prazo = prazo;
            Status = 'P';
        }
    }
}
