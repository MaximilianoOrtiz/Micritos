/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 06/11/2018
 * Time: 10:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;


namespace Trabajo_Final
{
	/// <summary>
	/// Description of Micritos.
	/// </summary>
	public class Micritos
	{
		
		
		//estados
		private ArrayList recorridos, choferes, omnibus, usuarios, terminales, ventas, recorridos_asignados;
	   
		//constructor
		public Micritos()
		{
			recorridos=new ArrayList();
			choferes= new ArrayList();
			omnibus=new ArrayList();
			usuarios=new ArrayList();
			terminales=new ArrayList();
			ventas=new ArrayList();
			recorridos_asignados=new ArrayList();
			test();
		}
		
		
		public void test()
		{
			
			terminales.Add(new Terminal("la plata", "la plata"));
			terminales.Add(new Terminal("varela", "varela"));
			terminales.Add(new Terminal("cordoba", "cordoba"));
			
			choferes.Add(new Chofer("maxi","ortiz",38,1));
			choferes.Add(new Chofer("pedro","ortiz",37,2));
			                          
			omnibus.Add(new Omnibus("Iveco", 2018, 25,1,"Normal"));
			
			usuarios.Add(new Usuario("mica", "pepita",20,"1/07/1994",1));

		}
		
		public ArrayList Terminales
		{
			set{terminales=value;}
			get{return Terminales=terminales;}
		}
		
		//metodos que aseguran el encapsulamiento en los ArrayList
		
		private void agregarTerminal(Terminal terminal)
		{
			terminales.Add(terminal);
		}
		
		private void agregarOmnibus(Omnibus o)
		{
			omnibus.Add(o);
		}
		
		private void agregarRecorrido(Recorrido recorrido)
		{
			recorridos.Add(recorrido);
		}
		
		private void agregarChofer(Chofer chofer)
		{
			choferes.Add (chofer);
		}
		
		private void agregarUsuario(Usuario usuario)
		{
			usuarios.Add(usuario);
		}
	
		
		//metodos para imprecion en consola
		
		public static void imprimirAbajo(string texto)
		{
			Console.WriteLine(texto);
		}
		
		public static void imprimirSeguido(string texto)
		{
			Console.Write(texto);
		}
		
		public static void titulo()
		{
			Console.Write("********************************************************************************");
			Console.Write("*****                              Micritos                                *****");
			Console.Write("********************************************************************************");
		}

		//metodos
		
		
		//solicitud  datos de terminal y guardado
		
		public void altaDeTerminal()
		{
			
				imprimirAbajo("Ingrese el nombre de la terminal");
				string nombre = Console.ReadLine();
				imprimirAbajo("Ingrese el nombre de la ciudad");
				string ciudad = Console.ReadLine();

				Terminal t =new Terminal(nombre, ciudad);
				
				agregarTerminal(t);
				
				imprimirAbajo("La terminal fue dada de alta correctamente");
				imprimirAbajo("Presione ENTER para continuar");
		}
		
		//solicitud datos del omnibus y guardado
		
		public void altaDeOmnibus()
		{
			//try
			//{
			
				imprimirAbajo("Ingrese la marca");
				string marca=Console.ReadLine();
				imprimirAbajo("Ingrese el modelo");
				int modelo=int.Parse(Console.ReadLine());
				imprimirAbajo("Ingrese la capacidad");
				int capacidad=int.Parse(Console.ReadLine());
				imprimirAbajo("Ingrese el tipo");
				string tipo =Console.ReadLine();
						
				if (modelo<=0 || capacidad<=0)
				{
					throw new marcaYModeloInvalido();
				}
						
				//asignacion nro de unidad
				
				int nro_de_unidad=omnibus.Count+1;
				
				Omnibus O =new Omnibus(marca, modelo ,capacidad, nro_de_unidad,tipo);
				
				agregarOmnibus(O);
				
				imprimirAbajo("El ómnibus fue dado de alta correctamente. A la unidad se le asignó el número "+ nro_de_unidad);
				imprimirAbajo("Presione ENTER para continuar");
				
				imprimirAbajo("");

		}
		
		//seleccion del recorrido y alta del mismo	
			
