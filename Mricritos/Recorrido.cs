/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 06:23 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Trabajo_Final
{
	/// <summary>
	/// Description of Recorrido.
	/// </summary>
	public class Recorrido
	{
		//estados
		
		private Chofer chofer;
		private Omnibus omnibus;
		private ArrayList terminales_del_recorrido;
		private string dia;
		
		
		
		//constructores

		public Recorrido()
		{
			terminales_del_recorrido=new ArrayList();
		}
		
		public Recorrido(Chofer c, Omnibus o, string dia, ArrayList terminales)
		{
			this.terminales_del_recorrido=terminales;
			this.chofer=c;
			this.omnibus=o;
			this.dia=dia;
		}
		
		//encapsulamiento
		
		
		public ArrayList Terminales_del_recorrido {
			get { return terminales_del_recorrido; }
			set { terminales_del_recorrido = value; }
		}
		
		public Chofer Chofer
		{
			set{ chofer=value;}
			get{return Chofer=chofer;}
		}
		
		public Omnibus Omnibus
		{
			set{ omnibus=value;}
			get{ return Omnibus=omnibus;}
		}
		
		public string Dia
		{
			set {dia=value;}
			get{ return Dia=dia;}
		}
		
		
		
		//metodo tostring 
		
		public override string ToString()
		{
			string terminales=" ";
			foreach(Terminal t  in terminales_del_recorrido)
			{
				terminales += " - " + t.Ciudad_Donde_Se_Encuentra;
			}
			
			return terminales;
		}
		
		//comportamientos
		
		public void altaDeRecorrido(ArrayList terminales)
		{
			titulo();
			Console.WriteLine("");
			Console.WriteLine("Seleccione las terminales del recorrido, ingrese 0 para finalizar");
			Console.WriteLine("");
			
			
			//crea un arrayList donde se encontraran guardadas las terminales seleccionadas
			ArrayList seleccionadas=new ArrayList();
			
			
			//imprencion de terminales disponibles
			int j=1;
			for(int i=0; i< terminales.Count; i++)
			 	{
				
					Console.WriteLine(" "+j+")"+terminales[i]);
					
					j++;
				}
			
			
			Console.WriteLine("");
			int seleccion=int.Parse(Console.ReadLine());
			
			
			//inicio de seleccion de terminales.
			
			
			while (seleccion!= 0)
			{
				
				//por cada iteracion se crea un arraylist de enteros con las misma longitud de terminales existentes
				
				ArrayList nro_terminal=new ArrayList();
				            
				for(int i =1; i<=terminales.Count; i++)
				{
					nro_terminal.Add(i);
				}
		
				//busqueda, guardado y eliminacion de la terminal seleccionada.
	
				bool terminal_encontrada=false;
				
				for (int i=0 ; terminal_encontrada!=true; i++)
				{  
					if (seleccion == (int)nro_terminal[i])
					{
						nro_terminal.RemoveAt(seleccion-1);
						seleccionadas.Add(terminales[seleccion-1]);
						terminales_del_recorrido.Add(terminales[seleccion-1]);
						terminales.RemoveAt(seleccion-1);
						terminal_encontrada=true;	
					}	
				}
				
				Console.Clear();
				titulo();
				Console.WriteLine("");
				Console.WriteLine("Seleccione las terminales del recorrido, ingrese 0 para finalizar");
				Console.WriteLine("");
			
				
				imprimirOpcionSeleccionada(terminales,seleccionadas);
				
				Console.WriteLine(" ");
				seleccion=int.Parse(Console.ReadLine());
					
				
				
			}
		}
				
			
			
			
		
		
		
		//metodo que imprime las terminales disponibles y las seleccionadas
		
		public void imprimirOpcionSeleccionada(ArrayList terminales, ArrayList seleccionadas)
		{
			
			// Determina cual es el tamaño maximo de los arrays para usar de limite en el for
			int tamMax = terminales.Count > seleccionadas.Count ?terminales.Count : seleccionadas.Count;  
			
			int j=1;
			
		
			
			
			            
			for (int i = 0; i < tamMax; i++) {
			   
			    if (i < terminales.Count)       
			    {
			    	Console.Write(" "+j+") ");
			    	Console.Write(terminales[ i]);
			    	j++;
			    }
			    else
			        Console.Write("\t");
			   
			    Console.Write("\t"+"\t"+"\t"+"\t");
			   
			    if (i < seleccionadas.Count)       
			        Console.Write(seleccionadas[i]);
			   
			   
			    Console.WriteLine(" ");
			}
		}
		
		public static void titulo()
		{
			Console.Write("********************************************************************************");
			Console.Write("*****                              Micritos                                *****");
			Console.Write("********************************************************************************");
		}
		
	}
}
