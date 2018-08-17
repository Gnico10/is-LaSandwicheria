using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class Cajero
    {
        public int Id { get; set; }
        public string NombreyApe { get; set;}
        public int Legajo { get; set; }
        public int sueldo { get; set; }
        public Turno TurnoActual { get; set; }
        public List<Turno> TurnosTermiandos { get; set; }

        //Cuenta del cajero
        private string Usuario { get; set; }
        private string Contraseña { get; set; }
        
    }
}
