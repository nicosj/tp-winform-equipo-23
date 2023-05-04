using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using ConexionDB;
using negocio;

namespace Catalogo
{
		public partial class frmAgregarArt : Form
		{
				private Articulo articulo = null;

				public frmAgregarArt()
				{

						InitializeComponent();
						Text = "Agregar Articulo";

				}

				//constructor sobrecargado para usar la misma ventana para agregar y modificar//
				public frmAgregarArt(Articulo articulo)
				{
						InitializeComponent();
						this.articulo = articulo;
						Text = "Modificar Articulo";
				}

				private void btCancelar_Click(object sender, EventArgs e)
				{
						Close();
				}

				private void btAgregarArt_Click(object sender, EventArgs e)
				{
						//Articulo articulo = new Articulo();
						DB dB = new DB();
						try
						{
								if(articulo == null)
								{
										articulo = new Articulo();
								}
								articulo.Codigo = txtAgrCodigo.Text;
								articulo.Nombre = txtAgrNombre.Text;
								articulo.Descripcion = txtAgrDescripcion.Text;
								articulo.IdMarca = (int)cbxAgrMarca.SelectedValue;
								articulo.IdCategoria = (int)cbxAgrCategoria.SelectedValue;
								//Imagen aux = new Imagen();
								//aux.ImagenUrl = (string)lector["UrlImagen"];
								articulo.Precio = decimal.Parse(txtAgrPrecio.Text);



								//TODO: Pasar MODIF Y AGR esto a funciones y ponerle try y catchsss
								if (articulo.Id != 0)
								{//MODIFICAR
										dB.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idMarca, IdCategoria = @idCategoria , Precio = @precio WHERE Id = @id");
										dB.setearParametro("@codigo", articulo.Codigo);
										dB.setearParametro("@nombre", articulo.Nombre);
										dB.setearParametro("@desc", articulo.Descripcion);
										dB.setearParametro("@idMarca", articulo.IdMarca);
										dB.setearParametro("@idCategoria", articulo.IdCategoria);
										dB.setearParametro("@precio", articulo.Precio);
										dB.setearParametro("@id", articulo.Id);

										dB.ejecutarLectura();


										MessageBox.Show("Articulo modificado con exito");

								}
								else
								{//AGREGAR
										dB.setearConsulta("INSERT into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values ('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.IdMarca + "," + articulo.IdCategoria + "," + articulo.Precio + ")");
										dB.ejecutarLectura();
										MessageBox.Show("Articulo agregado con exito");
								}

						}
						catch (Exception ex)
						{

								MessageBox.Show(ex.ToString());
						}
				}

				private void frmAgregarArt_Load(object sender, EventArgs e)
				{
						NegocioMarca negocioMarca = new NegocioMarca();
						NegocioCategoria negocioCategoria = new NegocioCategoria();
						try
						{
								cbxAgrMarca.DataSource = negocioMarca.listar();
								cbxAgrMarca.ValueMember = "Id";
								cbxAgrMarca.DisplayMember	= "Descripcion";
								cbxAgrCategoria.DataSource = negocioCategoria.listar();
								cbxAgrCategoria.ValueMember = "Id";
								cbxAgrCategoria.DisplayMember	= "Descripcion";

								if(articulo != null)
								{
										txtAgrCodigo.Text = articulo.Codigo;
										txtAgrNombre.Text = articulo.Nombre;
										txtAgrDescripcion.Text = articulo.Descripcion;
										cbxAgrMarca.SelectedValue = articulo.IdMarca;
										cbxAgrCategoria.SelectedValue = articulo.IdCategoria;												
										txtAgrPrecio.Text = articulo.Precio.ToString();
								}
						}
						catch (Exception ex)
						{

								MessageBox.Show(ex.ToString());
						}
				}
		}
}
