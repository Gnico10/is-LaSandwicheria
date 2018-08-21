using La_Sandwicheria.Capa_Transversal.Configuraciones;
using La_Sandwicheria.Datos.ServiceReferenceVicente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos
{
    public class ServiceClienteVicente
    {
        public LoginServiceClient client = new LoginServiceClient(Configuraciones.CodigoDeGrupo);
        public Autorizacion autorizacion = new Autorizacion();

        public void CerrarClient()
        {
            client.Close();
        }
    }
}
