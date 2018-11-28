using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Interfaces
{
    public interface ILineaDeVenta
    {
        void CargarRubros(List<Rubro> Rubros);
        void CargarProductos(List<Producto> Productos);
        void ColocarLineaDeVenta(LineaDePedido LineadeVenta);
    }
}
