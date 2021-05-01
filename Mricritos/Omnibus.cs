/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 05:41 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Omnibus.
	/// </summary>
	public class Omnibus
	{
		//estados
		
		private string marca, tipo;
		private int nro_de_unidad, capacidad, modelo;
		 
		//constructor
		public Omnibus(string marca, int modelo,int capacidad, int nro_de_unidad, string tipo)
		{
			this.marca=marca;
			this.modelo=modelo;
			this.capacidad=capacidad;
			this.nro_de_unidad=nro_de_unidad;
			this.tipo=tipo;
		}
		
		//encapsulamineto
		
		
		
		
		
		
		
		public string  Marca
		{
			set{marca=value;}
			get{return Marca=marca;}
		}
		
		public int Modelo
		{
			set{modelo=value;}
			get{return Modelo=modelo;}
		}
		
		public int Capacidad
		{
			set{capacidad=value;}
			get{return Capacidad=capacidad;}
		}
		
		public int Nro_De_Unidad
		{
			set{nro_de_unidad=value;}
			get{return Nro_De_Unidad=nro_de_unidad;}
		}
		
		public string Tipo
		{
			set {tipo=value;}
			get{return Tipo=tipo;}
		}
		
		//metodo tostring
		
		public override string ToString()
		{
			return  "(" + marca + " - " + modelo+ ", "+ tipo+ ", " + capacidad+ ")";
		}
	}
}
