using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public interface IBaseRepositorio<T>
    {
        T Cadastrar(T input);
        List<T> BuscarTodos();
        T BuscarPorId(string id);
        bool Delete(string id);
        T Update(string id, T input);
    }
}
