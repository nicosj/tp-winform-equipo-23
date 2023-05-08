using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
		private int borderSize = 2;
		private Size formSize;
		
		public frmPrincipal()
		{
			InitializeComponent();
			
				
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			
			ForeColor = Color.FromArgb(0, 0, 0);
			this.Padding = new Padding(borderSize);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			StartPosition = FormStartPosition.CenterScreen;
			BackColor = Color.FromArgb(204, 255, 255);
			ForeColor= Color.FromArgb(0, 0, 0);
			Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			
			cargar();

			button1.BackColor= Color.BlueViolet;
			
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

				try
				{
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
				catch (Exception)
				{

					MessageBox.Show("Problemas al cargar imagen, intente nuevamente");
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

			try
			{
			pictureBox1.Load(listadoImagenx[_pictureIndex].ImagenUrl);

			}
			catch (Exception)
			{

				MessageBox.Show("Articulo sin imagen disponible");
				pictureBox1.Load("https://xmeme-fe.netlify.app/src/placeholder-xmeme.jpg");


            }
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

			try
			{
				pictureBox1.Load(listadoImagenx[_pictureIndex].ImagenUrl);
			}
		
			catch (Exception)
			{

				MessageBox.Show("Articulo sin imagen disponible");
				pictureBox1.Load("https://xmeme-fe.netlify.app/src/placeholder-xmeme.jpg");


			}
			
		}
		
	
		    //Overridden methods
    protected override void WndProc(ref Message m)
    {
        const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
        const int WM_SYSCOMMAND = 0x0112; 
        const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        const int SC_RESTORE = 0xF120; //Restore form (Before)
        const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        const int resizeAreaSize = 10;

        #region Form Resize
        // Resize/WM_NCHITTEST values
        const int HTCLIENT = 1; //Represents the client area of the window
        const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

        ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

        if (m.Msg == WM_NCHITTEST)
        { //If the windows m is WM_NCHITTEST
            base.WndProc(ref m);
            if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
            {
                if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                {
                    Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                    Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                    if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                    {
                        if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                            m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                        else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                            m.Result = (IntPtr)HTTOP; //Resize vertically up
                        else //Resize diagonally to the right
                            m.Result = (IntPtr)HTTOPRIGHT;
                    }
                    else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                    {
                        if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                            m.Result = (IntPtr)HTLEFT;
                        else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                            m.Result = (IntPtr)HTRIGHT;
                    }
                    else
                    {
                        if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                            m.Result = (IntPtr)HTBOTTOM;
                        else //Resize diagonally to the right
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                    }
                }
            }
            return;
        }
        #endregion

        //Remove border and keep snap window
        if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        {
            return;
        }

        //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
        if (m.Msg == WM_SYSCOMMAND)
        {
            /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
            /// Quote:
            /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
            /// are used internally by the system.To obtain the correct result when testing 
            /// the value of wParam, an application must combine the value 0xFFF0 with the 
            /// wParam value by using the bitwise AND operator.
            int wParam = (m.WParam.ToInt32() & 0xFFF0);               

            if (wParam == SC_MINIMIZE)  //Before
                formSize = this.ClientSize;
            if (wParam == SC_RESTORE)// Restored form(Before)
                this.Size = formSize;
        }
        base.WndProc(ref m);
    }

    private void close_Click(object sender, EventArgs e)
    {
	    DialogResult result = MessageBox.Show("¿Cerrar Formulario?", "Catalogo", MessageBoxButtons.YesNo);
	    if (result == DialogResult.Yes)
	    {
		    Close();
	    }
	    
    }
	}
}