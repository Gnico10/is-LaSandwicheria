using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using La_Sandwicheria.Modelo.Dominio;

namespace TestLaSandwichería
{
    [TestClass]
    public class NuevaVentaTest
    {
        [TestMethod]
        public void Test1_VentaSimple()
        {
            /*************  Definición *************/

            var cajero = new Cajero("Santiago Martinez", 20-35624321-0, 00001, 50);
            var pedido = new Pedido(cajero);

            var rubroSand = new Rubro("Sandwiches");
            var rubroPizza = new Rubro("Pizzas");

            var pro1 = new Producto("Sandwiche de Milanesa", 30, 35.00);
            var pro2 = new Producto("Sandwiche de Lomito", 30, 30.00);

            rubroSand.AgregarAlRubro(pro1);
            rubroSand.AgregarAlRubro(pro2);

            var pro3 = new Producto("Pizza 4 quesos", 10, 40.00);

            rubroPizza.AgregarAlRubro(pro3);

            var linea1 = new LineaDePedido(rubroSand.ListaProductos[0]);
            var linea2 = new LineaDePedido(rubroPizza.ListaProductos[0]);

            /*************  Ejecución *************/

            pedido.AgregarLineaDeVenta(linea1);
            pedido.AgregarLineaDeVenta(linea2);

            /*************  Comprobación *************/

            Assert.AreEqual(pedido.Total, 75);
        }

        [TestMethod]
        public void Test2_VentaSimpleConCantidades()
        {
            /*************  Definición *************/

            var cajero = new Cajero("Santiago Martinez", 20 - 35624321 - 0, 00001, 50);
            var pedido = new Pedido(cajero);

            var rubroSand = new Rubro("Sandwiches");
            var rubroPizza = new Rubro("Pizzas");

            var pro1 = new Producto("Sandwiche de Milanesa", 30, 35.00);
            var pro2 = new Producto("Sandwiche de Lomito", 30, 30.00);

            rubroSand.AgregarAlRubro(pro1);
            rubroSand.AgregarAlRubro(pro2);

            var pro3 = new Producto("Pizza 4 quesos", 10, 40.00);

            rubroPizza.AgregarAlRubro(pro3);

            var linea1 = new LineaDePedido(rubroSand.ListaProductos[0]);
            var linea2 = new LineaDePedido(rubroSand.ListaProductos[1], 3);

            var linea3 = new LineaDePedido(rubroPizza.ListaProductos[0], 2);

            /*************  Ejecución *************/

            pedido.AgregarLineaDeVenta(linea1);
            pedido.AgregarLineaDeVenta(linea2);
            pedido.AgregarLineaDeVenta(linea3);

            /*************  Comprobación *************/

            Assert.AreEqual(pedido.Total, 205);
        }

        [TestMethod]
        public void Test3_VentaConAgregados()
        {
            /*************  Definición *************/

            var cajero = new Cajero("Santiago Martinez", 20 - 35624321 - 0, 00001, 50);
            var pedido = new Pedido(cajero);

            var rubroAgreg = new Rubro("Agregados");
            var rubroSand = new Rubro("Sandwiches");
            var rubroPizza = new Rubro("Pizzas");

            var Agreg1 = new Producto("Lechuga", null, 0, true);
            var Agreg2 = new Producto("Tomate", null, 0, true);
            var Agreg3 = new Producto("Huevo Frito", 30, 5, true);
            var Agreg4 = new Producto("Jamon", null, 5, true);
            var Agreg5 = new Producto("Aceituna", null, 10, true);

            rubroAgreg.AgregarAlRubro(Agreg1);
            rubroAgreg.AgregarAlRubro(Agreg2);
            rubroAgreg.AgregarAlRubro(Agreg3);
            rubroAgreg.AgregarAlRubro(Agreg4);
            rubroAgreg.AgregarAlRubro(Agreg5);

            var pro1 = new Producto("Sandwiche de Milanesa", 30, 35.00);
                pro1.AgregarAgregado(rubroAgreg.ListaProductos[0]);
                pro1.AgregarAgregado(rubroAgreg.ListaProductos[1]);

            var pro2 = new Producto("Sandwiche de Lomito", 30, 30.00);
                pro2.AgregarAgregado(rubroAgreg.ListaProductos[0]);
                pro2.AgregarAgregado(rubroAgreg.ListaProductos[1]);
                pro2.AgregarAgregado(rubroAgreg.ListaProductos[2]);

            rubroSand.AgregarAlRubro(pro1);
            rubroSand.AgregarAlRubro(pro2);

            var pro3 = new Producto("Pizza 4 quesos", 10, 40.00);
                pro3.AgregarAgregado(rubroAgreg.ListaProductos[3]);
                pro3.AgregarAgregado(rubroAgreg.ListaProductos[4]);

            rubroPizza.AgregarAlRubro(pro3);

            var linea1 = new LineaDePedido(rubroSand.ListaProductos[0]);
            var linea2 = new LineaDePedido(rubroSand.ListaProductos[1], 3);

            var linea3 = new LineaDePedido(rubroPizza.ListaProductos[0], 2);

            /*************  Ejecución *************/

            pedido.AgregarLineaDeVenta(linea1);
            pedido.AgregarLineaDeVenta(linea2);
            pedido.AgregarLineaDeVenta(linea3);

            /*************  Comprobación *************/

            Assert.AreEqual(pedido.Total, 250);
        }
    }
}
