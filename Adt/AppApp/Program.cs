using Adt;
using System;

namespace AppApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var raiz = new Nodo("*",
               new Nodo("1",
                   new Nodo("10",
                       new Nodo("100"),
                       new Nodo("101")),
                   new Nodo("11",
                       new Nodo("110"),
                       new Nodo("111"))),
               new Nodo("2",
                   new Nodo("21",
                       new Nodo("200"),
                       new Nodo("201")),
                   new Nodo("21",
                       new Nodo("210"),
                       new Nodo("211"))));


            Administrador admin = new Administrador();

            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            Console.WriteLine("La suma del arbol es: " + admin.Sumar(arbolOperaciones));
            Console.WriteLine("\n");

            Nodo nodoOperacion = new Nodo();
            admin.CrearArbol(nodoOperacion, "5+6+2+1");
            admin.Recorrer(nodoOperacion);

            int contador = 0;
            Console.WriteLine("El número de nodos es: " + admin.Contador(arbolOperaciones, contador));

        }
    }
}
