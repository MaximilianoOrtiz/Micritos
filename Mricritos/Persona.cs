/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 04:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		//estados
		
		private string nombre, apellido;
		private int dni;

		//constructor
		
		public Persona (string nombre, string apellido,int dni)
		{
			this.nombre=nombre;
			this.apellido=apellido;	
			this.dni=dni;
		}
		
		//encapsulamiento 
		
		public string Nombre
		{
			set {nombre=value;}
			get{return Nombre=nombre;}
		}
		
		public string Apellido
		{
			set{apellido=value;}
			get{return Apellido=apellido;}
		}
		
		public int Dni
		{
			set{dni=value;}
			get{return Dni=dni;}
		}
		
		//metodo tostring
		
		public override string ToString()
		{
			return nombre +" "+apellido +" ";
		}
	}
}
