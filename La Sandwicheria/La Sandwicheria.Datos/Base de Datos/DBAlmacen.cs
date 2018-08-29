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
        public readonly static List<Rubro> Rubros = new List<Rubro>();

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

            CargarProductos(); 
        }

        public static void CargarProductos()
        {
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

            //Intanciacion de Productos, add agregados.
            var Pro1 = new Producto("Sandwiche de Milanesa", 30, 35.00);
            Pro1.AgregarAgregado(Agreg1);
            Pro1.AgregarAgregado(Agreg2);
            Pro1.AgregarAgregado(Agreg7);

            var Pro2 = new Producto("Sandwiche de Lomito", 30, 30.00);
            Pro2.AgregarAgregado(Agreg1);
            Pro2.AgregarAgregado(Agreg2);
            Pro2.AgregarAgregado(Agreg7);

            
            var Pro3 = new Producto("Pizza 4 quesos", 10, 40.00);
            var Pro4 = new Producto("Pizza fugazzeta", 10, 42.00);
            var Pro5 = new Producto("Pizza calabresa", 10, 43.00);

            

            var Pro6 = new Producto("Ensalada de tomate y lechuga - Pequeña", 30, 15.00);
            var Pro7 = new Producto("Ensalada de tomate y lechuga - Mediana", 30, 20.00);
            var Pro8 = new Producto("Ensalada de papa y huevo - Pequeña", 30, 15.00);
            var Pro9 = new Producto("Ensalada de paa y huevo - Mediana", 30, 20.00);


            var Pro10 = new Producto("Coca-Cola 2.25L", 25, 40.00);
            var Pro11 = new Producto("Coca-Cola 3L", 25, 60.00);
            var Pro12 = new Producto("Pepsi 2.25L", 25, 38.00);
            var Pro13 = new Producto("Pepsi 3L", 25, 67.00);

            

            foreach (var rubro in Rubros)
            {
                rubro.ListaProductos = new List<Producto>();

                switch (rubro.Descripcion)
                {
                    case "Sandwiches":
                        rubro.AgregarAlRubro(Pro1);
                        rubro.AgregarAlRubro(Pro2);
                        break;

                    case "Pizzas":
                        rubro.AgregarAlRubro(Pro3);
                        rubro.AgregarAlRubro(Pro4);
                        rubro.AgregarAlRubro(Pro5);
                        break;

                    case "Ensaladas":
                        rubro.AgregarAlRubro(Pro6);
                        rubro.AgregarAlRubro(Pro7);
                        rubro.AgregarAlRubro(Pro8);
                        rubro.AgregarAlRubro(Pro9);
                        break;

                    case "Bebidas":
                        rubro.AgregarAlRubro(Pro10);
                        rubro.AgregarAlRubro(Pro11);
                        rubro.AgregarAlRubro(Pro12);
                        rubro.AgregarAlRubro(Pro13);
                        break;

                    case "Agregados":
                        rubro.AgregarAlRubro(Agreg1);
                        rubro.AgregarAlRubro(Agreg2);
                        rubro.AgregarAlRubro(Agreg3);
                        rubro.AgregarAlRubro(Agreg4);
                        rubro.AgregarAlRubro(Agreg5);
                        rubro.AgregarAlRubro(Agreg6);
                        rubro.AgregarAlRubro(Agreg7);
                        rubro.AgregarAlRubro(Agreg8);
                        rubro.AgregarAlRubro(Agreg9);
                        break;

                    default:
                        Console.WriteLine("Rubro no encontrado");
                        break;
                }



            }

        }
    }
}
