using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adt;
using System.Collections.Generic;

namespace Arboll.Test
{
    [TestClass]
    public class ArbollTest
    {
        [TestMethod]
        public void Suma()
        {
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            var admin = new Administrador();
            var resultadoEsperado = 8;

            var resultado = admin.SumarArbol(arbolOperaciones);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ContarNodos()
        {
            NodoExt nodo = new NodoExt();
            int resultadoEsperado = 1;
            int resultado = NodoExt.ContarNodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ContarNodosSiNuloRetorno0()
        {
            NodoExt nodo = null;

            int resultadoEsperado = 0;
            int resultado = NodoExt.ContarNodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ContarNodosConHijos()
        {
            NodoExt nodo = new NodoExt();

            nodo.Hijos = new List<NodoExt>();
            nodo.Hijos.Add(new NodoExt());

            int resultadoEsperado = 2;
            int resultado = NodoExt.ContarNodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        public void ContarNodosConHojas()
        {
            NodoExt nodo = new NodoExt();

            nodo.Hojas = new List<NodoExt>();
            nodo.Hojas.Add(new NodoExt());

            int resultadoEsperado = 2;
            int resultado = NodoExt.ContarHojas(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
