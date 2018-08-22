using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? Existencia { get; set; }
        public double Precio { get; set; }
        public List<Producto> Agregados = new List<Producto>();

        //Diferenciar entre productos que son agregados y los que no.
        public bool IsAgregado { get; set; }

        public Producto(string descripcion, int? existencia, double precio, bool isAgregado = false)
        {
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;

            IsAgregado = isAgregado;
        }

        public void AgregarAgregado(Producto agregado)
        {
            if (agregado.IsAgregado == true)
            {
                Agregados.Add(agregado);
            }
                
        }

        public void RemoverAgregado(Producto agregado)
        {
            if (agregado.IsAgregado == true)
            {
                Agregados.Remove(agregado);
            }
                
        }

        internal void RestarExistencia(int cantidad)
        {
            if (Existencia != null || Existencia > 0)
            {
                Existencia -= cantidad;
            }
        }
    }
}
