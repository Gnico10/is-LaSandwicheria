using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Interfaces
{
    public interface ITerminarVenta
    {
        void CargarPtosDeVenta(List<PuntoDeVenta> ptosDeVenta);
        void CargarCliente(Cliente cliente);
        void CargarEmpresa(Empresa empresa);
    }
}
