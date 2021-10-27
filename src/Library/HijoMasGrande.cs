using System;

namespace Library
{
    public class HijoMasGrande : IVisitor
    {
        public string hijo = "";
        public int edadminima = 0;

        /// <summary>
        /// Visita a todos los hijos de el arbol genealógico y calcula la suma de todas las edades
        /// técnicamente dejaria de calcular si se agregan mas hijos
        /// pero no se como formularlo para que lo haga  ¯_(ツ)_/¯
        /// </summary>
        public void Visit(Node node)
        {
            foreach (Node hijos in node.Children)
            {
                if (hijos.Edad > edadminima)
                {
                    hijo = hijos.Nombre;
                    edadminima = hijos.Edad;
                }
                
            }

            Console.WriteLine($"El hijo mas grande es es: {hijo} edad {edadminima}");
        }
    }
}