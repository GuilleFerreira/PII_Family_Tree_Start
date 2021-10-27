using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        private string nombre;
        private int edad;

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

        public Person(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}