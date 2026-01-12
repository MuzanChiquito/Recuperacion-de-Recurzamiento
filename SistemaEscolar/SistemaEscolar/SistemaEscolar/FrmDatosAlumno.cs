/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
{
	/// <summary>
	/// Description of FrmDatosAlumno.
	/// </summary>
	public partial class FrmDatosAlumno : Form
	{
			public FrmDatosAlumno(string n, string a, string e, string m, string c,
                      string s, string g, string t, string co, string d)
					{
    					InitializeComponent();
    					lblDatos.Text =
        					"Nombre: " + n + "\n" +
        					"Apellido: " + a + "\n" +
        					"Edad: " + e + "\n" +
        					"Matrícula: " + m + "\n" +
        					"Carrera: " + c + "\n" +
        					"Semestre: " + s + "\n" +
        					"Grupo: " + g + "\n" +
        					"Teléfono: " + t + "\n" +
        					"Correo: " + co + "\n" +
        					"Dirección: " + d;
					}

		
	}
}
