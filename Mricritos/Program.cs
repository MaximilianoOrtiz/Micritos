/*
 * Created by SharpDevelop.
 * User: maxi
 * Date: 03/11/2018
 * Time: 04:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace Trabajo_Final
{
	class Program
	{
		public static void Main(string[] args)
		{

				Micritos micritos=new Micritos();
				
			
	 			Console.Write("********************************************************************************");
				Console.Write("*****                              Micritos                                *****");
				Console.Write("********************************************************************************");
						
				//	MENU PRINCIPAL
				menuPrincipal();
				string eleccion=Console.ReadLine();

				while(eleccion!= "4")
				{
					try{

						switch ((eleccion))
						{
							case "1":
							{
								Console.Clear();
											
								//SUB MENU DE ARMADO DE RECORRIDOS
								titulo();
							    menuArmadoRecorrido();
							    
								string eleccion1 = Console.ReadLine();
								
							
								
								while(eleccion1!="4")
								{
									try{
											
										switch (eleccion1)
										{
											case "1":
											{
												//ALTA DE TERMINALES
												
												imprimirAbajo("");
												micritos.altaDeTerminal();
												Console.ReadLine();
												Console.Clear();
												titulo();
												menuArmadoRecorrido();
												break;
											}
											case "2":
											{
												
											
												//ALTA DE OMNIBUS
												
												imprimirAbajo("");
												micritos.altaDeOmnibus();
												Console.ReadLine();
												Console.Clear();
												titulo();
												menuArmadoRecorrido();		
												break;
											}
											case "3":
											{
												
													//ALTA DE RECORRIDOS
													Console.Clear();
													Recorrido R=new Recorrido();
													micritos.altaDeRecorrido(R);
													Console.ReadLine();
													Console.Clear();
													titulo();
													menuArmadoRecorrido();
												
												break;
											}
											
										}
										
										
											if (int.Parse(eleccion1) > 4)
									 		{
									  			 throw new ArgumentOutOfRangeException();
											}
									}
									
									
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("La opción ingresada es incorrecta");
										Console.WriteLine("Presione ENTER para continuar");
										Console.ReadLine();
									}
									catch (FormatException)
									{
										Console.WriteLine("El valor ingresado es invalido");
										Console.WriteLine("Presione ENTER para continuar");
										Console.ReadLine();
									}
									catch (marcaYModeloInvalido b)
									{
										imprimirAbajo(b.Mensaje);
										imprimirAbajo("Presione ENTER para continuar.");
										Console.ReadLine();
									}
									
									
									Console.Clear();
									titulo();
									menuArmadoRecorrido();
								    eleccion1 = Console.ReadLine();

								}

							}
								titulo();
								menuPrincipal();
								break;
	
										
							case "2" :
							{
								//SUB MENU GESTION DE CHOFERES
								
								
								
								Console.Clear();
								titulo();
								menuGestionDeChoferes();
								
								string eleccion2=Console.ReadLine();
														
								while(eleccion2 != "3")
								{
								   try{
										switch(eleccion2)
										{
											case "1":
											{
											    //ALTA DE CHOFERES
				
											    imprimirAbajo("");
											    micritos.altaDeChofer();
											    Console.ReadLine();
											    Console.Clear();
											    titulo();
											    menuGestionDeChoferes();
												break;
											}
											case "2":
											{
												// ASIGNAR RECORRIDO
												Console.Clear();
											    imprimirAbajo("");
											    micritos.asignarRecorrido();
											    Console.ReadLine();
											    Console.Clear();
											    titulo();
											    menuGestionDeChoferes();
													
												break;
											}
											
																
										}
										
										
										if (int.Parse(eleccion2) > 3)
										{
										  	 throw new ArgumentOutOfRangeException();
										}
										
									
									}
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("La opción ingresada es incorrecta");
										Console.WriteLine("Presione ENTER para continuar");
										Console.ReadLine();
									}
									catch (FormatException)
									{
										Console.WriteLine("El valor ingresado es invalido");
										Console.WriteLine("Presione ENTER para continuar");
										Console.ReadLine();
											
									}
										
									Console.Clear();
									titulo();
									menuGestionDeChoferes();
									eleccion2=Console.ReadLine();
								}
								
								titulo();
								menuPrincipal();
								break;
							}
										
							case "3":
							{
								//sub menu de ventas de pasajes 
								Console.Clear();
								titulo();
								menuVentaDePasajes();
								
								string eleccion_3=Console.ReadLine();
								
								while(eleccion_3 != "3")
								{
									try{
									switch(eleccion_3)
									{
										case "1":
										{
											//ALTA DE USUARIOS
											
											imprimirAbajo("");
											micritos.altaDeUsuario();
											Console.ReadLine();
											Console.Clear();
											titulo();
											menuVentaDePasajes();
											break;
											
										}
										case "2":
											
											//VENTA DE PASAJES
									
										{
											imprimirAbajo("");
											micritos.comprarPasaje();
											Console.ReadLine();
											Console.Clear();
											titulo();
											menuVentaDePasajes();
											break;	
											
										}
		
									}
									
									if (int.Parse(eleccion_3) > 3)
									{
										  throw new ArgumentOutOfRangeException();
									}
									
									
									
									
								}
									catch (ArgumentOutOfRangeException)
									{
										Console.WriteLine("La opción ingresada es incorrecta");
										Console.WriteLine("Presione ENTER para continuar");
										Console.ReadLine();
									}
									catch (FormatException)
									{
										Console.WriteLine("El valor ingresado es invalido");
										Console.WriteLine("Presione ENTER para continuar");
										Console.ReadLine();
											
									}
										
									Console.Clear();
									titulo();
									menuVentaDePasajes();
									eleccion_3=Console.ReadLine();
								}
								
								titulo();
								menuPrincipal();
								break;
							 }
										
										
						 }

						    if (int.Parse(eleccion) > 5)
						    {
								throw new ArgumentOutOfRangeException();
					   		}
						   
					    
						}
						catch(ArgumentOutOfRangeException)
					    {
							Console.WriteLine("La opcion ingresada es incorrecta");
							Console.WriteLine("Presione ENTER para continuar");
							Console.ReadLine();
						}
						catch(FormatException)
						{
							Console.WriteLine("No ah ingresado ninguna opción.");
							Console.WriteLine("Presione ENTER para continuar");
							Console.ReadLine();
						}
						
						catch(Exepciones)
						{
							Console.WriteLine("Ah ocurrido un error inesperado.");
							Console.WriteLine("Presione Enter para continuar.");
							Console.ReadLine();
						}
						
		
					    Console.Clear();
					    menuPrincipal();
					    eleccion=Console.ReadLine();
						menuPrincipal();
					
								
							
				}
	
						
			
			
			
			
			
			
			
			
		}
			
		
		
							
					
				
				
				
				
			
			
			
			
		
		//FUNCIONES DE IMPRECIONES EN CONSOLA
		
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
		
		public static void menuPrincipal()
		{
			
			Console.Clear();
			titulo();
			Console.WriteLine(" ");
			Console.WriteLine("¿A qué modulo desea ingresar?");
			Console.WriteLine(" ");
			Console.WriteLine("1) Armado de recorridos");
			Console.WriteLine("2) Gestion de choferes ");
			Console.WriteLine("3) Venta de pasajes");
			//Console.WriteLine("4) Estadisticas");
			Console.WriteLine("4) Salir del Sistema");
			Console.WriteLine(" ");
		}
		public static void menuArmadoRecorrido()
		{
			imprimirAbajo("");
			imprimirAbajo("1) Alta de terminales");
			imprimirAbajo("2) Alta de ómnibus");
			imprimirAbajo("3) Alta de recorridos");
			imprimirAbajo("4) Volver");
			imprimirAbajo("");
		}
		public static void menuGestionDeChoferes()
		{
			imprimirAbajo("");
			imprimirAbajo("1) Alta de choferes");
			imprimirAbajo("2) Asignacion de recorridos");
			imprimirAbajo("3) Volver");
			imprimirAbajo("");
		}
		public static void menuVentaDePasajes()
		{
			imprimirAbajo("");
			imprimirAbajo("1) Alta de usuario");
			imprimirAbajo("2) Compra de pasajes");
			imprimirAbajo("3) Volver");
			imprimirAbajo("");
		}
		
	}
	
		
		
}



			
	
