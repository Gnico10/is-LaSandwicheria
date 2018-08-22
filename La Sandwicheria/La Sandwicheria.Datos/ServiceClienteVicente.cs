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
        //public LoginServiceClient client = new LoginServiceClient(Configuraciones.CodigoDeGrupo);
        //public Autorizacion autorizacion = new Autorizacion();
        public LoginServiceClient client { get; set; }
        public Autorizacion Autorizacion { get; set; }
        

        public void SolicitarAutorizacion()
        {
            using (client = new LoginServiceClient())
            {
                Autorizacion = client.SolicitarAutorizacion(Configuraciones.CodigoDeGrupo);
            }
        }


        public void CerrarClient()
        {
            client.Close();
        }
    }
}
