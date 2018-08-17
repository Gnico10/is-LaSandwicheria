using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public Rubro Rubro { get; set; }
        public List<Producto> _Agregados { get; set; }

        public bool IsAgregado { get; set; }

        public Producto(string descripcion, int existencia, Rubro rubro, bool isAgregado = false)
        {
            Descripcion = descripcion;
            Existencia = existencia;
            Rubro = rubro;

            IsAgregado = isAgregado;
        }

        public void AgregarAgregados(List<Producto> agregados)
        {
            foreach(Producto agregado in agregados)
            {
                if (agregado.IsAgregado == true) _Agregados.Add(agregado);
            }
        }
    }
}
