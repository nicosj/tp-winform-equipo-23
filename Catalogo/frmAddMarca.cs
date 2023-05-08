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
	public partial class frmAddMarca : Form
	{
		private Marca marca = null;
		public frmAddMarca()
		{
			InitializeComponent();
			Text = "Agregar Marca";
		}
		//constructor sobrecargado para usar la misma ventana para agregar y modificar//
		public frmAddMarca(Marca marca)
		{
			InitializeComponent();
			this.marca = marca;//acá seteo la marca que nace nulla, para luego evaluar con el IF//
			//PARA CAMBIAR EL COLOR DE LA VENTANA CUANDO SE EJECUTA "MODIFICAR"
			this.BackColor = Color.FromArgb(255, 255, 192);
			Text = "Modificar Marca";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			//Marca marca = new Marca	();
			DB dB = new DB();
			try
			{
				if(marca == null)
				{
					marca = new Marca();
				}

				marca.Descripcion = txtAddDescripcion.Text;
				int IdComparable = marca.Id;

				if (IdComparable != 0)
				{
					dB.setearConsulta("update Marcas set Descripcion=@Descripcion WHERE Id=@id");
					dB.setearParametro("@Descripcion", marca.Descripcion);
					dB.setearParametro("@id", marca.Id);
					dB.ejecutarLectura();
					MessageBox.Show("Marca modificada correctamente");
					Close();
				}
				else
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

				
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void frmAddMarca_Load(object sender, EventArgs e)
		{
			NegocioMarca negociomarca = new NegocioMarca();
			try
			{
				//txtAddID.Text = "Id";
				txtAddDescripcion.Text = "Descripcion";

				if (marca != null)
				{
					txtAddDescripcion.Text = marca.Descripcion;
					//txtAddID.Text = marca.Id.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
