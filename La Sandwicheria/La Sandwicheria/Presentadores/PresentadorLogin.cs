using La_Sandwicheria.Capa_Transversal;
using La_Sandwicheria.Datos.Base_de_Datos;
using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Presentadores
{
    class PresentadorLogin
    { 
        public PresentadorLogin()
        {
            //Instanciación de las sesiones
                DBSesiones.CargarDatos();
            //-----------------------------
        }

        public Cajero InicarSesion(string usuario, string contraseña)
        {
            foreach (var sesion in DBSesiones.Sesiones)
            {
                if(sesion.Usuario == usuario && sesion.Contraseña == contraseña)
                {
                    return sesion.Cajero;
                }
            }
            return null ;
        }
    }
}
