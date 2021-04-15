using System.Collections.Generic;

namespace DIO.Projeto.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int Id);
        void Insere(T entidade);
        void Exlui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}