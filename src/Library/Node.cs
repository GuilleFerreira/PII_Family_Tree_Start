using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : IAcceptVisitor
    {
        private int number;

        private string nombre;

        private int edad;
        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public string Nombre {
            get
            {
                return this.nombre;
            }
        }

        public int Edad {
            get
            {
                return this.edad;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }


        public Node(int number)
        {
            this.number = number;
        }

        public Node(Person persona)
        {
            this.nombre = persona.Nombre;
            this.edad = persona.Edad;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
