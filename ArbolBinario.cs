using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArbolBinario
    {
        public Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
            }
            else
            {
                InsertarEnSubarbol(raiz, valor);
            }
        }

        private void InsertarEnSubarbol(Nodo nodo, int valor)
        {
            if (valor < nodo.Valor)
            {
                if (nodo.NodoIzquierdo == null)
                {
                    nodo.NodoIzquierdo = new Nodo(valor);
                }
                else
                {
                    InsertarEnSubarbol(nodo.NodoIzquierdo, valor);
                }
            }
            else
            {
                if (nodo.NodoDerecho == null)
                {
                    nodo.NodoDerecho = new Nodo(valor);
                }
                else
                {
                    InsertarEnSubarbol(nodo.NodoDerecho, valor);
                }
            }
        }

        public bool Buscar(int valor)
        {
            return BuscarEnSubarbol(raiz, valor);


            bool BuscarEnSubarbol(Nodo nodo, int valor)
            {
                if (nodo == null)
                {
                    return false;
                }
                if (valor == nodo.Valor)
                {
                    return true;
                }
                if (valor < nodo.Valor)
                {
                    return BuscarEnSubarbol(nodo.NodoIzquierdo, valor);
                }
                else
                {
                    return BuscarEnSubarbol(nodo.NodoDerecho, valor);
                }
            }
        }

        public int Nivel(int valor)
        {
            return NivelEnSubarbol(raiz, valor, 1);


            int NivelEnSubarbol(Nodo nodo, int valor, int nivelActual)
            {
                if (nodo == null)
                {
                    return -1;
                }
                if (valor == nodo.Valor)
                {
                    return nivelActual;
                }
                if (valor < nodo.Valor)
                {
                    return NivelEnSubarbol(nodo.NodoIzquierdo, valor, nivelActual + 1);
                }
                else
                {
                    return NivelEnSubarbol(nodo.NodoDerecho, valor, nivelActual + 1);
                }
            }
        }
        public int Grado(int valor)
        {
            return GradoEnSubarbol(raiz, valor, 0);

            int GradoEnSubarbol(Nodo nodo, int valor, int nivelActual)
            {
                if (nodo == null)
                {
                    return -1;
                }
                if (valor == nodo.Valor)
                {
                    return nivelActual;
                }
                if (valor < nodo.Valor)
                {
                    return GradoEnSubarbol(nodo.NodoIzquierdo, valor, nivelActual + 1);
                }
                else
                {
                    return GradoEnSubarbol(nodo.NodoDerecho, valor, nivelActual + 1);
                }
            }
        }
        public void RecorreCamino1(int valor)
        {
            RecorreCaminoEnSubarbol1(raiz, "", valor);


            void RecorreCaminoEnSubarbol1(Nodo nodo, string caminoActual, int valorSel)
            {
                if (nodo == null)
                {
                    return;
                }
                caminoActual += nodo.Valor.ToString() + " ";
                if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null && nodo.Valor == valorSel)
                {
                    Console.WriteLine(caminoActual);
                }
                RecorreCaminoEnSubarbol1(nodo.NodoIzquierdo, caminoActual, valorSel);
                RecorreCaminoEnSubarbol1(nodo.NodoDerecho, caminoActual, valorSel);
            }
        }
        public void RecorreCamino2()
        {
            RecorreCaminoEnSubarbol2(raiz, "");

            void RecorreCaminoEnSubarbol2(Nodo nodo, string caminoActual)
            {
                if (nodo == null)
                {
                    return;
                }
                caminoActual += nodo.Valor.ToString() + " ";
                if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null)
                {
                    Console.WriteLine(caminoActual);
                }
                RecorreCaminoEnSubarbol2(nodo.NodoIzquierdo, caminoActual);
                RecorreCaminoEnSubarbol2(nodo.NodoDerecho, caminoActual);
            }
        }

        public int PesoArbol()
        {
            return ContarNodos(raiz);

            int ContarNodos(Nodo nodo)
            {
                if (nodo == null)
                    return 0;
                else
                    return 1 + ContarNodos(nodo.NodoIzquierdo) + ContarNodos(nodo.NodoDerecho);

            }
        }

        public int ContNodosHoja()
        {
            return ContarHoja(raiz);

            int ContarHoja(Nodo nodo)
            {
                if (nodo == null)
                { return 0; }

                else if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null)
                { return 1; }
                else
                { return ContarHoja(nodo.NodoIzquierdo) + ContarHoja(nodo.NodoIzquierdo) + 1; }
            }

        }
        /* public bool simeetriaarbol()
         {
             return EsSimetrico(raiz);

         bool EsSimetrico(Nodo nodo)
             {
                 if (nodo == null)
                     return true;

                 int sumaIzquierda = EsSimetrico(nodo.NodoIzquierdo);
                 int sumaDerecha = EsSimetrico(nodo.NodoIzquierdo);

                 return sumaIzquierda == sumaDerecha;

             }
         }*/
      /*  public string ObtenerPosicionNodo(arbolnodo nodo)
        {
            if (nodo == null)
                return "El nodo no pertenece al árbol.";

            return ObtenerPosicionNodo(root, nodo);
        }

        private string ObtenerPosicionNodo(TreeNode raiz, TreeNode nodo)
        {
            if (raiz == null)
                return "El nodo no pertenece al árbol.";

            if (raiz.left == nodo)
                return "El nodo es hijo izquierdo.";

            if (raiz.right == nodo)
                return "El nodo es hijo derecho.";

            string posicionIzquierda = ObtenerPosicionNodo(raiz.left, nodo);
            if (posicionIzquierda != "El nodo no pertenece al árbol.")
                return posicionIzquierda;

            string posicionDerecha = ObtenerPosicionNodo(raiz.right, nodo);
            if (posicionDerecha != "El nodo no pertenece al árbol.")
                return posicionDerecha;

            return "El nodo no pertenece al árbol.";
        }*/
    }
}
   
    










