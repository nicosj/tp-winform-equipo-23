using ConexionDB;
using negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
	public partial class frmEdicionMarcaCategoria : Form
	{
		public frmEdicionMarcaCategoria()
		{
			InitializeComponent();
			Text = "Agregar Marca";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Marca marca = new Marca	();
			DB dB = new DB();
			try
			{
				//marca.Id = int.Parse(txtAddMarca.Text); no se usa porque IDENTITY
				marca.Descripcion = txtAddDescripcion.Text;
				dB.setearConsulta("insert into Marcas values (@Descripcion)");
				//dB.setearParametro("@Id", marca.Id); no se usa porque IDENTITY
				dB.setearParametro("@Descripcion", marca.Descripcion);
				dB.ejecutarLectura();
				
				MessageBox.Show("Marca agregada correctamente");
				Close();

				
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}
	}
}
