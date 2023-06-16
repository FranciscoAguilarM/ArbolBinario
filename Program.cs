using System;

namespace ConsoleApp1
{
    internal class Program
    {
         class MainClass
        {
            static void Main(string[] args)
            {
                ArbolBinario arbol = new ArbolBinario();
                arbol.Insertar(6);
                arbol.Insertar(4);
                arbol.Insertar(7);
                arbol.Insertar(1);
                arbol.Insertar(5);
                arbol.Insertar(10);
                arbol.Insertar(14);
                arbol.Insertar(16);
                arbol.Insertar(21);
                arbol.Insertar(12);
                arbol.Insertar(3);
                arbol.Insertar(2);
                arbol.Insertar(11);
                arbol.Insertar(13);
      
                Console.WriteLine("La busqueda es:"+arbol.Buscar(21));
                Console.WriteLine("El nivel es:"+arbol.Nivel(21));
                Console.WriteLine("El grado es :" + arbol.Grado(21));

                Console.WriteLine("La busqueda es:" + arbol.Buscar(3));
                Console.WriteLine("El nivel es:" + arbol.Nivel(3));
                Console.WriteLine("El grado es :" + arbol.Grado(3));
                Console.WriteLine();
                arbol.RecorreCamino1(21);
                arbol.RecorreCamino1(14);
                Console.WriteLine();
                arbol.RecorreCamino2();
              
                Console.WriteLine("El peso del árbol es: " + arbol.PesoArbol());
                Console.WriteLine("La cantidad de nodos hoja en el árboles: " + arbol.ContNodosHoja());
            }
        }
    }
}
