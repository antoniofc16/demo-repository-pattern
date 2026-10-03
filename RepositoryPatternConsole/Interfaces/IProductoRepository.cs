using System;
using System.Collections.Generic;
using System.Text;
using RepositoryPatternConsole.Domains;

namespace RepositoryPatternConsole.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<Producto>> GetAll();
        Task<Producto> GetById(int id);
        Task<int> Add(Producto producto);
        Task Update(Producto producto);
        Task Delete(int id);
    }
}
