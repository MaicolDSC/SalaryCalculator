using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_paso_6
{
    internal class Computronic
    {
        private int ventas; // Atributo

        public void leerVentas() //Metodos constructor
        {
            Console.WriteLine("Ingrese cuantas ventas realizo");
            ventas=int.Parse(Console.ReadLine());

            int i; // Variable acomulativa
            for(i = 1;i <= ventas; i++) 
            {
                int x;//variable
                Console.WriteLine("Ingrese el valor de la venta");
                x = int.Parse(Console.ReadLine());
                suma = suma + x;

                if (x <= 300000) 
                {
                    Console.WriteLine("Esta venta es menor o igual a $300000  ");
                }
                else if(x > 300000 && x < 800000) 
                {
                    Console.WriteLine("Esta venta es mayor a $300000 y menor a $800000");
                }
                else if(x >= 800000) 
                {
                    Console.WriteLine("Esta venta es mayor o igual a $800000");
                }

                //bonificacion

                if (x <= 400000) 
                {
                    menoresIguales400 = x * 3 / 100;
                    Console.WriteLine("Esta venta tiene una bonificacion de $"+ menoresIguales400);
                }
                else if(x > 400001 && x < 800000) 
                {
                    mayores401Menores800 = x * 5 / 100;
                    Console.WriteLine("Esta venta tiene una bonificacion de $"+mayores401Menores800);
                }
                else if (x > 800000) 
                {
                    mayoresIguales800 = x * 10 / 100;
                    Console.WriteLine("Esta venta tiene una bonificacion de $"+mayoresIguales800);
                }
            }
        }
        public int SueldoBase() //variable
        {
            int sueldoBase;
            sueldoBase= 500000;
            return sueldoBase;
        }
        int suma = 0;//variable

        public int totalVentas() 
        { 
            int totalVentas;
            totalVentas = suma;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("La suma total de las ventas es de $"+ totalVentas);
            return totalVentas;
        }
        double menoresIguales400 = 0; //variable
        double mayores401Menores800 = 0;//para realiazar la sumatoria de todas las bonificaciones
        double mayoresIguales800 = 0;

        public double pagoTotal() 
        {
            double pagoTotal; // las bonificaciones que se van a recibir + sueldo base
            pagoTotal = mayoresIguales800 + menoresIguales400 + mayores401Menores800 + 500000;
            return pagoTotal;
        }
        public double totalBonificacion() 
        {
            double totalBonificacion;
            totalBonificacion = mayoresIguales800 + menoresIguales400 + mayores401Menores800;
            return totalBonificacion;
        }
    }
}
