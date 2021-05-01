/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 06/11/2018
 * Time: 09:53 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Venta.
	/// </summary>
	public class Venta
	{
		//estados
		private Usuario usuario;
		private int cant_pasajes;
		private Recorrido itinerario;
		
		//constructor
		public Venta(Usuario usuario , Recorrido itinerario ,int cant_pasajes)
		{
			this.usuario=usuario;
			this.cant_pasajes=cant_pasajes;	
			this.itinerario=itinerario;
		}
		
		//encapsulamiento
		
		public Usuario Usuario
		{
			set {usuario=value;}
			get{return Usuario=usuario;}
		}
		
		public int Cant_Pasajes
		{
			set { cant_pasajes=value;}
			get{return Cant_Pasajes=cant_pasajes;}
		}
		
		
		//metodo tostring 
		
		public override string ToString()
		{
			return usuario.Nombre + " " + usuario.Apellido +  " (" + cant_pasajes + ")";
		}

	}
}

		