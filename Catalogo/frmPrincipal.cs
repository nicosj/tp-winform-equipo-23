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
using Dominio;
using negocio;


namespace Catalogo
{
	public partial class frmPrincipal : Form
	{
		private List<Articulo> listaArticulo;
		public frmPrincipal()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			cargar();
		}
		//FUNCION PARA RELODEAR EL FORMULARIO PRINCIPAL//
		private void cargar()
		{
			NegocioArticulo negocio = new NegocioArticulo();
			listaArticulo = negocio.listar();
			dgvArticulos.DataSource = negocio.listar();
			
		}


        //private void cargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbxArticulo.Load(imagen);
        //    }
        //    catch (Exception ex)
        //    {
        //        pbxArticulo.Load("https://cloudfront-us-east-1.images.arcpublishing.com/infobae/BLZJHTB27ZHUPKK3A7GXTMIEQA.jpg");
        //    }
        //}




            private void btAgregar_Click(object sender, EventArgs e)
		{
			frmAgregarArt alta = new frmAgregarArt();
			alta.ShowDialog();
			cargar();

		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			Articulo seleccionado;
			seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
			frmAgregarArt modificar = new frmAgregarArt(seleccionado);
			modificar.ShowDialog();
			cargar();

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			eliminar();
		}
		private void eliminar()
		{
			NegocioArticulo negocio = new NegocioArticulo();
			Articulo seleccionado;

			try
			{
				DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar el Articulo?", "Esta acción es irreversible", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (respuesta == DialogResult.Yes)
				{
					seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
					negocio.eliminar(seleccionado.Id);
					cargar();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

        private void btFiltro_Click(object sender, EventArgs e)
        {
			List<Articulo> listafiltrada;

			listafiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(txtFiltro.Text.ToLower())|| x.Codigo.ToLower().Contains(txtFiltro.Text.ToLower()) || x.Descripcion.ToLower().Contains(txtFiltro.Text.ToLower()));
			dgvArticulos.DataSource = null;
			dgvArticulos.DataSource = listafiltrada;
        }

		private void btnAdministrarMyC_Click(object sender, EventArgs e)
		{
			frmAdmin_Marca_Categoria admin = new frmAdmin_Marca_Categoria();
			admin.ShowDialog();
		}
	}
}