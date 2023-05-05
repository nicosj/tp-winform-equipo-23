using ConexionDB;
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
    public partial class frmAddCategoria : Form
    {
        public frmAddCategoria()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            DB dB = new DB();
            try
            {
                categoria.Descripcion = txtAddCategoria.Text;
                dB.setearConsulta("insert into Categorias values (@Descripcion)");
                dB.setearParametro("@Descripcion", categoria.Descripcion);
                dB.ejecutarLectura();
                MessageBox.Show("Marca agregada correctamente");
                Close();


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
    }
}
