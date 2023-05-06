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
using Dominio;


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
			public void cargar()
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
			cargar();

		}

		private void btnDelMarca_Click(object sender, EventArgs e)
		{
			eliminarmarca();
		}
			private void eliminarmarca()
			{
				NegocioMarca negocio = new NegocioMarca();
				Marca seleccionado;

				try
				{
					DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar la Marca?", "Esta acción es irreversible", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (respuesta == DialogResult.Yes)
					{
						seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
						negocio.eliminar(seleccionado.Id);
						cargar();
					}
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.ToString());
				}
			}

       

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            frmAddCategoria categoria = new frmAddCategoria();
            categoria.ShowDialog();
            cargar();
        }

       
        private void eliminarcategoria()
        {
            NegocioCategoria categoria = new NegocioCategoria();
            Categoria seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar la Categoria?", "Esta acción es irreversible", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    categoria.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelCategoria_Click_1(object sender, EventArgs e)
        {
			eliminarcategoria();
        }

        private void btnModCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAddCategoria modificar = new frmAddCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

		private void btnModMarca_Click(object sender, EventArgs e)
		{
			Marca seleccionado;
			seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
			frmAddMarca modificar = new frmAddMarca(seleccionado);
			modificar.ShowDialog();
			cargar();
		}
	}
}
