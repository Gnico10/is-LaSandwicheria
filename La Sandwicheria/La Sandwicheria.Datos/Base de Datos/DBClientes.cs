using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public class DBClientes
    {
        public static List<Cliente> Clientes = new List<Cliente>();

        public static void GuardarCliete(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

    }
}
