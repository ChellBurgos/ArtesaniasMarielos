using Artesanias_Marielos.Contracts;
using Artesanias_Marielos.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Artesanias_Marielos.Concrete
{
    public class CategoriaManager : ICategoriaManager
    {
        private readonly IDapperManager _dapperManager;

        public CategoriaManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Categorias categorias)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Categoria", categorias.Categoria, DbType.String);
            dbPara.Add("Estado", categorias.Estado, DbType.Boolean);
            var categoriaId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_InsertarCategorias]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return categoriaId;
        }

        public Task<Categorias> GetById(int id)
        {

            var categoria = Task.FromResult(_dapperManager.Get<Categorias>($"select IdCategoria, Categoria, Estado from [CatCategoria] where IdCategoria = {id}", null,
                    commandType: CommandType.Text));
            return categoria;
        }

        public Task<int> Delete(int id)
        {
            var deleteCategoria = Task.FromResult(_dapperManager.Execute($"Delete [CatCategoria] where IdCategoria = {id}", null,
                    commandType: CommandType.Text));
            return deleteCategoria;
        }

        public Task<int> Count(string search)
        {
            var totCategoria = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [CatCategoria] WHERE Categoria like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totCategoria;
        }

        public Task<List<Categorias>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var categoria = Task.FromResult(_dapperManager.GetAll<Categorias>
                ($"SELECT * FROM [CatCategoria] WHERE Categoria like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return categoria;
        }

        public Task<int> Update(Categorias categorias)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", categorias.IdCategoria);
            dbPara.Add("Categoria", categorias.Categoria, DbType.String);
            dbPara.Add("Estado", categorias.Estado, DbType.Boolean);
            var updateCategoria = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_ModificarCategorias]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateCategoria;
        }
    }
}