		public void altaDeRecorrido(Recorrido recorrido)
		{
			//copia de todos los recorridos para uso de seleccion 
			ArrayList copiaDeTerminales=new  ArrayList();
			for(int i=0; i<terminales.Count; i++)
			{
				copiaDeTerminales.Add(terminales[i]);
			}
			
			//seleccion y alta de recorrido
			recorrido.altaDeRecorrido(copiaDeTerminales);
			recorridos.Add(recorrido);
			imprimirAbajo("El recorrido se ha dado de alta correctamente");
			imprimirAbajo("Presione una Enter para continuar.");
			
			
		}
		
		//solicitud datos de chofer verificacion y  guardado 
		
		public void altaDeChofer()
		{
			
			try
			{
				imprimirAbajo("Ingrese el nombre");
				string nombre=Console.ReadLine();
				imprimirAbajo("Ingrese el apellido");
				string apellido=(Console.ReadLine());
				imprimirAbajo("Ingrese el DNI");
				int dni=int.Parse(Console.ReadLine());
				int nro_de_legajo=choferes.Count+1;
				
				if (dni<10000000 )
				{
					throw new dniInvalido();
				}
				
				
	
				if (existeChofer(dni))
				{
					imprimirAbajo("Ya existe un Chofer con ese DNI en la empresa");
					imprimirAbajo("presione ENTER para continuar.");
						
				}
				else
				{
					//guardado del chofer
					
					choferes.Add(new Chofer(nombre,apellido,dni,nro_de_legajo));
						
					imprimirAbajo("El chofer fue dado de alta correctamente. Su legajo es el número " + nro_de_legajo);
					imprimirAbajo("Presione ENTER para continuar.");
						
				}
			}
			
			catch(dniInvalido dni)
			{
				imprimirAbajo(dni.Mensaje);
				imprimirAbajo("Presione ENTER para continuar.");
			}
		
		}
		
		private bool existeChofer(int dni)
		{
			bool existe_chofer=false;
			foreach(Chofer c in choferes)
			{
				if (dni == c.Dni)
				{
					return existe_chofer=true;
				}
			}
			return existe_chofer;
		}
		
		
		
		public void asignarRecorrido()
		{

			//muestras ,solicitud y guardado en temporal de:

			//Choferes:

			titulo();
			imprimirAbajo("");
			imprimirAbajo("Seleccione el chofer");
			imprimirAbajo("");
			
			int j=1;
			for (int i = 0; i<choferes.Count; i++)
			{
				imprimirAbajo(j+") "+ choferes[i]);
				j++;
			}
			
			int seleccion_chofer=int.Parse(Console.ReadLine());
			
			Chofer chofer=(Chofer)choferes[seleccion_chofer-1];
			
			Console.Clear();
			
			//Omnibus:
	
			titulo();
			imprimirAbajo("");
			imprimirAbajo("Seleccione el ómnibus");
			imprimirAbajo("");
			
			int l=1;
			for (int i = 0; i<omnibus.Count; i++)
			{
				imprimirAbajo(l+") "+ omnibus[i]);
				l++;
			}
			
			int seleccion_omnibus=int.Parse(Console.ReadLine());
			
			Omnibus ómnibus= (Omnibus)omnibus[seleccion_omnibus-1];
			
			Console.Clear();
				
			//Recorrido
			
			titulo();
			imprimirAbajo("");
			imprimirAbajo("Seleccione el recorrido");
			imprimirAbajo("");
			
			int m=1;
			for (int i = 0; i<recorridos.Count; i++)
			{
				imprimirAbajo(m+") "+recorridos[i]);
				m++;
			}
			
			int seleccion_recorrido=int.Parse(Console.ReadLine());

			Recorrido recorrido =(Recorrido)recorridos[seleccion_recorrido-1];
			
			Console.Clear();
			
			//Dia
			
			string[] dias = new string[]{"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingos"};
			
			titulo();
			imprimirAbajo("");
			imprimirAbajo("Seleccione el día donde hacer el recorrido");
			imprimirAbajo("");
			
			int k=1;
			for (int i = 0; i<dias.Length; i++)
			{
				imprimirAbajo(k+") "+dias[i]);
				k++;
			}
			
			int seleccion_dia=int.Parse(Console.ReadLine());
			
			string dia= dias[seleccion_dia-1];

			if(omnibusOcupado(ómnibus,dia)){
						
				imprimirAbajo("");
				imprimirAbajo("El ómnibus ya está reservado ese diá");
				imprimirAbajo("Presione ENTER para continuar");
			}
			else if (choferOcupado(chofer,dia))
			{
				imprimirAbajo("");
				imprimirAbajo("El chofer ya hace un viaje ese día");
				imprimirAbajo("Presione ENTER para continuar");
			}
			else
		  	{
				//((Recorrido)Temporal[2]).Chofer=c;
							
				recorridos_asignados.Add(new Recorrido(chofer,ómnibus,dia,recorrido.Terminales_del_recorrido));
							
				//Recorrido R=(Recorrido)recorridos_asignados[recorridos_asignados.Count-1];
		
				imprimirAbajo("");
				imprimirAbajo("La asignación de recorrido fue dada de alta correctamente.");
				imprimirAbajo("Presione ENTER para continuar.");
			}
				
		}

