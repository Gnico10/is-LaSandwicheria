using La_Sandwicheria.Capa_Transversal;
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

        //DB poco convencional.
        public List<Sesion> _sesiones = new List<Sesion>();

        public PresentadorLogin()
        {

            //Intanciacion de Cajeros
            var cajero1 = new Cajero("Eduardo Santana", 00001, 1000.00);
            var cajero2 = new Cajero("Santiago Molina", 00002, 2200.00);
            //Sesione s de los cajeros
            var SesionEdu = new Sesion("EduSan", "1234", cajero1);
            var SesionSan = new Sesion("SanMoli", "12345", cajero2);

            _sesiones.Add(SesionEdu);
            _sesiones.Add(SesionSan);
            //-------------------------------------
        }

        public Cajero InicarSesion(string usuario, string contraseña)
        {
            foreach (var sesion in _sesiones)
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
