/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 05:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario: Persona
	{
		//estados
		
		
		private string fecha_de_nacimiento;
		private int nro_de_usuario;
		
		//constructor
		
		public Usuario(string nombre, string apellido, int dni, string fecha_de_nacimiento, int nro_de_usuario):base(nombre,apellido,dni)
		{
			this.fecha_de_nacimiento=fecha_de_nacimiento;
			this.nro_de_usuario=nro_de_usuario;
		}
		
		
		//encapsulamiento 
		
		public string Fecha_De_Nacimineto
		{
			set{fecha_de_nacimiento=value;}
			get{return Fecha_De_Nacimineto=fecha_de_nacimiento;}
			
		}
		
		public int Nro_De_Usuario
		{
			set{nro_de_usuario=value;}
			get { return Nro_De_Usuario=nro_de_usuario;}
		}
		
		//metodo tostring
		
		public override string ToString()
		{
			return base.ToString() + " "+ "("+nro_de_usuario+")";
		}
	}
}
