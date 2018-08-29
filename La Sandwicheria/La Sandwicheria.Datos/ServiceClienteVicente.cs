using La_Sandwicheria.Modelo.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Sandwicheria.Datos.org.dyndns.ds;

namespace La_Sandwicheria.Datos
{
    public class ServiceClienteVicente
    {
        public LoginService Client { get; set; }
        public Autorizacion Autorizacion { get; set; }
        

        public ServiceClienteVicente()
        {
            using (Client = new LoginService())
            {
                try
                {
                    Autorizacion = Client.SolicitarAutorizacion(Configuracion.CodigoDeGrupo);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                
            }
        }

        public void CerrarClient()
        {
            //Cerrar conexión
        }
    }
}
