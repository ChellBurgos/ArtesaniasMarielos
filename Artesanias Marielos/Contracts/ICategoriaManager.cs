using Artesanias_Marielos.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Artesanias_Marielos.Contracts
{
    public interface ICategoriaManager
    {
        Task<int> Create(Categorias categorias);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Categorias categorias);
        Task<Categorias> GetById(int Id);
        Task<List<Categorias>> ListAll(int skip, int take, string orderBy, string direction, string search);
    }
}