		private bool choferOcupado(Chofer c , string dia)
		{
			
			bool validacion = false;
			
			foreach (Recorrido r in recorridos_asignados)
				{
					
					 
					 if(c.Dni == r.Chofer.Dni && dia == r.Dia)
					 {
					 	return validacion=true;
					 }
					
			    }
			return validacion;
					
				
		}
		
		private bool omnibusOcupado(Omnibus O , string dia)
		{

			bool validacion = false;
			
			foreach (Recorrido r in recorridos_asignados)
				{
					
					 
					 if( O.Nro_De_Unidad == r.Omnibus.Nro_De_Unidad &&  dia == r.Dia)
					 {
					 	return validacion=true;
					 }
					 
			    }
			return validacion;
		}
		
		
		
		public void altaDeUsuario()
		{
			try{
				
			
				imprimirAbajo("Ingrese el nombre");
				string nombre=Console.ReadLine();
				imprimirAbajo("Ingrese el apellido");
				string apellido=(Console.ReadLine());
				imprimirAbajo("Ingrese el DNI");
				int dni=int.Parse(Console.ReadLine());
				
				if (dni<10100100)
				{
					throw new dniInvalido();
				}
				
				imprimirAbajo("ingrese la fecha de nacimiento en el formato DD/MM/AAAA");
				string fecha_de_nacimiento=Console.ReadLine();
				
				if (fecha_de_nacimiento.Length<10 | fecha_de_nacimiento.Length >10 )
				{
					throw new fechaInvalida();
				}
				
				
				int nro_de_legajo=usuarios.Count+1;
				
	
					if (existeUsuario(dni) )
					{
						imprimirAbajo("Ya existe un Usuario con ese DNI en la empresa");
						imprimirAbajo("presione ENTER para continuar.");
						
					}
					else
					{
						usuarios.Add( new Usuario(nombre,apellido,dni,fecha_de_nacimiento,nro_de_legajo));
						
						imprimirAbajo("El chofer fue dado de alta correctamente. Su legajo es el número " + nro_de_legajo);
						imprimirAbajo("Presione ENTER para continuar.");
		
					}
			}
			catch(dniInvalido D)
			{
				Console.WriteLine( D.Mensaje);
			}
			catch(fechaInvalida f)
			{
				Console.WriteLine(f.Mensaje);
			}
			
			
		}
		
		private bool existeUsuario(int dni)
		{
			bool existe_usuario=false;
			foreach(Usuario u in usuarios)
			{
				if(dni == u.Dni)
				{
					return existe_usuario=true;
				}
			}
			return existe_usuario;
		}
		
		
		
		
		
