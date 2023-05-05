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
using negocio;


namespace Catalogo
{
    public partial class frmPrincipal : Form
    {
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
												dataGridView1.DataSource = negocio.listar();
								}

        private void btAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt alta = new frmAgregarArt();
            alta.ShowDialog();

            //Refresh datagridview
            Form1_Load(sender, e);
            

        }

      
    }
/*=======
            cargar();
        
        }

				private void btnModificar_Click(object sender, EventArgs e)
				{
      Articulo seleccionado;
      seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
      frmAgregarArt modificar = new frmAgregarArt(seleccionado);
      modificar.ShowDialog();
      cargar();

				}
		}
>>>>>>> 15b05036aadbaecadbddccdcf831bc320e52bae8*/
}