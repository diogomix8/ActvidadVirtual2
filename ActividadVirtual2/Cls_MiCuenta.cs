/*
 * Created by SharpDevelop.
 *
 */
using System;

namespace ActividadVirtual2
{
	
	public class Cls_MiCuenta
	{
		//Atributos
		private int NroCuenta=0;
		private double saldo=0;
		private string Propietario,FechaAlta;
	
		public Cls_MiCuenta()//Constructor 1
		{
		}
		public Cls_MiCuenta(int nroC,double s,string prop,string fechA)//Constructor 2
		{
			this.NroCuenta=nroC;
			this.saldo=s;
			this.Propietario=prop;
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
		public void setProp(string p)
		{
			this.Propietario=p;
		}
		public void setFechaA(string f)
		{
			this.FechaAlta=f;
		}
		public int getNroCuenta()
		{
			return this.NroCuenta;
		}
		public int getSaldo()
		{
			return this.saldo;
		}
		public string getProp()
		{
			return this.Propietario;
		}
		public string getFechA()
		{
			return this.FechaAlta;
		}
		public void transaccion(double cantidad,string tipo){
			if(String.equals(tipo,"deposito"))
			{
				saldo=saldo+cantidad;
			}
			else if(saldo>cantidad)
				{
					saldo=saldo-cantidad;
				}
			     else saldo=0;
		}
	}
}