		public void comprarPasaje()
		{
		
			imprimirAbajo("Ingrese el número de usuario");
			int nro_de_usuario=int.Parse(Console.ReadLine());
			imprimirAbajo("Ingrese el DNI");
			int dni=int.Parse(Console.ReadLine());
			
			if(noExisteUsiario(dni))
			{
				imprimirAbajo("No existe un Usuario con ese DNI en la empresa");
				imprimirAbajo("presione ENTER para continuar.");
			}
			
			else
			{
				Usuario usuario= compraUsuario(dni,nro_de_usuario);

				Console.Clear();
				titulo();
 
				// imprimo las terminales de partida verificando que ninguna se repita 
				ArrayList terminales_de_partida=new ArrayList();

				imprimirAbajo("seleccione la terminal de partida");
				imprimirAbajo("");
				int k=1;
				for(int i=0 ; i<recorridos_asignados.Count; i++)
				{
					Recorrido recorrido =((Recorrido)recorridos_asignados[i]);
					
					if (!partidaRepetida(((Terminal)recorrido.Terminales_del_recorrido[0]), terminales_de_partida))
					{
						terminales_de_partida.Add((Terminal)recorrido.Terminales_del_recorrido[0]);
						Console.WriteLine(k+")"+ (Terminal)recorrido.Terminales_del_recorrido[0]);
						k++;
					}
					
				}
				
				//selecciono la terminal de partida
				
				int partida_seleccionada=int.Parse(Console.ReadLine());
				
				Terminal terminal_de_partida=(Terminal)((Recorrido)recorridos_asignados[partida_seleccionada-1]).Terminales_del_recorrido[0];
				
				Console.Clear();
				titulo();
				
				
				//imprimo las terminales de arribo verificando que ninguna se repita 
				
				ArrayList terminales_de_arribo= new ArrayList();
				
				imprimirAbajo("seleccione la terminal de arribo");
				imprimirAbajo("");
				
				int j=1;
				for(int i=0 ; i<recorridos_asignados.Count; i++)
				{
					Recorrido recorrido =((Recorrido)recorridos_asignados[i]);
					
					if (!arriboRepetido(((Terminal)recorrido.Terminales_del_recorrido[(recorrido.Terminales_del_recorrido).Count-1]), terminales_de_arribo))
					{
						terminales_de_arribo.Add((Terminal)recorrido.Terminales_del_recorrido[(recorrido.Terminales_del_recorrido).Count-1]);
						Console.WriteLine(j+")"+ (Terminal)recorrido.Terminales_del_recorrido[(recorrido.Terminales_del_recorrido).Count-1]);
						j++;
					}
					
				}
				
				
				//selecciono terminal de arribo
				
				int arribo_seleccionado=int.Parse(Console.ReadLine());
				Recorrido   R =((Recorrido)recorridos_asignados[arribo_seleccionado-1]);
				Terminal terminal_de_arribo=(Terminal)(R).Terminales_del_recorrido[(R.Terminales_del_recorrido).Count-1];
				
				
				
				// verifico que la terminal de partida y arribo no sean las mismas.
				
				if (terminal_de_partida.Nombre == terminal_de_arribo.Nombre && terminal_de_partida.Ciudad_Donde_Se_Encuentra == terminal_de_partida.Ciudad_Donde_Se_Encuentra)
				{
					imprimirAbajo("La terminal de partida y arribo  es las mismas");
					imprimirAbajo("Precione ENTER para continuar");
						
				}
				
				else 
				{
					Console.Clear();
					titulo();
					
					if (!existeItinerario (terminal_de_partida , terminal_de_arribo))
					{
						imprimirAbajo("No existe ningun recorrido con las terminales de partida solicitadas.");
						imprimirAbajo("Presione ENTER para continuar.");
					}
					else
					{
						
						
						ArrayList itinerario= itinerarios(terminal_de_partida , terminal_de_arribo);
						
						
						int m=1;
						for (int i=0 ; i< itinerario.Count ; i++)
						{
							int cant_paradas_intermedia = ((Recorrido)itinerario[i]).Terminales_del_recorrido.Count-2;
							string dia = ((Recorrido)itinerario[i]).Dia;
							string modelo=((Omnibus)(((Recorrido)itinerario[i]).Omnibus)).Tipo;
							Console.WriteLine(m + ") Saliendo de " + terminal_de_partida.Ciudad_Donde_Se_Encuentra + " y llegando a " + terminal_de_arribo.Ciudad_Donde_Se_Encuentra + "("+ cant_paradas_intermedia	+" paradas intermedias, " + dia + ", "+ modelo + ")");
							m++;
						}
						
						int seleccion_itinerario=int .Parse(Console.ReadLine());
						
						Recorrido itinerario_seleccionado= (Recorrido)itinerario[seleccion_itinerario-1];
						
						imprimirAbajo("¿Cuantos pasajes desea?");
						int pasajes =int.Parse(Console.ReadLine());
						
						ventas.Add(new Venta(usuario, itinerario_seleccionado,pasajes));
						imprimirAbajo("La venta se a realizado con exito.");
						imprimirAbajo("Presione ENTER para continuar.");
							
					}
					
					
			       
				}
			}
	
		}

