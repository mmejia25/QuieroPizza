using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var productosBL = new ProductosBL();
            var ListadeProductos = productosBL.Obtener();

            foreach (var producto in ListadeProductos)
            {
               Console.WriteLine(producto.Descripcion);
                Console.ReadLine();
            }
        }
    }
}
