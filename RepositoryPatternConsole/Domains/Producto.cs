using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternConsole.Domains
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Producto(int id, string nombre, decimal precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Producto: {Nombre}, Precio: {Precio}, Stock: {Stock}";
        }
    }
}
