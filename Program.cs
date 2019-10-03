using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasCorrientes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada cuenta
                corriente se conoce: número de cuenta y saldo actual. 

                El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
                Se pide realizar un programa que lea los datos de las cuentas corrientes e informe:

                    a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
                        Estado de la cuenta:  
                            'Acreedor' si el saldo es > 0.
                            'Deudor' si el saldo es < 0.
                            'Nulo' si el saldo es = 0.
                    c) La suma total de los saldos acreedores.*/

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("             Cuentas Corrientes               ");
            Console.WriteLine("");

            int Cuenta = 0;
            double SaldoActual = 0, SaldoAcredor = 0, SaldoDeudor = 0;
            string Estado = "", Eleccion ="";
            do {
                Console.Write("\nNumero de Cuenta: ");
                Cuenta = int.Parse(Console.ReadLine());
                Console.Write("\nSaldo: ");
                SaldoActual = double.Parse(Console.ReadLine());
            
                if (SaldoActual >= 0)
                {
                    do
                    {
                        if (SaldoActual > 0)
                            SaldoAcredor += SaldoActual;
                        Console.Write("Saldo: ");
                        SaldoActual = int.Parse(Console.ReadLine());
                        if (SaldoActual < 0)
                            SaldoDeudor -= SaldoActual;
                    } while (SaldoActual >= 0);
                }
                SaldoActual = SaldoAcredor - SaldoDeudor;
                Console.WriteLine("");
                Console.WriteLine("             Estado de Cuenta               ");
                Console.WriteLine("");

                if (SaldoActual > 0)
                    Estado = "Acredor";
                if (SaldoActual == 0)
                    Estado = "Nulo";
                if (SaldoActual < 0)
                    Estado = "Deudor";

                Console.WriteLine("\nCuenta: {0}", Cuenta);
                Console.WriteLine("\nEstado: {0}", Estado);
                Console.WriteLine("\nSaldo: {0}", SaldoActual);
                //if (SaldoActual > 0)
                Console.WriteLine("\nSaldo acredor: {0}", SaldoAcredor);
                Console.Write("\nContinuar con otra cuenta? S/N ");
                Eleccion = Console.ReadLine();
            } while (Eleccion != "N" &&  Eleccion != "n");
            Console.ReadKey();

        }
    }
}
