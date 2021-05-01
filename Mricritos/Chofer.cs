/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 05:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Chofer.
	/// </summary>
	public class Chofer : Persona
	{
		//Estados
		
		private int nro_de_legajo;
		
		//conotructor
		
		
		
		public Chofer(string nombre, string apellido, int dni, int nro_de_legajo):base(nombre,apellido,dni)
		{
			this.nro_de_legajo=nro_de_legajo;
		}
		
		//encapculamiento
		
		public int Nro_De_Legajo
		{
			set {nro_de_legajo=value;}
			get{return Nro_De_Legajo=nro_de_legajo;}
		}
		
		
		//metodo tostring
		
		public override string ToString()
		{
			return base.ToString()+"("+ nro_de_legajo + ")";
		}
		
	}
}
