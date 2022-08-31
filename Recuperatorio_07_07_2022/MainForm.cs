/*
 * Alumno: Paez Matias Adrian
 * Asignatura: Analisis de Sistemas 
 * DNI: 42921010
 * L.U: 13456
 * Fecha: 7/7/2022
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Recuperatorio_07_07_2022
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Btn_RegisttrarClick(object sender, EventArgs e)
		{
			if (control())
			{
				RegistrarEstacionamiento();
				LimpiarCampos();
			}
			else
			{
				MessageBox.Show("complete correctamente los campos");
			}

	
		}
		
		public bool campocompleto(string cadena)
		{
			return (cadena.Length > 0);
		}
		
		public bool control()
		{
			bool bandera = true;
			int num;
			int ingreso;
			int egreso;
			
			if(!campocompleto(text_nombre.Text))
			{
				bandera = false;
			}
			
			if(!campocompleto(text_apellido.Text))
			{
				bandera = false;
			}
			
			if(!campocompleto(text_marca.Text))
			{
				bandera = false;
			}
			
			if(!campocompleto(text_modelo.Text))
			{
				bandera = false;
			}
			
			if(!campocompleto(text_patente.Text))
			{
				bandera = false;
			}
			
			if(!campocompleto(text_dirr.Text))
			{
				bandera = false;
			}
			if(!int.TryParse(text_dni.Text, out num))
			{
				bandera = false;
			}
			
			if(!int.TryParse(text_egreso.Text, out egreso))
			{
				
				bandera = false;
			}
			
			if(!int.TryParse(text_ingreso.Text, out ingreso))
			{
				bandera = false;
			}
			
			if ((ingreso< 7)||(egreso > 23))
			{
				bandera= false;
			}
			return bandera;
		}
		
		
		public void RegistrarEstacionamiento ()
		{
			//datos de la persona
			string nombrecompleto = text_nombre.Text +" " +text_apellido.Text;
			string direccion = text_dirr.Text;
			Int32 dni= Convert.ToInt32(text_dni.Text);
			Int32 tel = Convert.ToInt32(text_cel.Text);
			
			//instancio un objeto persona 
			Persona p1 = new Persona(nombrecompleto, direccion,tel, dni);
			
			//datos del vehiculo
			
			string marca = text_marca.Text;
			string modelo = text_modelo.Text;
			string color = text_color.Text;
			string patente = text_patente.Text;
			
			//instancio un objeto vehiculo
			
			Vehiculo v1 = new Vehiculo(marca, modelo,patente,color);
			
			double ingreso =Convert.ToDouble( text_ingreso.Text);
			double egreso = Convert.ToDouble(text_egreso.Text);
			
			v1.setHoradeEgreso(egreso);
			v1.setHoradeingreso(ingreso);
			
			//calculo la tarifa
			p1.CalculoTarifa((egreso-ingreso));
			
			//informo del registro
			
			MessageBox.Show("El Servicio Tiene un costo de " + p1.GetTarifa().ToString()+"\n"+"Datos Personales:\n"+ p1.getDatosPersona()+"Datos del Vehiculo:\n"+v1.getDatos());
		}
		
		public void LimpiarCampos()
		{
			//persona
			text_dni.Clear();
			text_nombre.Clear();
			text_apellido.Clear();
			text_cel.Clear();
			text_dirr.Clear();
			
			//vehiculo
			text_marca.Clear();
			text_modelo.Clear();
			text_patente.Clear();
			text_color.Clear();
			
			text_ingreso.Clear();
			text_egreso.Clear();
			
		}
		
		//si preciono el btn close , cierro el programa
		void Btn_closeClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
