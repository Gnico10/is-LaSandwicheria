using La_Sandwicheria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Capa_Transversal
{
    public class Sesion
    {

        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Cajero Cajero { get; set; }

        public Sesion(string usuario, string contraseña, Cajero cajero)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Cajero = cajero;
        }

        public Cajero ObtenerCajero(string usuario, string contraseña)
        {
            if (usuario == Usuario && contraseña == Contraseña)
            {
                return Cajero;
            }

            return null;
        }

    }
}
