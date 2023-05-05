using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDB;


namespace Catalogo
{
	public partial class frmAdmin_Marca_Categoria : Form
	{
		public frmAdmin_Marca_Categoria()
		{
			InitializeComponent();
		}

		private void frmAdmin_Marca_Categoria_Load(object sender, EventArgs e)
		{
			cargar();
		}
			private void cargar()
			{
				NegocioMarca marca = new NegocioMarca();
				dgvMarcas.DataSource = marca.listar();

				NegocioCategoria categoria = new NegocioCategoria();	
				dgvCategorias.DataSource = categoria.listar();
			}

		private void btnAddMarca_Click(object sender, EventArgs e)
		{
			frmAddMarca marca = new frmAddMarca();
			marca.ShowDialog();

		}
	}
}
