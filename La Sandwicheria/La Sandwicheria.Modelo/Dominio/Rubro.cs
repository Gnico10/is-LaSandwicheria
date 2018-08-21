using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Rubro
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //Lista de Productos que pertenecen al rubro
        public List<Producto> ListaProductos = new List<Producto>();

        public Rubro(string descripcion)
        {
            Descripcion = descripcion;
        }

        public void AgregarAlRubro(Producto producto)
        {
            ListaProductos.Add(producto);
        }

        public void RemoverDelRubro(Producto producto)
        {
            ListaProductos.Remove(producto);
        }

    }
}
