/*
 * Created by SharpDevelop.
 * User: Brian
 * Date: 18/08/2016
 * Time: 23:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ActividadVirtual2
{
	
	public class Cls_Persona
	{
		// Atributos
		private string nombre;
		private string apellido;
		private long dni;
		private int edad;
		private long tel;
		
		// Constructores
		/*Inicializa un Objeto vacio*/
		public Cls_Persona()
		{
		}
		
		/* Inicializa un Objeto con los parametros dados */
		public Cls_Persona(string nom,string apell,long dni,int edad,long tel)
		{
			this.nombre=nom;
			this.apellido=apell;
			this.dni=dni;
			this.edad=edad;
			/* Utilizando una Exception */
//			if(cantidadDigitos(tel)<= 9)
//				throw new Exception("ERROR: La cantidad de digitos para el TEL tiene que ser <= 9");
//			this.tel=tel;	
			Boolean salir=true;
			do{
			   if(cantidadDigitos(tel)<= 9)
			   {
				this.tel=tel;
				salir=false;
			   }
			   else
			   {
			   	Console.WriteLine("ERROR: Vuelva a Ingresar un Telefono Valido...");
			   	long telfono = Console.Read();
			   	tel = telfono;
			   }
			}while(salir);
		}
		
		//Metodos
		public void setNombre(string nom)
		{
			this.nombre=nom;
		}
		public void setApellido(string a)
		{
			this.apellido=a;
		}
		public void setDni(long dni)
		{
			this.dni=dni;
		}
		public void setEdad(int e)
		{
			this.edad=e;
		}
		public void setTel(int t)
		{
			this.tel=t;
		}
		public string getNombre()
		{
			return this.nombre;
		}
		public string getApellido()
		{
			return this.apellido;
		}
		public long getDni()
		{
			return this.dni;
		}
		public int getEdad()
		{
			return this.edad;
		}
		public  long getTel()
		{
			return this.tel;
		}
		public int cantidadDigitos(long valor){
			long aux=valor;
			int cont=0;
			
			while(aux!=0){
			    cont++;
			    aux=aux/10;
			}
			return cont;
		}
	
	}
}