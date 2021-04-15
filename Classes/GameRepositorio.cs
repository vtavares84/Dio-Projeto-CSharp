using System.Collections.Generic;
using DIO.Projeto.Interface;
using System;
using System.Collections;

namespace DIO.Projeto
{
    public class GameRepositorio : IRepositorio<Game>
    {
        private List<Game> listaGame = new List<Game>();

        public void Atualiza(int id, Game entidade)
        {
            listaGame[id] = entidade;
        }

        public void Exlui(int id)
        {
            listaGame[id].Excluir();
        }

        public void Insere(Game entidade)
        {
            listaGame.Add(entidade);
        }

        public List<Game> Lista()
        {
            return listaGame;
        }

        public int ProximoId()
        {
            return listaGame.Count;
        }

        public Game RetornaPorId(int Id)
        {
            return listaGame[Id];
        }
    }

}