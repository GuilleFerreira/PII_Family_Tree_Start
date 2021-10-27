using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //PARTE 2 (CREAR ESTRUCTURA DE ÁRBOL GENEALÓGICO)
            Person uno = new Person("Gaston",78);
            Person dos =  new Person("Pepe",57);
            Person tres =  new Person("Maria",56);
            Person cuatro =  new Person("Jose",34);
            Person cinco =  new Person("Josefina",35);
            Person seis =  new Person("Gaspar",30);
            Person siete = new Person("Pedro",12);
            Person ocho = new Person("Matias",8);

            Node Gaston = new Node(uno);
            Node Pepe = new Node(dos);
            Node Maria = new Node(tres);
            Node Jose = new Node(cuatro);
            Node Josefina = new Node(cinco);
            Node Gaspar = new Node(seis);
            Node Pedro = new Node(siete);
            Node Matias = new Node(ocho);

            //ABUELO
            Gaston.AddChildren(Pepe);
            Gaston.AddChildren(Maria);

            //HIJOS
            Maria.AddChildren(Josefina);
            Pepe.AddChildren(Jose);
            Pepe.AddChildren(Gaspar);

            //NIETOS
            Josefina.AddChildren(Pedro);
            Jose.AddChildren(Matias);

            //Parte 3 (VISITADOR DE EDADES)
            var edades = new Edades();
            Gaston.Accept(edades);

            //Parte 4 (VISITADOR DE HIJO MAS GRANDE)
            var hijomasgrande = new HijoMasGrande();
            Gaston.Accept(hijomasgrande);

            //Parte 4 (VISITADOR DE NOMBRE MAS LARGO)
            var nombrelargo = new NombreLargo();
            Gaston.Accept(nombrelargo);
        }
    }
}
