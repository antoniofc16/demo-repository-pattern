using System;
using System.Collections.Generic;
using System.Text;
using RepositoryPatternConsole.Domains;
using RepositoryPatternConsole.Interfaces;
using RepositoryPatternConsole.Persistence;

namespace RepositoryPatternConsole.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        public async Task<List<Producto>> GetAll()
        {
            var result = ProductoData.Productos.OrderBy(p => p.Id).ToList();

            return await Task.FromResult(result);
        }

        public async Task<Producto> GetById(int id)
        {
            var result = ProductoData.Productos.FirstOrDefault(p => p.Id == id) ?? throw new KeyNotFoundException($"Producto de ID: {id} existe");

            return await Task.FromResult(result);
        }

        public async Task<int> Add(Producto producto)
        {
            producto.Id = ProductoData.Productos.Max(p => p.Id) + 1;

            ProductoData.Productos.Add(producto);

            return await Task.FromResult(producto.Id);
        }

        public async Task Update(Producto producto)
        {
            Producto existingProducto = ProductoData.Productos.FirstOrDefault(p => p.Id == producto.Id) ?? throw new KeyNotFoundException($"Producto de ID: {producto.Id} no existe");

            existingProducto.Nombre = producto.Nombre;
            existingProducto.Precio = producto.Precio;
            existingProducto.Stock = producto.Stock;

            await Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            Producto existingProducto = ProductoData.Productos.FirstOrDefault(p => p.Id == id) ?? throw new KeyNotFoundException($"Producto de ID: {id} no existe");

            ProductoData.Productos.Remove(existingProducto);

            await Task.CompletedTask;
        }
    }
}
