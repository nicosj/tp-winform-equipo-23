using ConexionDB;
using Dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
	public partial class frmAddCategoria : Form
	{
		private Categoria categoria = null;
		public frmAddCategoria()
		{
			InitializeComponent();
		}

		//constructor sobrecargado para usar la misma ventana para agregar y modificar//
		public frmAddCategoria(Categoria categoria)
		{
			InitializeComponent();
			this.categoria = categoria;
			//PARA CAMBIAR EL COLOR DE LA VENTANA CUANDO SE EJECUTA "MODIFICAR"
			this.BackColor = Color.FromArgb(255, 255, 192);
			Text = "Modificar categoria";
		}



		private void btAceptar_Click(object sender, EventArgs e)
		{
			//Categoria categoria = new Categoria();
			DB dB = new DB();
			try
			{
				if (categoria == null)
				{
					categoria = new Categoria();
				}
				//categoria.Id = int.Parse(txtAddID.Text);
				categoria.Descripcion = txtAddCategoria.Text;
				// categoria.Id =txtAddID.Text
				int IdComparable = categoria.Id;



				if (IdComparable != 0)
				{
					dB.setearConsulta("update Categorias set Descripcion=@Descripcion WHERE Id=@id");
					dB.setearParametro("@Descripcion", categoria.Descripcion);
					dB.setearParametro("@id", categoria.Id);
					dB.ejecutarLectura();
					MessageBox.Show("Categoria modificada correctamente");
					Close();
				}
				else
				{
					dB.setearConsulta("insert into Categorias values (@Descripcion)");
					dB.setearParametro("@Descripcion", categoria.Descripcion);
					dB.ejecutarLectura();
					MessageBox.Show("Categoria agregada correctamente");
					Close();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void btCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmAddCategoria_Load(object sender, EventArgs e)
		{
			NegocioCategoria negociocategoria = new NegocioCategoria();
			try
			{
			
				txtAddCategoria.Text = "Descripcion";

				if (categoria != null)
				{
					txtAddCategoria.Text = categoria.Descripcion;
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


    }
}
