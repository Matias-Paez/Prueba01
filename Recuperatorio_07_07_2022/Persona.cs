
using System;

namespace Recuperatorio_07_07_2022
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		//atributos 
		private String NombreCompleto;
		private String Direccion;
		private Int32 Telefono;
		private Int32 DNI;
		private double Tarifa;
		
		public Persona(String nombre,  String direccion , Int32 telefeno, Int32 dni )
		{
			NombreCompleto = nombre;
			Direccion = direccion;
			Telefono= telefeno;
			DNI= dni;
		}
		
		//
		
		public String getDatosPersona()
		{
			String imprimir= "Nombre : "+NombreCompleto +"\n";
			return imprimir;
		}
		
		
		
		//metodoo para calcular la tarifa
		
		public void CalculoTarifa (double horas)
		{
			Tarifa = horas*250; 
		}
		
		public double GetTarifa()
		{
			return Tarifa;
		}
		
	}
}
