/*
 * Creado por SharpDevelop.
 * Usuario: HP
 * Fecha: 7/7/2022
 * Hora: 08:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Recuperatorio_07_07_2022
{
	public class Vehiculo
	{
		//atributos
		String Marca;
		String Modelo; 
		String Patente;
		String Color;
		double HoradeIngreso;
		double HoradeEgreso;
		
		public Vehiculo(String marca , String modelo , String patente, String color)
		{
			Marca= marca;
			Modelo =modelo;
			Patente = patente; 
			Color = color;
		}
		//set
		
		public void setHoradeingreso(double hora)
		{
			HoradeIngreso = hora;
		}
		
		public void setHoradeEgreso(double hora)
		{
			HoradeEgreso = hora;
		}
		
		//get
		public double getHoradeIngreso ()
		{
			return HoradeIngreso;
		}
		
		public double getHoradeEgreso ()
		{
			return HoradeEgreso;
		}
		
		public String getDatos()
		{
			String imprimir = "Marca :"+Marca +"\nModelo:"+Modelo+"\nParente: "+Patente+"\nColor:"+Color +"\nIngreso:"+ HoradeIngreso.ToString()+"\nSalida: "+HoradeEgreso.ToString();
			return imprimir;
		}
	}
}
