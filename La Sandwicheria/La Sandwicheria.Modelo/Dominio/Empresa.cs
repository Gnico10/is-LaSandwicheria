using La_Sandwicheria.Modelo.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    //Patron Singleton
    public sealed class Empresa
    {
        public string Nombre { get; set; }

        public CondicionTributaria CondTributaria { get; set; }
        public TiposDocumentos TipoDocumento { get; set; }
        public long NroDocumento { get; set; }
        public List<PuntoDeVenta> PtosDeVenta = new List<PuntoDeVenta>();

        //Singleton
        private static Empresa EmpresaSingle = null;

        private Empresa() { }
        
        public static Empresa Intancia()
        {
            if (EmpresaSingle == null)
            {
                return EmpresaSingle = new Empresa();
            }else
            {
                return EmpresaSingle;
            }
        }

        public void AgregarPtosDeVenta(PuntoDeVenta ptoDeVenta)
        {
            PtosDeVenta.Add(ptoDeVenta);
        }

    }
}
