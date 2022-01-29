using System.Collections.Generic;

    namespace projeto_series
    {
    public interface iRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id,T entidade);
        int ProximoId();
    }
    }

