/*
<<<<<<< HEAD
 *Miró Morón,Brian-Mogro,Guillermo-Palacio, Diego
=======
 * Miró Morón,Brian-Mogro,Guillermo-Palacio, Diego
 * Programación C# para WEB
 * Actividad Virtual 2
>>>>>>> upstream/master
 */
using System;

namespace ActividadVirtual2
{
	class Cls_Principal
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("================== Cliente 1 =====================");
			Console.WriteLine("Ingrese los datos del Cliente 1");
			Console.Write("Apellido: ");string apellido_1 = Console.ReadLine();
			Console.Write("Nombre: ");string nombre_1 = Console.ReadLine();
			Console.Write("D.N.I. N°: ");long dni_1 = Console.Read();Console.ReadLine();
			Console.Write("Edad: ");int edad_1 = Console.Read();Console.ReadLine();
			Console.Write("Telefono : ");long tel_1 = Console.Read();Console.ReadLine();
<<<<<<< HEAD
			Console.Write("N° de Cuenta : ");int nroCuenta_1 = Console.Read();Console.ReadLine();
			Console.Write("Saldo: $");double saldo_1 = Console.Read();Console.ReadLine();
=======
			
			Console.Write("N° de Cuenta : ");string nroCuenta = Console.ReadLine();
			int nroCuenta_1 = int.Parse(nroCuenta);
			
			Console.Write("Saldo: $");string saldo = Console.ReadLine();
			double saldo_1 =double.Parse(saldo);
			
>>>>>>> upstream/master
			Console.Write("Fecha de Alta: ");string fechaA_1 = Console.ReadLine();
			Console.WriteLine("===================================================");
			Console.WriteLine();
			/* Instanciamos al Cliente 1 */
			Cls_Persona P1 =  new Cls_Persona(apellido_1,nombre_1,dni_1,edad_1,tel_1);
			Cls_MiCuenta Cuenta1 = new Cls_MiCuenta(nroCuenta_1,saldo_1,fechaA_1,P1);
			
			Console.WriteLine("================== Cliente 2 =====================");
<<<<<<< HEAD
			Console.WriteLine("Ingrese los datos del Cliente 1");
=======
			Console.WriteLine("Ingrese los datos del Cliente 2");
>>>>>>> upstream/master
			Console.Write("Apellido: ");string apellido_2 = Console.ReadLine();
			Console.Write("Nombre: ");string nombre_2 = Console.ReadLine();
			Console.Write("D.N.I. N°: ");long dni_2 = Console.Read();Console.ReadLine();
			Console.Write("Edad: ");int edad_2 = Console.Read();Console.ReadLine();
			Console.Write("Telefono : ");long tel_2 = Console.Read();Console.ReadLine();
<<<<<<< HEAD
			Console.Write("N° de Cuenta : ");int nroCuenta_2 = Console.Read();Console.ReadLine();
			Console.Write("Saldo: $");double saldo_2 = Console.Read();Console.ReadLine();
=======
			
			Console.Write("N° de Cuenta : ");string nroCuenta2= Console.ReadLine();
			int nroCuenta_2 =int.Parse(nroCuenta2);
			
			Console.Write("Saldo: $");string saldo2 = Console.ReadLine();
			double saldo_2 =double.Parse(saldo2);
			
>>>>>>> upstream/master
			Console.Write("Fecha de Alta: ");string fechaA_2 = Console.ReadLine();
			Console.WriteLine("===================================================");
			Console.WriteLine();
			/* Instanciamos al Cliente 2 */
			Cls_Persona P2 = new Cls_Persona(apellido_2,nombre_2,dni_2,edad_2,tel_2);
			Cls_MiCuenta Cuenta2 = new Cls_MiCuenta(nroCuenta_2,saldo_2,fechaA_2,P2);
			
			
			
<<<<<<< HEAD
			Console.WriteLine("Retiro");
			Cuenta1.transaccion(23444,"deposito");
			Console.ReadKey();
		}
	}
}
=======
			//Operacion de Deposito y Retiro para el Cliente 1
			Cuenta1.transaccion(2000,"deposito");
			Cuenta1.transaccion(500,"retiro");
			Cuenta1.mostrarSaldo();
			Console.ReadKey();
			//Opercacion de Deposito y Retiro para el Cliente 2
			Cuenta2.transaccion(1000,"deposito");
			Cuenta2.transaccion(100,"retiro");
			Cuenta2.mostrarSaldo();
			Console.ReadKey();
		}
	}
}
>>>>>>> upstream/master
