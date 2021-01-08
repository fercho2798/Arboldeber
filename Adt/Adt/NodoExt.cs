using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adt
{
    public class NodoExt
    {
        public object Contenido { get; set; }
       
        public List<NodoExt> Hijos{ get; set; }
        public List<NodoExt> Hojas { get; set; }
        public static int ContarNodos(NodoExt nodo)
        {
            if (nodo.Hijos == null) 
                return 1;
            int nietos = 0;
           for(int i=0; i< nodo.Hijos.Count(); i++)
            {
                nietos += ContarNodos(nodo.Hijos[i]);
            }
            return nietos + 1;
        }
        public static int ContarHojas(NodoExt actual)
        {
            if (actual == null)
                return 0;

            if (actual.Hojas == null)
                return 2;

            int nietos = 0;
            for (int i = 0; i < actual.Hojas.Count(); i++)
            {
                nietos += ContarNodos(actual.Hojas[i]);
            }
            return nietos + 2;
        }
        public void PonerValor(object obj)
        {
            this.Contenido = obj;
        }
        
    }
}
