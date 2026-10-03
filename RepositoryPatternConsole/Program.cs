
using RepositoryPatternConsole.Domains;
using RepositoryPatternConsole.Interfaces;
using RepositoryPatternConsole.Repositories;

IProductoRepository productoRepository = new ProductoRepository();

Console.WriteLine("Demostracion de entregable: Repository Pattern");
Console.WriteLine("==============================================================================================");
Console.WriteLine(string.Empty);

var productos = await productoRepository.GetAll();

foreach (var producto in productos)
{
    Console.WriteLine(producto.ToString());
}
Console.WriteLine("--------------------------------------------------------------------------------------------------");
Console.WriteLine(string.Empty);

Producto newProducto = new Producto(0, "Producto 4", 40.0m, 400);
int newProductId = await productoRepository.Add(newProducto);
newProducto = await productoRepository.GetById(newProductId);

Console.WriteLine("Producto agregado:");
Console.WriteLine(newProducto.ToString());
Console.WriteLine(string.Empty);

Producto updatedProducto = new Producto(2, "Producto 2 Actualizado", 25.0m, 250);
await productoRepository.Update(updatedProducto);
updatedProducto = await productoRepository.GetById(updatedProducto.Id);

Console.WriteLine("Producto actualizado:");
Console.WriteLine(updatedProducto.ToString());
Console.WriteLine(string.Empty);

Producto deletedProducto = new Producto(3, "Producto 3", 30.0m, 300);
await productoRepository.Delete(deletedProducto.Id);

Console.WriteLine($"ID Producto eliminado: {deletedProducto.Id}");
Console.WriteLine(string.Empty);

Console.WriteLine("--------------------------------------------------------------------------------------------------");
productos = await productoRepository.GetAll();

foreach (var producto in productos)
{
    Console.WriteLine(producto.ToString());
}