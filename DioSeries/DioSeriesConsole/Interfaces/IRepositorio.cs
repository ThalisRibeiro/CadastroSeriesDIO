using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioSeriesConsole.Interfaces
{
    public interface IRepositorio<T>
    {
        public List<T> Lista();
        public T RetornaId(int id);
        public void Insere(T entidade);
        public void Exclui(int id);
        public void Atualiza (int id, T entidade);
        public int ProximoId();
    }
}
