using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public static class DBAlmacen
    {
        public static List<Producto> Productos = new List<Producto>();
        public static List<Rubro> Rubros = new List<Rubro>();

        public static void IntanciarRubrosProductos()
        {
            //Intanciacion de Rubros
            var rubroSand = new Rubro("Sandwiches");
            var rubroPizza = new Rubro("Pizzas");
            var rubroEnsa = new Rubro("Ensaladas");
            var rubroBebi = new Rubro("Bebidas");
            var rubroAgreg = new Rubro("Agregados");

            Rubros.Add(rubroSand);
            Rubros.Add(rubroPizza);
            Rubros.Add(rubroEnsa);
            Rubros.Add(rubroBebi);
            Rubros.Add(rubroAgreg);

            //Intanciacion de Productos agregados.
            var Agreg1 = new Producto("Lechuga", null, 0, true);
            var Agreg2 = new Producto("Tomate", null, 0, true);
            var Agreg3 = new Producto("Huevo Frito", 30, 5, true);
            var Agreg4 = new Producto("Jamon", null, 5, true);
            var Agreg5 = new Producto("Papas fritas", null, 10, true);
            var Agreg6 = new Producto("Queso Cheddar", null, 5, true);
            var Agreg7 = new Producto("Mayonesa", null, 2, true);
            var Agreg8 = new Producto("Mostaza", null, 2, true);
            var Agreg9 = new Producto("Ketchup", null, 2, true);

            rubroAgreg.AgregarAlRubro(Agreg1);
            rubroAgreg.AgregarAlRubro(Agreg2);
            rubroAgreg.AgregarAlRubro(Agreg3);
            rubroAgreg.AgregarAlRubro(Agreg4);
            rubroAgreg.AgregarAlRubro(Agreg5);
            rubroAgreg.AgregarAlRubro(Agreg6);
            rubroAgreg.AgregarAlRubro(Agreg7);
            rubroAgreg.AgregarAlRubro(Agreg8);
            rubroAgreg.AgregarAlRubro(Agreg9);

            //Intanciacion de Productos, add agregados y add en rubro.
            var Pro1 = new Producto("Sandwiche de Milanesa", 30, 35.00);
            Pro1.AgregarAgregado(Agreg1);
            Pro1.AgregarAgregado(Agreg2);
            Pro1.AgregarAgregado(Agreg7);

            var Pro2 = new Producto("Sandwiche de Lomito", 30, 30.00);
            Pro2.AgregarAgregado(Agreg1);
            Pro2.AgregarAgregado(Agreg2);
            Pro2.AgregarAgregado(Agreg7);

            rubroSand.AgregarAlRubro(Pro1);
            rubroSand.AgregarAlRubro(Pro2);


            var Pro3 = new Producto("Pizza 4 quesos", 10, 40.00);
            var Pro4 = new Producto("Pizza fugazzeta", 10, 42.00);
            var Pro5 = new Producto("Pizza calabresa", 10, 43.00);

            rubroPizza.AgregarAlRubro(Pro3);
            rubroPizza.AgregarAlRubro(Pro4);
            rubroPizza.AgregarAlRubro(Pro5);

            var Pro6 = new Producto("Ensalada de tomate y lechuga - Pequeña", 30, 15.00);
            var Pro7 = new Producto("Ensalada de tomate y lechuga - Mediana", 30, 20.00);
            var Pro8 = new Producto("Ensalada de papa y huevo - Pequeña", 30, 15.00);
            var Pro9 = new Producto("Ensalada de paa y huevo - Mediana", 30, 20.00);

            rubroEnsa.AgregarAlRubro(Pro6);
            rubroEnsa.AgregarAlRubro(Pro7);
            rubroEnsa.AgregarAlRubro(Pro8);
            rubroEnsa.AgregarAlRubro(Pro9);


            var Pro10 = new Producto("Coca-Cola 2.25L", 25, 40.00);
            var Pro11 = new Producto("Coca-Cola 3L", 25, 60.00);
            var Pro12 = new Producto("Pepsi 2.25L", 25, 38.00);
            var Pro13 = new Producto("Pepsi 3L", 25, 67.00);

            rubroBebi.AgregarAlRubro(Pro10);
            rubroBebi.AgregarAlRubro(Pro11);
            rubroBebi.AgregarAlRubro(Pro12);
            rubroBebi.AgregarAlRubro(Pro13);

            Productos.Add(Pro1);
            Productos.Add(Pro2);
            Productos.Add(Pro3);
            Productos.Add(Pro4);
            Productos.Add(Pro5);
            Productos.Add(Pro6);
            Productos.Add(Pro7);
            Productos.Add(Pro8);
            Productos.Add(Pro9);
            Productos.Add(Pro10);
            Productos.Add(Pro11);
            Productos.Add(Pro12);
            Productos.Add(Pro13);
            
        }
    }
}
