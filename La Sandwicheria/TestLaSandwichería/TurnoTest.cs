using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using La_Sandwicheria.Modelo.Dominio;

namespace TestLaSandwichería
{
    [TestClass]
    public class TurnoTest
    {
        [TestMethod]
        public void Test4_TurnoConVentas()
        {
            /*************  Definición *************/

            var cajero = new Cajero("Santiago Martinez", 20 - 35624321 - 0, 00001, 50);
            var turno = new Turno(cajero);

            var pedido1 = new Pedido(cajero);
            var pedido2 = new Pedido(cajero);

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

            pedido1.AgregarLineaDeVenta(linea1);
            pedido1.AgregarLineaDeVenta(linea2);
            pedido1.AgregarLineaDeVenta(linea3);

            turno.AgregarVenta(pedido1);

            /*************  Comprobación *************/

            Assert.AreEqual(turno.Rendicion, 250);
            Assert.AreEqual(turno._Estado, Estados.Abierto);
        }

        [TestMethod]
        public void Test5_TurnoConVariasVentasYCerrado()
        {
            /*************  Definición *************/

            var cajero = new Cajero("Santiago Martinez", 20 - 35624321 - 0, 00001, 50);
            var turno = new Turno(cajero);

            var pedido1 = new Pedido(cajero);
            var pedido2 = new Pedido(cajero);

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
            var linea3 = new LineaDePedido(rubroSand.ListaProductos[1], 2);

            var linea4 = new LineaDePedido(rubroPizza.ListaProductos[0]);
            var linea5 = new LineaDePedido(rubroPizza.ListaProductos[0], 2);

            /*************  Ejecución *************/

            pedido1.AgregarLineaDeVenta(linea1);
            pedido1.AgregarLineaDeVenta(linea2);
            pedido1.AgregarLineaDeVenta(linea5);

            turno.AgregarVenta(pedido1);

            pedido2.AgregarLineaDeVenta(linea2);
            pedido2.AgregarLineaDeVenta(linea3);
            pedido2.AgregarLineaDeVenta(linea5);

            turno.AgregarVenta(pedido2);

            turno.CerrarTurno();

            /*************  Comprobación *************/

            Assert.AreEqual(turno.Rendicion, 535);
            Assert.AreEqual(turno._Estado, Estados.Cerrado);
        }

    }
}
