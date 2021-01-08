﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adt
{
   public class Administrador
    {
        public void CrearArbol(Nodo nodo, string expresionMatematica)
        {
            if (expresionMatematica.Length == 1)
            {
                nodo.Nombre = expresionMatematica.Substring(0, 1);
            }
            else
            {
                int indiceOperador = BuscarOperador(expresionMatematica);
                Console.WriteLine("indice operador" + indiceOperador);
                var operandoIzquierdo = expresionMatematica.Substring(0, indiceOperador);
                Console.WriteLine("operando izquierdo" + operandoIzquierdo);
                nodo.Nombre = expresionMatematica.Substring(indiceOperador, 0);
                nodo.Izquierdo = new Nodo(operandoIzquierdo);

                nodo.Derecho = new Nodo();
                Console.WriteLine("indice operador mas " + expresionMatematica.Substring(indiceOperador + 1));

                CrearArbol(nodo.Derecho, expresionMatematica.Substring(indiceOperador + 1));
            }

        }
        private int BuscarOperador(string expresionMatematica)
        {

            char[] expresionMatematicaCh = expresionMatematica.ToCharArray();
            int iterador;
            int posicion = 0;
            for (iterador = 0; iterador < expresionMatematicaCh.Length; iterador++)
            {
                if (expresionMatematica[iterador] == '+' || expresionMatematica[iterador] == '-')
                {
                    posicion = iterador;
                    return posicion;
                }
            }
            return posicion;
        }
        public void Recorrer(Nodo nodo)
        {
            if (nodo == null)
                return;

            Console.WriteLine(nodo.Nombre);
            Recorrer(nodo.Izquierdo);
            Recorrer(nodo.Derecho);
        }
        public bool EsNumero(string nombre)
        {
            if (nombre != "+")
                return true;
            else
                return false;
        }
        public int Convertir(string numero)
        {
            return int.Parse(numero);
        }

        public int Sumar(Nodo nodo)
        {
            if (!EsNumero(nodo.Nombre) || nodo == null)
            {
                int izquierdo = Sumar(nodo.Derecho);
                int derecho = Sumar(nodo.Izquierdo);
                return (izquierdo + derecho);
            }
            else
            {
                return (Convertir(nodo.Nombre));
            }
        }
        public int Contador(Nodo nodo, int contador)
        {
            if (nodo == null)
                return 0;
            else
            {
                Console.WriteLine(nodo.Nombre);
                contador += 1;
                Contador(nodo.Izquierdo, contador);
                Contador(nodo.Derecho, contador);
                return contador;
            }

        }
        public int ContadorHojas(Nodo nodo)
        {

            return 0;
        }
        public int ContadorNiveles(Nodo nodo)
        {

            return 0;
        }
       
    
}
}