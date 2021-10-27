using System;

namespace Library
{
    public class Edades : IVisitor
    {
        public int edadtotal;

        /// <summary>
        /// Visita a todos los hijos de el arbol genealógico y calcula la suma de todas las edades
        /// técnicamente dejaria de calcular si se agregan mas hijos
        /// pero no se como formularlo para que lo haga  ¯_(ツ)_/¯
        /// </summary>
        public void Visit(Node node)
        {
            foreach (Node hijos in node.Children)
            {
                edadtotal += hijos.Edad;
                if (hijos.Children != null)
                {
                    foreach (Node hijos2 in hijos.Children)
                    {
                        edadtotal += hijos2.Edad;
                        if (hijos2.Children != null)
                        {
                            foreach (Node hijos3 in hijos2.Children)
                            {
                                edadtotal += hijos3.Edad;
                            }
                        }
                    }
                }
            }
            edadtotal += node.Edad;

            Console.WriteLine($"Edad Total: {edadtotal}");
        }
    }
}