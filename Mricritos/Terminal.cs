/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 06:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Terminal.
	/// </summary>
	public class Terminal
	{
		//estados
		private string nombre, cuidad_donde_se_encuentra;
		
		//constructor
		public Terminal(string nombre,string ciudad_donde_se_encuentra)
		{
			this.nombre=nombre;
			this.cuidad_donde_se_encuentra=ciudad_donde_se_encuentra;
		}
		
		//encapsulamiento
		
		public string Nombre
		{
			set{nombre=value;}
			get{return Nombre=nombre;}
		}
		
		public string Ciudad_Donde_Se_Encuentra
		{
			set{ cuidad_donde_se_encuentra=value;}
			get{return Ciudad_Donde_Se_Encuentra=cuidad_donde_se_encuentra;}
		}
		
		//metodo tostring
	
		public override string ToString()
		{
			return cuidad_donde_se_encuentra;
		}
	}
}
