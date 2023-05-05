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
//push test
namespace Catalogo
{

    public partial class frmAgregarArt : Form
    {
        public frmAgregarArt()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        private void btAgregarArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            
            try
            {
                articulo.Codigo = txtAgrCodigo.Text;
                articulo.Nombre= txtAgrNombre.Text;
                articulo.Descripcion= txtAgrDescripcion.Text;
                articulo.IdMarca= (int)cbxAgrMarca.SelectedIndex;
                articulo.IdCategoria=  cbxAgrCategoria.SelectedIndex;
                //Imagen aux = new Imagen();
                //aux.ImagenUrl = (string)lector["UrlImagen"];
                articulo.Precio= decimal.Parse(txtAgrPrecio.Text);
                
                ///desacomplar
                /*dB.setearConsulta("INSERT into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values ('"+articulo.Codigo+"','"+articulo.Nombre+"','"+articulo.Descripcion+"',"+articulo.IdMarca+","+articulo.IdCategoria+","+articulo.Precio+")");
                dB.ejecutarLectura();*/
                NegocioArticulo negocioArticulo = new NegocioArticulo();
                
                /*if (articulo.Id != 0)
                {//MODIFICAR
	                //realiza la consulta en la logica de negocio y retorna el bool si fue exitoso
	                



	                

                }
                else
                {//AGREGAR
	                if(negocioArticulo.guardar(articulo))
	                {
		                MessageBox.Show("Articulo agregado con exito");
		                //prue
                    
	                }
	                else
	                {
		                MessageBox.Show("Error BD");
	                }
	                
                }*/
                if(negocioArticulo.guardar(articulo))
                {
	                MessageBox.Show("Articulo modificado con exito");
	                //prue
                    
                }
                else
                {
	                MessageBox.Show("Error BD");
                }
                
                
                

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Hide();
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            try
            {
                cbxAgrMarca.DataSource = negocioMarca.listar();
                cbxAgrMarca.ValueMember = "Id";
                cbxAgrCategoria.DataSource = negocioCategoria.listar();
                cbxAgrCategoria.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            /*
             * NegocioMarca negocioMarca = new NegocioMarca();
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
             */
        }


        private void frmAgregarArt_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Refresh();
            
            
        }
    }

}
