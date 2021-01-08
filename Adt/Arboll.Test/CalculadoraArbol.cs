/*using System;
using Adt;


namespace Arboll.Test
{
    internal class CalculadoraArbol
    {
        public CalculadoraArbol()
        {
        }

        internal double Calcular(string expresionMatematica)
        {
            var raiz = new Nodo();
            CrearArbol(raiz, expresionMatematica);

            return Evaluar(raiz);  
            
        }

        private double Evaluar(Nodo nodo)
        {
            //toda funcion recurciva debe pensar en tres cosas
            //1) que debo hacer cuando el nodo actual es la raiz
            //2) que debo hacer cuando el nodo actual es una hoja
            if (EsNumero(nodo.Nombre))
            {
                return ConvertirEnNumero(nodo.Nombre);
            }
            //3)que debo hacer cuando el nodo actual no es ni hoja ni raiz

            var izquierdo = Evaluar(nodo.Izquierdo);
            var derecho = Evaluar(nodo.Derecho);

            if(nodo.Nombre == "+")
            {
                return izquierdo + derecho;
            }
            else
            {
                throw new ArgumentException("operador invalido");
            }
        }

        private double ConvertirEnNumero(string valor)
        {
            return Double.Parse(valor);
        }

        private bool EsNumero(string valor)
        {
            throw new NotImplementedException();
        }

        private void CrearArbol(Nodo nodo, string expresionMatematica)
        {
            var indiceOperador = BuscarOperador(expresionMatematica);
            var operandoIzquierdo = expresionMatematica.Substring(0, indiceOperador);

             nodo.Nombre = expresionMatematica[indiceOperador];
             nodo.Izquierdo = new Nodo(operandoIzquierdo);

            nodo.Derecho = new Nodo();
            CrearArbol(nodo.Derecho, expresionMatematica.Substring(indiceOperador));
               
        }

        private int BuscarOperador(string expresionMatematica)
        {
           var indiceMas = expresionMatematica.IndexOf('+');
            var indiceMenos = expresionMatematica.IndexOf('-');

            return indiceMas < indiceMenos? indiceMas:indiceMenos;
        }
        public int ContadorNodos(Nodo nodo)
        {
            return 0;
        }
        //cuantos nodos hay
        //cuantas hojas hay
        //cuantos niveles hay
    }
}*/