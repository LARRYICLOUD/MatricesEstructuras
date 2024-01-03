using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesEstructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            /*Creamos una matriz para que almacene multiples instancias de la estructura
            Producto[] televisores = new Producto[3];

            //Creamos las instancias de las estructuras
            televisores[0] = new Producto();
            televisores[1] = new Producto();
            televisores[2] = new Producto();

            //Dandole valor a los campos de la instancia 0
            televisores[0].Nombre = "LG 4k";
            televisores[1].Precio = 2500000;
            televisores[2].Descripcion = "Televisor de alta resolucion de 55 pulgadas";*/

            //Creamos una matriz para que almacene multiples instancias de la estructura
            Producto[] televisores = new Producto[3]
            { 
            //Creamos las instancias de la estructura usando un inicializador de objetos
              new Producto { Nombre = "LG 8K", Precio = 3000000.2, Descripcion = "alta resolucion" },
            new Producto { Nombre = "Sony", Precio = 5000000, Descripcion = "sonido envolvente 80 pulgadas" },
             new Producto { Nombre = "Samsung", Precio = 7500000, Descripcion = "100 pulgadas 8k plano" }
            };

            //Mostramos la informacion de los elementos de la matriz
            foreach (Producto elemento in televisores)
            {
                //Accede a las propiedades de cada instancia de producto
                Console.WriteLine($"Nombre: {elemento.Nombre}\nPrecio: {elemento.Precio}\nDescripcion: {elemento.Descripcion}\n");
            }
        }

    }

    struct Producto
    {
        //Campos
        string nombre;
        double precio;
        string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }



    }
}
