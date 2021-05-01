/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 18/11/2018
 * Time: 06:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Exepciones.
	/// </summary>
	public class Exepciones : Exception
	{
		
		public Exepciones()
		{
		}
		

	}

	}
	
	
	public class dniInvalido:Exception
	{
		private string mensaje = "Su DNI no cumple con la extencion adecuada";
		
		public dniInvalido()
		{
			
		}
		
		public string Mensaje
		{
			set {mensaje=value;}
			get {return Mensaje=mensaje;}
		}
		
		
		
	}
	
	public class marcaYModeloInvalido:Exception
	{
		
		private string mensaje = "La marca y el modelo no admiten valores menores a 0.";
		
		public marcaYModeloInvalido()
		{
			
		}
		
		public string Mensaje
		{
			set {mensaje=value;}
			get {return Mensaje=mensaje;}
		}
		
		
	}
	
	public class fechaInvalida :Exception
	{
		private string mensaje = "Su fecha de nacimiento no cumple con la extencion adecuada";
		
		public fechaInvalida()
		{
			
		}
		
		public string Mensaje
		{
			set {mensaje=value;}
			get {return Mensaje=mensaje;}
		}
		
		
		
	}

