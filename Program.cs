/*.
 * Problema 2: La empresa de tecnología “COMPUTRONIC”, es una empresa 
líder en venta y distribución de equipos tecnológicos en la ciudad de Bogotá 
y cuenta en su única sede con un N cantidad de empleados quienes realizan 
N ventas durante el día. La empresa requiere identificar cuántas de las ventas 
fueron menores o iguales a $300.000, cuántas ventas fueron mayores a $ 
300.000 y menores a $800.000 y cuántas fueron mayores o iguales a 
$800.000 por cada empleado.
También se necesita conocer monto total por la venta realizada por empleado 
y las bonificaciones a pagar según la venta realizada. Para el pago de la 
bonificación es necesario tener en cuenta la siguiente tabla:

Ventas superiores o iguales a $400.000 3%
Ventas entre $400.001 a $800.000 5%
Ventas superiores a $800.000 10%

Al finalizar el día, se debe calcular el valor a pagar por empleado, 
especificando: pago básico y el valor de la bonificación recibida. Tenga en 
cuenta que el pago básico para todos los empleados es de $500.000
Desarrolle una solución básica de programación que le permita a la empresa 
COMPUTRONIC conocer toda la información que es de su interés. Los valores 
para ingresar deben ser números positivos.

Nombre: Maicol David Siachoque Cubides
Grupo: 104
Programa: Ingenieria de sistemas
Codigo funte: Autoria propia

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_paso_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("                                  Bienvenido a COMPUTRONIC                                   ");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            //instanciar Objetos
            Computronic objComputronics;
            objComputronics = new Computronic();
            //intanciar metodos
            objComputronics.leerVentas();
            objComputronics.totalVentas();


            Console.WriteLine("El sueldo base es de $"+ objComputronics.SueldoBase());

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("El valor total de bonificaciones es de $"+ objComputronics.totalBonificacion());

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Total a pagar el empleado = sueldo base + bonificacion es de $"+objComputronics.pagoTotal());

            Console.ReadKey();

        }
    }
}
