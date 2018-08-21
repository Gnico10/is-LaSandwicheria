using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Interfaces
{
    public interface IEditarAgregados
    {
        void ListarAgregados(List<Producto> Productos);
        void CargarAgregadosProducto(List<Producto> Productos);
    }
}
