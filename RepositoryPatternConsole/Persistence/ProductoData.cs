using RepositoryPatternConsole.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternConsole.Persistence
{
    public static class ProductoData
    {
        public static readonly List<Producto> Productos = [
            new Producto(1, "Producto 1", 10.99m, 100),
            new Producto(2, "Producto 2", 20.99m, 50),
            new Producto(3, "Producto 3", 30.99m, 75),
            new Producto(4, "Producto 4", 40.99m, 25),
            new Producto(5, "Producto 5", 50.99m, 10)
        ];
    }
}
