using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10.*/

            int art, cant, maxV = 0, posMax = 0;
            int [] articulos = new int [15];

            Console.WriteLine("Ingrese el numero de articulo:");
            art = int.Parse(Console.ReadLine());

            while(art != 0){
                Console.WriteLine("Ingrese la cantidad vendida:");
                cant = int.Parse(Console.ReadLine());
                articulos[art - 1] += cant;
                Console.WriteLine("Ingrese el numero de articulo:");
                art = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 15; i++)
            {
                if(i == 0)
                {
                    maxV = articulos[i];
                    posMax = i + 1;
                }
                if(articulos[i] > maxV){
                    maxV = articulos[i];
                    posMax = i + 1;
                }
            }

            Console.WriteLine("El articulo que mas se vendio es el: " + posMax + " con " + maxV + " ventas");

            for (int x = 0; x < 15; x++)
            {
                if(articulos[x] == 0){
                    Console.WriteLine("El articulo " + (x+1) + " no ha registrado ventas");
                }
            }

            Console.WriteLine("El articulo numero 10, registró " + articulos[9] + " ventas");
        }
    }
}
