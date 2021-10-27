using System;

namespace Library
{
    public class NombreLargo : IVisitor
    {
        public string nombrelargo = "";

        /// <summary>
        /// Visita a todos los hijos de el arbol genealógico y calcula la suma de todas las edades
        /// técnicamente dejaria de calcular si se agregan mas hijos
        /// pero no se como formularlo para que lo haga  ¯_(ツ)_/¯
        /// </summary>
        public void Visit(Node node)
        {
            foreach (Node hijos in node.Children)
            {
                if (hijos.Nombre.Length > nombrelargo.Length)
                {
                    nombrelargo = hijos.Nombre;
                }
                if (hijos.Children != null)
                {
                    foreach (Node hijos2 in hijos.Children)
                    {
                        if (hijos2.Nombre.Length > nombrelargo.Length)
                        {
                            nombrelargo = hijos2.Nombre;
                        }
                        if (hijos2.Children != null)
                        {
                            foreach (Node hijos3 in hijos2.Children)
                            {
                                if (hijos3.Nombre.Length > nombrelargo.Length)
                                {
                                    nombrelargo = hijos3.Nombre;
                                }
                            }
                        }
                    }
                }
            }
            if (node.Nombre.Length > nombrelargo.Length)
            {
                nombrelargo = node.Nombre;
            }

            Console.WriteLine($"El nombre mas largo es: {nombrelargo}");
        }
    }
}