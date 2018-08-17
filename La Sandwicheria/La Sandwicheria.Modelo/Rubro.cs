using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class Rubro
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Rubro(string descripcion)
        {
            Descripcion = descripcion;
        }

    }
}
