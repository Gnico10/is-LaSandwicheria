using La_Sandwicheria.Capa_Transversal;
using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public class DBSesiones
    {
        public readonly static List<Cajero> Cajeros= new List<Cajero>();
        public readonly static List<Sesion> Sesiones = new List<Sesion>();


        public static void CargarDatos()
        {
            //Intanciacion de Cajeros
            var cajero1 = new Cajero("Eduardo Santana", 27378654568, 00001, 1000.00);
            var cajero2 = new Cajero("Santiago Molina", 28441345659, 00002, 2200.00);

            Cajeros.Add(cajero1);
            Cajeros.Add(cajero2);

            //Sesiones de los cajeros
            var SesionEdu = new Sesion("EduSan", "1234", cajero1);
            var SesionSan = new Sesion("SanMoli", "12345", cajero2);

            Sesiones.Add(SesionEdu);
            Sesiones.Add(SesionSan);
            //-------------------------------------

        }
    }
}
