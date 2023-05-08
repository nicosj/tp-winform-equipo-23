using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
		private List<Imagen> listadoImagenx;
		private int contClick = 0;
		private int maxImg = 0;
		private int pivot = 0;
		private int _pictureIndex = 0;
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
			dgvArticulos.Columns["Id"].Visible = false;
			dgvArticulos.Columns["IdMarca"].Visible = false;
			dgvArticulos.Columns["IdCategoria"].Visible = false;
			dgvArticulos.Columns["Descripcion"].Visible = false;
			dgvArticulos.Columns["Nombre"].Width = 160;
			dgvArticulos.Columns["Codigo"].Width = 100;
			dgvArticulos.Columns["Precio"].Width = 100;

			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.Load("https://xmeme-fe.netlify.app/src/placeholder-xmeme.jpg");
		}


		//private void cargarImagen(string imagen)
		//{
		//    try
		//    {
		//        pbxArticulo.Load(imagen);
		//    }
		//    catch (Exception ex)
		//    {
		//        pbxArticulo.Load("https://xmeme-fe.netlify.app/src/placeholder-xmeme.jpg");
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

			listafiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(txtFiltro.Text.ToLower()) || x.Codigo.ToLower().Contains(txtFiltro.Text.ToLower()) || x.Descripcion.ToLower().Contains(txtFiltro.Text.ToLower()));
			dgvArticulos.DataSource = null;
			dgvArticulos.DataSource = listafiltrada;
			dgvArticulos.Columns["Id"].Visible = false;
			dgvArticulos.Columns["IdMarca"].Visible = false;
			dgvArticulos.Columns["IdCategoria"].Visible = false;
			dgvArticulos.Columns["Descripcion"].Visible = false;

			dgvArticulos.Columns["Nombre"].Width = 160;
			dgvArticulos.Columns["Codigo"].Width = 100;
			dgvArticulos.Columns["Precio"].Width = 100;
		}

		private void btnAdministrarMyC_Click(object sender, EventArgs e)
		{
			frmAdmin_Marca_Categoria admin = new frmAdmin_Marca_Categoria();
			admin.ShowDialog();
		}




		private void imagenLoad(object sender, EventArgs e)
		{

			NegocioMarca negocioMarca = new NegocioMarca();
			NegocioCategoria negocioCategoria = new NegocioCategoria();
			NegocioArticulo negocioArticulo = new NegocioArticulo();
			List<Marca> listaMarca = new List<Marca>();
			List<Categoria> listaCategoria = new List<Categoria>();
			List<Articulo> listaArticulo = new List<Articulo>();
			listaMarca = negocioMarca.listar();
			listaCategoria = negocioCategoria.listar();
			listaArticulo = negocioArticulo.listar();

			NegocioImagen negocioImagen = new NegocioImagen();
			List<Imagen> listadoImagen = new List<Imagen>();
			listadoImagen = negocioImagen.listar();
			Articulo seleccionado;
			seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

			if (pivot == seleccionado.Id)
			{

			}
			else
			{
				foreach(Articulo articulo in listaArticulo)
				{
					if (articulo.Id == seleccionado.Id)
					{
						txtDetallesDescripcion.Text = articulo.Descripcion;
						foreach (Marca item in listaMarca)
						{
							if (item.Id == articulo.IdMarca)
							{
								txtDetalleMarca.Text = item.Descripcion;
							}
						}
						foreach (Categoria item in listaCategoria)
						{
							if (item.Id == articulo.IdCategoria)
							{
								txtDetalleCategoria.Text = item.Descripcion;
							}
						}
					}
				}
				maxImg = 0;
				contClick = 0;
				pivot = seleccionado.Id;
				listadoImagenx = new List<Imagen>();
				foreach (Imagen item in listadoImagen)
				{
					if (item.IdArticulo == seleccionado.Id)
					{
						listadoImagenx.Add(item);
						maxImg++;
					}
				}
				if (maxImg != 0)
				{
					pictureBox1.Load(listadoImagenx[contClick].ImagenUrl);
				}
				else
				{
					pictureBox1.Load("https://cloudfront-us-east-1.images.arcpublishing.com/infobae/BLZJHTB27ZHUPKK3A7GXTMIEQA.jpg");
				}
			}

		}
		private void Next_Click(object sender, EventArgs e)
		{
			if (listadoImagenx.Count > 1)
			{
				_pictureIndex++;
				if (_pictureIndex > listadoImagenx.Count - 1)
				{
					_pictureIndex = listadoImagenx.Count - 1;
				}
			}
			else
			{
				_pictureIndex = 0;
			}

			pictureBox1.Load(listadoImagenx[_pictureIndex].ImagenUrl);
		}
		private void Previous_Click(object sender, EventArgs e)
		{
			if (listadoImagenx.Count > 1)
			{
				_pictureIndex--;
				if (_pictureIndex < 0)
				{
					_pictureIndex = 0;
				}

			}
			else
			{
				_pictureIndex = 0;

			}

			pictureBox1.Load(listadoImagenx[_pictureIndex].ImagenUrl);

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}