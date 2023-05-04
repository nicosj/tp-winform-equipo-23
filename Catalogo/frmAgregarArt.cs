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
            DB dB = new DB();
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

                dB.setearConsulta("INSERT into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values ('"+articulo.Codigo+"','"+articulo.Nombre+"','"+articulo.Descripcion+"',"+articulo.IdMarca+","+articulo.IdCategoria+","+articulo.Precio+")");
                dB.ejecutarLectura();
                MessageBox.Show("Articulo agregado con exito");

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            try
            {
                cbxAgrMarca.DataSource = negocioMarca.listar();
                cbxAgrMarca.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
