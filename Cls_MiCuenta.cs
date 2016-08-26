/*
<<<<<<< HEAD
 * Created by SharpDevelop.
 *
=======
 * Miró Morón,Brian-Mogro,Guillermo-Palacio, Diego
 * Programación C# para WEB
 * Actividad Virtual 2
>>>>>>> upstream/master
 */
using System;

namespace ActividadVirtual2
{
	
	public class Cls_MiCuenta
	{
		//Atributos
		private int NroCuenta=0;
		private double saldo=0;
		private string FechaAlta;
		private Cls_Persona Propietario;
	
		public Cls_MiCuenta()//Constructor 1
		{
		}
		public Cls_MiCuenta(int nroC,double s,string fechA, Cls_Persona P)//Constructor 2
		{
			this.NroCuenta=nroC;
			this.saldo=s;
			/* Inicializamos un Objeto de la clase Persona */
			Propietario = new Cls_Persona();
			/* Asignamos el Objeto */
			Propietario = P;
			this.FechaAlta=fechA;
		}
		public void setNroCuenta(int NroC)
		{
			this.NroCuenta=NroC;
			
		}
		public void setSaldo(double s)
		{
			this.saldo=s;
		}
		public void setFechaA(string f)
		{
			this.FechaAlta=f;
		}
		public int getNroCuenta()
		{
			return this.NroCuenta;
		}
		public double getSaldo()
		{
			return this.saldo;
		}
		public string getFechA()
		{
			return this.FechaAlta;
		}
		public void transaccion(double cantidad,string tipo){
			if (tipo == "deposito")
			{
<<<<<<< HEAD
				saldo=saldo+cantidad;
				Console.WriteLine("***************** DEPOSITO ******************");
				Console.WriteLine("Cuenta N°: "+getNroCuenta());
				Console.WriteLine("Apellido y Nombre: "+Propietario.getApellido()+","+Propietario.getNombre());
=======
				//saldo=saldo+cantidad;
				Console.WriteLine("***************** DEPOSITO ******************");
				Console.WriteLine("Cuenta N°: "+getNroCuenta());
				Console.WriteLine("Apellido y Nombre: "+Propietario.getApellido()+","+Propietario.getNombre());
				Console.WriteLine("SALDO : "+getSaldo());
				setSaldo(getSaldo()+cantidad);
>>>>>>> upstream/master
				Console.WriteLine("Cantidad a Depositar: $"+cantidad);
				Console.WriteLine("Saldo Actual: $"+getSaldo());
				Console.WriteLine("----EL DEPOSITO SE REALIZO CORRECTAMENTE ----");
				Console.WriteLine("*********************************************");
				Console.WriteLine();
			}
			else if(saldo>cantidad)
				{
<<<<<<< HEAD
					saldo=saldo-cantidad;
					Console.WriteLine("***************** RETIRO ******************");
					Console.WriteLine("Cuenta N°: "+getNroCuenta());
					Console.WriteLine("Apellido y Nombre: "+Propietario.getNombre()+","+Propietario.getApellido());
=======
					//saldo=saldo-cantidad;
					Console.WriteLine("***************** RETIRO ******************");
					Console.WriteLine("Cuenta N°: "+getNroCuenta());
					Console.WriteLine("Apellido y Nombre: "+Propietario.getNombre()+","+Propietario.getApellido());
					Console.WriteLine("SALDO : "+getSaldo());
					setSaldo(getSaldo()-cantidad);
>>>>>>> upstream/master
					Console.WriteLine("Cantidad a Retirar: $"+cantidad);
					Console.WriteLine("Saldo Actual: $"+getSaldo());
					Console.WriteLine("----EL EL RETIRO SE REALIZO CORRECTAMENTE ----");
					Console.WriteLine("*********************************************");
					Console.WriteLine();
				}
			else Console.WriteLine("El saldo de la Cuenta es Insuficiente para retirar esa cantidad");
		}
		public void mostrarSaldo(){
			Console.WriteLine("******************* SALDO *********************");
<<<<<<< HEAD
			Console.WriteLine("Cuenta Numero");
=======
			Console.WriteLine("Cuenta Numero :"+getNroCuenta());
			Console.WriteLine("Saldo :"+getSaldo());
>>>>>>> upstream/master
		}
	}
}
