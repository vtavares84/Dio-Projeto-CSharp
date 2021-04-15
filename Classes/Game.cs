using System;

namespace DIO.Projeto
{
    public class Game : EntidadeBase
    {
        private Genero Genero{get;set;}
        private string Titulo {get;set;}
        private string Descricao {get;set;}
        private Consoles Consoles{get;set;}

        public Game(int id, Genero genero, string titulo, string descricao, Consoles consoles)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Consoles = consoles;
            this.Excluido = false;
        }

        public int retornaID()
        {
            return this.Id;
        }

        public string retornaTitulo()
        {
            return this.Descricao;
        }

        public void Excluir(){
            this.Excluido = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Console: " + this.Consoles + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    }
}