		private bool noExisteUsiario(int dni)
		{
			bool no_existe=true;
			foreach (Usuario u in usuarios)
			{
				if (dni == u.Dni)
				{
					return no_existe=false;
				}
				
			}
			return no_existe;
		}
		
		private bool partidaRepetida(Terminal t, ArrayList terminales_de_partida)
		{
			bool terminal_repetida=false;
			
			for(int i=0 ; i<terminales_de_partida.Count; i++)
			{
				if (t.Ciudad_Donde_Se_Encuentra == ((Terminal)(terminales_de_partida[i])).Ciudad_Donde_Se_Encuentra)
				{
					return terminal_repetida=true;
				}
			}
			return terminal_repetida;
		}
		
		private bool arriboRepetido(Terminal t , ArrayList terminales_de_arribo)
		{
			bool terminal_repetida=false;
			
			for(int i=0 ; i<terminales_de_arribo.Count; i++)
			{
				if (t.Ciudad_Donde_Se_Encuentra == ((Terminal)(terminales_de_arribo[i])).Ciudad_Donde_Se_Encuentra)
				{
					return terminal_repetida=true;
				}
			}
			return terminal_repetida;
		}
		
		private bool existeItinerario(Terminal tp , Terminal ta)
		{
			bool existe_itinerario=false;
			
			{
				for (int i=0 ; !existe_itinerario ; i++)
				{
					//terminal de partida en recorridos asignados
					Terminal t_p_asignada= ((Terminal)((Recorrido)recorridos_asignados[i]).Terminales_del_recorrido[0]);
					
					//longitud ultima aterminal
					
					int ultima_terminal =((Recorrido)recorridos_asignados[i]).Terminales_del_recorrido.Count-1;
					
					//terminal de arribo en recorridos asignasdos 
					Terminal t_a_asignado=	((Terminal)((Recorrido)recorridos_asignados[i]).Terminales_del_recorrido[ultima_terminal]);
					
					if (t_p_asignada.Ciudad_Donde_Se_Encuentra == tp.Ciudad_Donde_Se_Encuentra && t_a_asignado.Ciudad_Donde_Se_Encuentra == ta.Ciudad_Donde_Se_Encuentra)
					{
						return existe_itinerario=true;
					}
				
				}
				return existe_itinerario;
				   
				    
			}
			
			
		}
		
		private ArrayList itinerarios (Terminal tp , Terminal ta)
		{
			ArrayList itinerario = new ArrayList();
			
			for (int i=0 ; i<recorridos_asignados.Count ; i++)
				{
					//terminal de partida en recorridos asignados
					Terminal t_p_asignada= ((Terminal)((Recorrido)recorridos_asignados[i]).Terminales_del_recorrido[0]);
					
					//longitud ultima aterminal
					
					int ultima_terminal =((Recorrido)recorridos_asignados[i]).Terminales_del_recorrido.Count-1;
					
					//terminal de arribo en recorridos asignasdos 
					Terminal t_a_asignado=	((Terminal)((Recorrido)recorridos_asignados[i]).Terminales_del_recorrido[ultima_terminal]);
					
					if (t_p_asignada.Ciudad_Donde_Se_Encuentra == tp.Ciudad_Donde_Se_Encuentra && t_a_asignado.Ciudad_Donde_Se_Encuentra == ta.Ciudad_Donde_Se_Encuentra)
					{
						itinerario.Add((Recorrido)recorridos_asignados[i]);
					}
			}
			return itinerario;
			
		}
		
		private Usuario compraUsuario(int dni , int nro_de_usuario)
		{
			Usuario usuario=(Usuario)usuarios[0];

			for(int i=0 ; i<usuarios.Count; i++)
			{
				if (((Usuario)usuarios[i]).Dni == dni && ((Usuario)usuarios[i]).Nro_De_Usuario == nro_de_usuario )
				{
					usuario=(Usuario)usuarios[i];
					return usuario;
				}
				
			}
			return usuario;
		}
		
	
		
		
	}
}
		
		

		
		
	


